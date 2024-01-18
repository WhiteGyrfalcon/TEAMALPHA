using System.ComponentModel.DataAnnotations;

namespace FunnyBunnyGames.Data.Models
{
    public class Genre
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(Constants.MAX_LENGTH_FOR_GENRE_NAME)]
        public string Name { get; set; } = null!;

        public ICollection<Game> Games  { get; set; } = new List<Game>();
    }
}
