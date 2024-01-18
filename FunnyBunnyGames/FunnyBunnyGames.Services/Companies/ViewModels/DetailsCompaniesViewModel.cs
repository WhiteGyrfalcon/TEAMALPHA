using FunnyBunnyGames.Data.Models;

namespace FunnyBunnyGames.Services.Companies.ViewModels
{
    public class DetailsCompaniesViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
            = new List<Game>();
    }
}
