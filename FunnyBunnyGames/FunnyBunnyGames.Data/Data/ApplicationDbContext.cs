using FunnyBunnyGames.Data.Data.Configuration;
using FunnyBunnyGames.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web.FunnyBunnyGames.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CommentsConfiguration());
            builder.ApplyConfiguration(new CompanyConfiguration());
            builder.ApplyConfiguration(new FavouritesConfiguration());
            builder.ApplyConfiguration(new GamesConfiguration());
            builder.ApplyConfiguration(new GenresConfiguration());
            builder.ApplyConfiguration(new RatingsConfiguration());
            builder.ApplyConfiguration(new UsersConfiguration());
            builder.ApplyConfiguration(new IdentityRoleConfiguration());
        }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Favourite> Favourites { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Rating> Ratings { get; set; }
    }
}