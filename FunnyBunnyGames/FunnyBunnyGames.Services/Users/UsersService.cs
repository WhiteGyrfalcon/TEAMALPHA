using FunnyBunnyGames.Data.Models;
using Microsoft.EntityFrameworkCore;
using Web.FunnyBunnyGames.Data;
using FunnyBunnyGames.Services.Users.ViewModels;

namespace FunnyBunnyGames.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext dbContext;

        public UsersService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task DeleteUserAsync(Guid id)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                dbContext.Users.Remove(user);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<User> GetUserAsync(Guid id)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<AllUsersViewModel>> ListUsersAsync()
        {
            var model = await dbContext.Users.Select(a => new AllUsersViewModel()
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                UserName = a.UserName,
                Age = a.Age,
            }).ToListAsync();

            return model;
        }

        public async Task UpdateUserAsync(UpdateUserViewModel viewModel)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == viewModel.Id);
            
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                user.FirstName = viewModel.FirstName;
                user.LastName = viewModel.LastName;
                user.UserName = viewModel.UserName;
                user.Age = viewModel.Age;
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
