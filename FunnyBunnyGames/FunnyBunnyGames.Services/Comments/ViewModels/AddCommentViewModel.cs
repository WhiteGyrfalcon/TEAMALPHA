using FunnyBunnyGames.Data;
using System.ComponentModel.DataAnnotations;

namespace FunnyBunnyGames.Services.Comments.ViewModels
{
    public class AddCommentViewModel
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid GameId { get; set; }

        [Required]
        [StringLength(Constants.MAX_LENGHT_FOR_COMMENT_VALUE)]
        public string Value { get; set; } = null!;
    }
}
