using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Companies.ViewModels;
using Microsoft.EntityFrameworkCore;
using Web.FunnyBunnyGames.Data;

namespace FunnyBunnyGames.Services.Companies
{
    public class CompalyService : ICompanyService
    {
        private readonly ApplicationDbContext _context;

        public CompalyService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task CreateCompanyAsync(CreateCompaniesViewModel request)
        {
            var company = new Company()
            {
                Name = request.Name,
                Games = request.Games
            };

            await this._context.Companies.AddAsync(company);
            await this._context.SaveChangesAsync();
        }

        public async Task DeleteCompanyAsync(Guid id)
        {
            var model = await this._context.Companies
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model != null)
            {
                _context.Companies.Remove(model);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task<DetailsCompaniesViewModel> GetCompanyAsync(Guid id)
        {
            var model = await this._context.Companies
                .Include(x=>x.Games)
               .FirstOrDefaultAsync(x => x.Id == id);

            if (model != null)
            {
                var company = new DetailsCompaniesViewModel()
                {
                    Id = model.Id,
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
            var model = await this._context.Companies
                .Select(a => new AllCompaniesViewModel()
                {
                    Id=a.Id,
                    Name = a.Name
                })
                .ToListAsync();

            return model;
        }

        public async Task UpdateCompanyAsync(Guid id, UpdateCompaniesViewModel request)
        {
            var model = await this._context.Companies
                .FindAsync(id);

            if (model != null)
            {
                model.Id = request.Id;
                model.Name = request.Name;
                model.Games = request.Games;

                await this._context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
