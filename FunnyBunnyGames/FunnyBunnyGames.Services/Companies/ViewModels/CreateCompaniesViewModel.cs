using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunnyBunnyGames.Data.Models;


namespace FunnyBunnyGames.Services.Companies.ViewModels
{
    public class CreateCompaniesViewModel
    {
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
