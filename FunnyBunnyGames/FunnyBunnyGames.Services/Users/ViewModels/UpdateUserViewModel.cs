using FunnyBunnyGames.Data;
using System.ComponentModel.DataAnnotations;

namespace FunnyBunnyGames.Services.Users.ViewModels
{
    public class UpdateUserViewModel
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(Constants.MAX_LENGHT_FOR_USER_FIRSTNAME)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(Constants.MAX_LENGHT_FOR_USER_LASTNAME)]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get; set;}
    }
}
