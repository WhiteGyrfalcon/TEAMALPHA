using System.ComponentModel.DataAnnotations;

namespace FunnyBunnyGames.Data.Models
{
    public class Company
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(Constants.MAX_LENGHT_FOR_COMPANY_NAME)]
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
