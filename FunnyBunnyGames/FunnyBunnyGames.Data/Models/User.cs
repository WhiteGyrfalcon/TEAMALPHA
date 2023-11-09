using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunnyBunnyGames.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        [Required]
        [StringLength(Constants.MAX_LENGHT_FOR_USER_FIRSTNAME)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(Constants.MAX_LENGHT_FOR_USER_LASTNAME)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }

        public ICollection<Rating> Rating { get; set; } = new List<Rating>();

        public ICollection<Favourite> Favourites { get; set; } = new List<Favourite>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
