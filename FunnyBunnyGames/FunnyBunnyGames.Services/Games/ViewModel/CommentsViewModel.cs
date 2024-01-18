using FunnyBunnyGames.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Services.Games.ViewModel
{
    public class CommentsViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid GameId { get; set; }
        public string Value { get; set; } = null!;
        public User? User { get; set; } 
        public Game? Game { get; set; }
    }
}
