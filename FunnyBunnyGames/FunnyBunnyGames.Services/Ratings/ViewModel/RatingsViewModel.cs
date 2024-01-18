using FunnyBunnyGames.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Services.Ratings.ViewModel
{
    internal class RatingsViewModel
    {
        public Guid UserId { get; set; }
        public Guid GameId { get; set; }
        public double Value { get; set; }

    }
}
