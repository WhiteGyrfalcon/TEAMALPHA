using FunnyBunnyGames.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunnyBunnyGames.Services.Genres.ViewModel;

namespace FunnyBunnyGames.Services.Games.ViewModel
{
    public class AllGamesViewModel
    {
        public Guid Id { get; set; }
        public Guid GenreId { get; set; }
        public string Name { get; set; } = null!;

        public DateTime? ReleaseDate { get; set; }
        public double Price { get; set; }
        public int AgeRestriction { get; set; }
        public string ImageUrl { get; set; } = null!;
        public GenresViewModel Genre { get; set; }
        public string GenreName { get; set; }
    }
}
