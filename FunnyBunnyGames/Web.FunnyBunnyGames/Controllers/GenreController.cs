using FunnyBunnyGames.Services.Companies.ViewModels;
using FunnyBunnyGames.Services.Genres;
using FunnyBunnyGames.Services.Genres.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.FunnyBunnyGames.Controllers
{
    [Authorize]
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            this._genreService = genreService;
        }

        public async Task<IActionResult> All()
        {
            var model = await _genreService.ListGenresAsync();

            return View(model);
        }

        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
            await _genreService.DeleteGenreAsync(id);

            return RedirectToAction("All", "Genre");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(GenresViewModel model)
        {
            await _genreService.CreateGenreAsync(model);
            return RedirectToAction("All", "Genre");
        }
    }
}
