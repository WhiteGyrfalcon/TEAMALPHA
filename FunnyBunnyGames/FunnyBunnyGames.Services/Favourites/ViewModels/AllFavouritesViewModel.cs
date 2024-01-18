namespace FunnyBunnyGames.Services.Favourites.ViewModels
{
    public class AllFavouritesViewModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid GameId { get; set; }

        public string GameName { get; set; }

        public string GameImage { get; set; }
    }
}
