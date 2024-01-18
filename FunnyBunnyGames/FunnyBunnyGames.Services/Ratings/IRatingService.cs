using FunnyBunnyGames.Services.Games.ViewModel;

namespace FunnyBunnyGames.Services.Ratings
{
    public interface IRatingService
    {
        Task UpdateRatingAsync(RatingsViewModel request);

        Task<double> AvegareRatingAsync(Guid id);
    }
}
