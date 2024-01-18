using System.ComponentModel.DataAnnotations;

namespace FunnyBunnyGames.Services.Comments.ViewModels
{
    public class CommentViewModel
    {
        [Required]
        public string Value { get; set; } = null!;
    }
}
