using System.ComponentModel.DataAnnotations;

namespace FunnyBunnyGames.Data.Models
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Game> Games  { get; set; }
    }
}
