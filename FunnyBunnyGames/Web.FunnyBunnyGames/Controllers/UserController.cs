using FunnyBunnyGames.Services.Infrastructure;
using FunnyBunnyGames.Services.Users;
using FunnyBunnyGames.Services.Users.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.FunnyBunnyGames.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUsersService _usersService;

        public UserController(IUsersService usersService)
        {
            this._usersService = usersService;
        }

        public async Task<IActionResult> All()
        {
            var model = await _usersService.ListUsersAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var model = await _usersService.GetUserAsync(ClaimPrincipalExtension.GetUserId(User));

            UpdateUserViewModel viewModel = new UpdateUserViewModel();
            viewModel.Age = model.Age;
            viewModel.Id = model.Id;
            viewModel.FirstName = model.FirstName;
            viewModel.LastName = model.LastName;
            viewModel.UserName = model.UserName;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateUserViewModel model,[FromRoute]Guid id)
        {
            await _usersService.UpdateUserAsync(model);
            return RedirectToAction("All");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _usersService.DeleteUserAsync(id);
            return RedirectToAction("All");
        }
    }
}
