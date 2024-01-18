﻿using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Games;
using FunnyBunnyGames.Services.Games.ViewModel;
using FunnyBunnyGames.Services.Genres;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.FunnyBunnyGames.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IGenreService _genreService;

        public GameController(IGameService gameService, IGenreService genreService)
        {
            this._gameService = gameService;
            this._genreService = genreService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await _gameService.ListGamesAsync();

            return View(model);
        }
       
        //Get
        [HttpGet]
        public async Task<IActionResult> Update([FromRoute] Guid id)
        {
            var model = await _gameService.GetGameAsync(id);
            var game = new UpdateGameViewModel()
            {
                GenreId = id,
                CompanyId = id,
                Name = model.Name,
                Description = model.Description,
                ReleaseDate = model.ReleaseDate,
                Price = model.Price,
                AgeRestriction = model.AgeRestriction,
                ImageUrl = model.ImageUrl,
                Genres = await _genreService.ListGenresAsync()
            };

            return View(game);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Guid id, UpdateGameViewModel request)
        {
            await _gameService.UpdateGameAsync(id, request);

            return RedirectToAction("Get", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var game = new CreateGameViewModel()
            {
                Genres = await _genreService.ListGenresAsync(),
                //TODO: Companies 
            };

            return View(game);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateGameViewModel model)
        {
            var game = new CreateGameViewModel()
            {
                GenreId = model.GenreId,
                CompanyId = model.CompanyId,
                Name = model.Name,
                Description = model.Description,
                ReleaseDate = model.ReleaseDate,
                Price = model.Price,
                AgeRestriction = model.AgeRestriction,
                ImageUrl = model.ImageUrl,
            };

            await _gameService.CreateGameAsync(game);

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await _gameService.DeleteGameAsync(id);

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var model = await _gameService.GetGameAsync(id);

            return View(model);
        }

    }
}
