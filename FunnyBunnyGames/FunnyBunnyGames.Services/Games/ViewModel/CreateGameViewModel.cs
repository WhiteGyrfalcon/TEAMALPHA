using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Genres.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Services.Games.ViewModel
{
    public class CreateGameViewModel
    {
        [Required]
        public Guid GenreId { get; set; }
       
        [Required]
        public Guid CompanyId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(300)]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int AgeRestriction { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        public ICollection<GenresViewModel> Genres { get; set; } = new List<GenresViewModel>();

        //TODO:
        //public ICollection<CompanyViewModel> MyProperty { get; set; } = new List<CompanyViewModel>();

        public string CompantyName { get; set; }
    }
}
