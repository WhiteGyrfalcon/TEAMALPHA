using FunnyBunnyGames.Services.Comments.ViewModels;

namespace FunnyBunnyGames.Services.Comments
{
    public interface ICommentService
    {
        Task<List<CommentViewModel>> ListCommentsAsync(Guid gameId);

        Task CreateCommentAsync(AddCommentViewModel model, Guid userId, Guid gameId);

        Task DeleteCommentAsync(Guid commentId);
    }
}
