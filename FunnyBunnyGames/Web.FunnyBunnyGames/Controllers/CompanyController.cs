using FunnyBunnyGames.Services.Companies;
using FunnyBunnyGames.Services.Companies.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.FunnyBunnyGames.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            this._companyService = companyService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> All()
        {
            var model = await _companyService.ListCompaniyAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Get(
            [FromRoute]  
            Guid id)
        {
            var model = await _companyService.GetCompanyAsync(id);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
          await _companyService.DeleteCompanyAsync(id);
          return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult>Update(
            [FromRoute]
            Guid id)
        {
            var model = await _companyService.GetCompanyAsync(id);
            var company=new UpdateCompaniesViewModel() 
            { 
                Id=model.Id,
                Name=model.Name,
                Games=model.Games,
            };
            return View(company);
        }

        [HttpPost]
        public async Task<IActionResult>Update(UpdateCompaniesViewModel model)
        {
            await _companyService.UpdateCompanyAsync(model.Id, model);

            return RedirectToAction("All");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCompaniesViewModel model)
        {
            var comp = new CreateCompaniesViewModel()
            {
                Name = model.Name,
                Games = model.Games
            };

            await _companyService.CreateCompanyAsync(comp);
            return RedirectToAction("All");
        }
    }
}
