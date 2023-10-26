using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime;

namespace FunnyBunnyGames.Data.Models
{
    public class Game
    {
        [Key]
        public Guid Id { get; set; }

        public Guid GenreId { get; set; }

        public Guid CompanyId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Price { get; set; }

        public int AgeRestriction { get; set; }

        public string ImageUrl { get; set; }

        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<Favourite> Favourites { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
