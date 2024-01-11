using FunnyBunnyGames.Services.Favourites.ViewModels;

namespace FunnyBunnyGames.Services.Favourites
{
    public interface IFavouriteService
    {
        Task<List<AllFavouritesViewModel>> AllFavouritesByUserAsync(Guid userId);

        Task DeleteFavouriteAsync(Guid gameId, Guid userId);
    }
}
