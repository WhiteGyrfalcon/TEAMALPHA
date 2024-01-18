using FunnyBunnyGames.Services.Genres.ViewModel;

namespace FunnyBunnyGames.Services.Games.ViewModel
{
    public class GetGameViewModel
    {
        public Guid Id { get; set; }
        public Guid GenreId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? ReleaseDate { get; set; }
        public double Price { get; set; }
        public int AgeRestriction { get; set; }
        public string ImageUrl { get; set; } = null!;

        public double AverageRating { get; set; }

        public ICollection<GenresViewModel> Genres { get; set; } = new List<GenresViewModel>();
        public string CompantyName { get; set; }

        public ICollection<RatingsViewModel> Ratings { get; set; } = new List<RatingsViewModel>();

        public ICollection<FavouritesViewModel> Favourites { get; set; } = new List<FavouritesViewModel>();

        public ICollection<CommentsViewModel> Comments { get; set; } = new List<CommentsViewModel>();

    }
}
