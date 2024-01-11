using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
