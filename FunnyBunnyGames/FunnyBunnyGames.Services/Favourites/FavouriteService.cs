using FunnyBunnyGames.Services.Favourites.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.FunnyBunnyGames.Data;

namespace FunnyBunnyGames.Services.Favourites
{
    public class FavouriteService : IFavouriteService
    {
        private readonly ApplicationDbContext _dbContext;

        public FavouriteService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<AllFavouritesViewModel>> AllFavouritesByUserAsync(Guid userId)
        {
            var model = await _dbContext.Favourites
                .Include(x => x.Game)
                .Include(x => x.User)
                .Where(x => x.UserId == userId)
                .Select(x => new AllFavouritesViewModel()
                {
                    Id = x.Id,
                    GameId = x.GameId,
                    UserId = userId,
                    GameImage = x.Game.ImageUrl,
                    GameName = x.Game.Name
                })
                .ToListAsync();

            return model;
        }

        public async Task DeleteFavouriteAsync(Guid gameId, Guid userId)
        {
            var model = await _dbContext.Favourites
                .FirstOrDefaultAsync(x => x.UserId == userId && x.GameId == gameId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            _dbContext.Favourites.Remove(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}
