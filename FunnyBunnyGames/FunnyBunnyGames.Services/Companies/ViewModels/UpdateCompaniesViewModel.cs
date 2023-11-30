using FunnyBunnyGames.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Services.Companies.ViewModels
{
    internal class UpdateCompaniesViewModel
    {
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
