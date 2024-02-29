using FunnyBunnyGames.Services.Favourites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.FunnyBunnyGames.Infrastructure;

namespace Web.FunnyBunnyGames.Controllers
{
    [Authorize]
    public class FavouriteController : Controller
    {
        private readonly IFavouriteService _favouriteService;

        public FavouriteController(IFavouriteService favouriteService)
        {
            this._favouriteService = favouriteService;
        }

        public async Task<IActionResult> AllByUser()
        {
            var model = await _favouriteService.AllFavouritesByUserAsync(ClaimPrincipalExtension.GetUserId(User));

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
            await _favouriteService.DeleteFavouriteAsync(id, ClaimPrincipalExtension.GetUserId(User));

            return RedirectToAction("AllByUser");
        }
    }
}
