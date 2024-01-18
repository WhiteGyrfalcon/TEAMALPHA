using FunnyBunnyGames.Services.Companies.ViewModels;

namespace FunnyBunnyGames.Services.Companies
{
    public interface ICompanyService
    {
        Task<List<AllCompaniesViewModel>> ListCompaniyAsync();

        Task<DetailsCompaniesViewModel> GetCompanyAsync(Guid id);

        Task CreateCompanyAsync(CreateCompaniesViewModel request);

        Task UpdateCompanyAsync(Guid id, UpdateCompaniesViewModel request);

        Task DeleteCompanyAsync(Guid id);
    }
}
