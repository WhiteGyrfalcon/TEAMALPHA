using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Genres.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Services.Games.ViewModel
{
    public class UpdateGameViewModel
    {
        public Guid GenreId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public DateTime? ReleaseDate { get; set; }
        public double Price { get; set; }
        public int AgeRestriction { get; set; }
        public string ImageUrl { get; set; } = null!;
        public ICollection<GenresViewModel> Genres { get; set; } = new List<GenresViewModel>();
    }
}
