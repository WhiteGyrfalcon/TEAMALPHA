using FunnyBunnyGames.Services.Comments;
using FunnyBunnyGames.Services.Comments.ViewModels;
using FunnyBunnyGames.Services.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Web.FunnyBunnyGames.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            this._commentService = commentService;
        }

        public async Task<IActionResult> All(
            [FromRoute]
            Guid gameId)
        {
            var model = await _commentService.ListCommentsAsync(gameId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new AddCommentViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddCommentViewModel model,
            [FromRoute]
            Guid gameId)
        {
            await _commentService.CreateCommentAsync(model, ClaimPrincipalExtension.GetUserId(User), gameId);

            return RedirectToAction("Get", "Game");
        }

        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid commentId)
        {
            await _commentService.DeleteCommentAsync(commentId);

            return RedirectToAction("List", "Game");
        }
    }
}
