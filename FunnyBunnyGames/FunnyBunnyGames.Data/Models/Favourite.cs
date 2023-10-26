using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunnyBunnyGames.Data.Models
{
    public class Favourite
    {
        [Key]
        public Guid Id { get; set; }

        public Guid GameId { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
