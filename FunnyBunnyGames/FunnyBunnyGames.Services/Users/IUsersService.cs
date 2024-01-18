using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Users.ViewModels;

namespace FunnyBunnyGames.Services.Users
{
    public interface IUsersService
    {
        Task<List<AllUsersViewModel>> ListUsersAsync();
        Task<User> GetUserAsync(Guid id);
        Task UpdateUserAsync(UpdateUserViewModel viewModel);
        Task DeleteUserAsync(Guid id);
    }
}
