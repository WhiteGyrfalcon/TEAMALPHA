using FunnyBunnyGames.Data.Models;
using FunnyBunnyGames.Services.Games.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Services.Games
{
    public interface IGameService
    {
        Task<List<AllGamesViewModel>> ListGamesAsync();

        Task<Game> GetGameAsync(Guid id);

        Task CreateGameAsync(CreateGameViewModel request);

        Task UpdateGameAsync(Guid id, UpdateGameViewModel request);

        Task DeleteGameAsync(Guid id);


    }
}
