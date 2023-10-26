using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunnyBunnyGames.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public ICollection<Rating> Rating { get; set; }

        public ICollection<Favourite> Favourites { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
