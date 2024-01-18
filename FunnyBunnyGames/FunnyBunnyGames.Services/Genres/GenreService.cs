using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Genres.ViewModel;
using Microsoft.EntityFrameworkCore;
using Web.FunnyBunnyGames.Data;

namespace FunnyBunnyGames.Services.Genres
{
    public class GenreService : IGenreService
    {
        private readonly ApplicationDbContext context;
        public GenreService(ApplicationDbContext dbContext)
        {
            this.context = dbContext;
        }

        public async Task<GenresViewModel> GetGenreAsync(Guid id)
        {
            var model = await this.context.Genres.FirstOrDefaultAsync(x => x.Id == id);

            var genre = new GenresViewModel()
            {
                Id = model.Id,
                Name = model.Name,
            };

            return genre;
        }

        public async Task DeleteGenreAsync(Guid id)
        {
            Genre? genre = await this.context.Genres.FirstOrDefaultAsync(x => x.Id == id);

            if (genre != null)
            {
                this.context.Genres.Remove(genre);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task<List<GenresViewModel>> ListGenresAsync()
        {
            var models = await this.context.Genres
                .Select(s => new GenresViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                })
                .ToListAsync();

            return models;
        }

        public async Task CreateGenreAsync(GenresViewModel request)
        {
            Genre genre = new Genre()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
            };

            await context.Genres.AddAsync(genre);
            await context.SaveChangesAsync();
        }
    }
}
