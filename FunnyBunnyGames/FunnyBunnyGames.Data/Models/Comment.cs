using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Data.Models
{
    public class Comment
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid GameId { get; set; }
        [Required]
        [StringLength(Constants.MAX_LENGHT_FOR_COMMENT_VALUE)]
        public string Value { get; set; }

        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        [ForeignKey(nameof(GameId))]
        public Game? Game { get; set; }
    }
}
