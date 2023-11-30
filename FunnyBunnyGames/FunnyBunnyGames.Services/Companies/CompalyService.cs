using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Companies.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.FunnyBunnyGames.Data;

namespace FunnyBunnyGames.Services.Companies
{
    internal class CompalyService : ICompanyService
    {
        private readonly ApplicationDbContext context;

        public CompalyService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CreateCompanyAsync(CreateCompaniesViewModel request)
        {
            var company = new Company()
            {
                Name = request.Name,
                Games = request.Games
            };

            await this.context.Companies.AddAsync(company);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteCompanyAsync(Guid id)
        {
            var model = await this.context.Companies
                .FirstOrDefaultAsync(x => x.Id == id);
            if (model != null)
            {
                context.Companies.Remove(model);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        
        }

        public async Task<DetailsCompaniesViewModel> GetCompanyAsync(Guid id)
        {
            var model = await this.context.Companies
               .FirstOrDefaultAsync(x => x.Id == id);
            if (model != null)
            {
                var company = new DetailsCompaniesViewModel()
                {
                    Name = model.Name,
                    Games = model.Games
                };
                return company;
            }
            else
            {
                throw new ArgumentNullException();
            }

        }

        public async Task<List<AllCompaniesViewModel>> ListCompaniyAsync()
        {
            var model = await this.context.Companies
                .Select(a => new AllCompaniesViewModel()
                {
                    Name=a.Name
                })
                .ToListAsync(); 
            return model;
        }

        public async Task UpdateCompanyAsync(Guid id, UpdateCompaniesViewModel request)
        {
            var model = await this.context.Companies
                .FindAsync();

            if (model != null)
            {
                model.Name = model.Name;
                model.Games = model.Games;

                await this.context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
