using System.ComponentModel.DataAnnotations;
using FunnyBunnyGames.Data;
using FunnyBunnyGames.Data.Models;


namespace FunnyBunnyGames.Services.Companies.ViewModels
{
    public class CreateCompaniesViewModel
    {
        [Required]
        [StringLength(Constants.MAX_LENGTH_FOR_COMPANY_NAME)]
        public string Name { get; set; } = null!;

        public ICollection<Game> Games { get; set; }
            = new List<Game>();
    }
}
