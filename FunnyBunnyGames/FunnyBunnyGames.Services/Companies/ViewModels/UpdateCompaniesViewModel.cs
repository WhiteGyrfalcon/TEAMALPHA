using FunnyBunnyGames.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Services.Companies.ViewModels
{
    public class UpdateCompaniesViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
