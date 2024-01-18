using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Games.ViewModel;
using Microsoft.EntityFrameworkCore;
using Web.FunnyBunnyGames.Data;

namespace FunnyBunnyGames.Services.Ratings
{
    public class RatingService:IRatingService
    {
        private readonly ApplicationDbContext context;
        public RatingService(ApplicationDbContext dbContext) { this.context = dbContext; }

        public async Task<double> AvegareRatingAsync(Guid id)
        {
            var models = await this.context.Ratings.Where(x=>x.GameId==id)
                .Select(s => new RatingsViewModel()
                {
                    Value = s.Value,
                })
                .ToListAsync();

            double avg = 0;
            foreach (var model in models)
            {
                avg += model.Value;
            }

            return avg/models.Count;
        }

        public async Task UpdateRatingAsync(RatingsViewModel request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var entities = await context.Ratings
                .Where(x => x.UserId == request.UserId && x.GameId == request.GameId)
                .ToListAsync();

            context.Ratings.RemoveRange(entities);

            var rating = new Rating()
            {
                GameId = request.GameId,
                Value = request.Value,
                UserId = request.UserId,
            };

            await context.AddAsync(rating);

            await context.SaveChangesAsync();


        }
    }
}
