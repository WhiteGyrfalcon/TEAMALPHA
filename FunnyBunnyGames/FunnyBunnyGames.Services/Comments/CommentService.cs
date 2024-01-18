using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Comments.ViewModels;
using Microsoft.EntityFrameworkCore;
using Web.FunnyBunnyGames.Data;

namespace FunnyBunnyGames.Services.Comments
{
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext _dbContext;

        public CommentService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task CreateCommentAsync(AddCommentViewModel model, Guid userId, Guid gameId)
        {
            var comment = new Comment()
            {
                Id = Guid.NewGuid(),
                Value = model.Value,
                UserId = userId,
                GameId = gameId
            };

            await _dbContext.Comments.AddAsync(comment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCommentAsync(Guid commentId)
        {
            var model = await _dbContext.Comments
                .FindAsync(commentId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            _dbContext.Comments.Remove(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<CommentViewModel>> ListCommentsAsync(Guid gameId)
        {
            var model = await _dbContext.Comments
                .Where(g => g.Id == gameId)
                .Select(x => new CommentViewModel()
                {
                    Value = x.Value
                }).ToListAsync();

            return model;
        }
    }
}
