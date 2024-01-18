using FunnyBunnyGames.Data;
using FunnyBunnyGames.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace FunnyBunnyGames.Services.Companies.ViewModels
{
    public class UpdateCompaniesViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(Constants.MAX_LENGHT_FOR_COMPANY_NAME)]
        public string Name { get; set; } = null!;

        public ICollection<Game> Games { get; set; }
            = new List<Game>();
    }
}
