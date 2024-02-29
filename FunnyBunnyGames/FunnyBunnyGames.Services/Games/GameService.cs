using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Companies;
using FunnyBunnyGames.Services.Games.ViewModel;
using FunnyBunnyGames.Services.Genres;
using FunnyBunnyGames.Services.Ratings;
using Microsoft.EntityFrameworkCore;
using Web.FunnyBunnyGames.Data;

namespace FunnyBunnyGames.Services.Games
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext context;
        private readonly IGenreService genreService;
        private readonly IRatingService ratingService;
        private readonly ICompanyService companyService;

        public GameService(ApplicationDbContext dbContext, IGenreService genreService, IRatingService ratingService, ICompanyService companyService)
        {
            this.context = dbContext;
            this.genreService = genreService;
            this.ratingService = ratingService;
            this.companyService = companyService;
        }

        public async Task CreateGameAsync(CreateGameViewModel request)
        {
            var genre = await genreService.GetGenreAsync(request.GenreId);

            var entityGenre = new Genre()
            {
                Id = genre.Id,
                Name = genre.Name
            };

            Game game = new Game()
            {
                Id = Guid.NewGuid(),
                GenreId = request.GenreId,
                CompanyId = request.CompanyId,
                Name = request.Name,
                Description = request.Description,
                ReleaseDate = request.ReleaseDate,
                Price = request.Price,
                AgeRestriction = request.AgeRestriction,
                ImageUrl = request.ImageUrl,
            };

            await context.AddAsync(game);
            await context.SaveChangesAsync();
        }

        public async Task DeleteGameAsync(Guid id)
        {
            Game? game = await this.context.Games.FirstOrDefaultAsync(x => x.Id == id);

            if (game != null)
            {
                this.context.Games.Remove(game);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task<Game> GetGameAsync(Guid id)
        {
            var model = await this.context.Games.FirstOrDefaultAsync(x => x.Id == id);

            var game = new GetGameViewModel()
            {
                Id = model.Id,
                GenreId = model.GenreId,
                CompanyId = model.CompanyId,
                Name = model.Name,
                Description = model.Description,
                ReleaseDate = model.ReleaseDate,
                Price = model.Price,
                AgeRestriction = model.AgeRestriction,
                ImageUrl = model.ImageUrl,
                Genres = await genreService.ListGenresAsync(),
                AverageRating = await ratingService.AvegareRatingAsync(id),

                // TODO: CompanyName = ..., comments, favourites
            };
            return model;
        }

        public async Task<List<AllGamesViewModel>> ListGamesAsync()
        {
            var entityGames = await this.context.Games
                .Include(x=>x.Genre)
                .Include(x=>x.Company)
                .ToListAsync();

            var models = new List<AllGamesViewModel>();

            foreach (var game in entityGames)
            {
                models.Add(new AllGamesViewModel()
                {
                    Id = game.Id,
                    GenreId = game.GenreId,
                    Name = game.Name,
                    ReleaseDate = game.ReleaseDate,
                    Price = game.Price,
                    AgeRestriction = game.AgeRestriction,
                    ImageUrl = game.ImageUrl,
                    Genre = await genreService.GetGenreAsync(game.GenreId),
                    Company = await companyService.GetCompanyAsync(game.CompanyId)
                });
            }

            return models;
        }

        public async Task UpdateGameAsync(Guid id, UpdateGameViewModel request)
        {
            var model = await this.context.Games.FirstOrDefaultAsync(x => x.Id == id);

            if (model != null)
            {
                model.GenreId = request.GenreId;
                model.CompanyId = request.CompanyId;
                model.Name = request.Name;
                model.Description = request.Description;
                model.ReleaseDate = request.ReleaseDate;
                model.Price = request.Price;
                model.AgeRestriction = request.AgeRestriction;
                model.ImageUrl = request.ImageUrl;
            }

            await context.SaveChangesAsync();
        }
    }
}
