using FunnyBunnyGames.Data;
using System.ComponentModel.DataAnnotations;

namespace FunnyBunnyGames.Services.Users.ViewModels
{
    public class UpdateUserViewModel
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(Constants.MAX_LENGTH_FOR_USER_FIRST_NAME)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(Constants.MAX_LENGTH_FOR_USER_LAST_NAME)]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get; set;}
    }
}
