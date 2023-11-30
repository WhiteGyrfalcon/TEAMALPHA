using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Companies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Services.Companies
{
    internal interface ICompanyService
    {
        Task<List<AllCompaniesViewModel>> ListCompaniyAsync();

        Task<DetailsCompaniesViewModel> GetCompanyAsync(Guid id);

        Task CreateCompanyAsync(CreateCompaniesViewModel request);//add

        Task UpdateCompanyAsync(Guid id, UpdateCompaniesViewModel request);//update

        Task DeleteCompanyAsync(Guid id);//delete
    }
}
