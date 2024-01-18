using FunnyBunnyGames.Services.Genres.ViewModel;

namespace FunnyBunnyGames.Services.Genres
{
    public interface IGenreService
    {
        Task<List<GenresViewModel>> ListGenresAsync();//

        Task<GenresViewModel> GetGenreAsync(Guid id);//

        Task CreateGenreAsync(GenresViewModel request);//


        Task DeleteGenreAsync(Guid id);//
    }
}
