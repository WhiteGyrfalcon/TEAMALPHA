using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunnyBunnyGames.Data.Models
{
    public class Game
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid GenreId { get; set; }

        [Required]
        public Guid CompanyId { get; set; }

        [Required]
        [StringLength(Constants.MAX_LENGTH_FOR_GAME_NAME)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(Constants.MAX_LENGTH_FOR_GAME_DESCRIPTION)]
        public string Description { get; set; } = null!;

        public DateTime? ReleaseDate { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int AgeRestriction { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [ForeignKey(nameof(GenreId))]
        public Genre? Genre { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public Company? Company { get; set; }

        public ICollection<Rating> Ratings { get; set; } 
            = new List<Rating>();

        public ICollection<Favourite> Favourites { get; set; } 
            = new List<Favourite>();

        public ICollection<Comment> Comments { get; set; } 
            = new List<Comment>();
    }
}
