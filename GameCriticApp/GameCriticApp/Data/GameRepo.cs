using GameCriticApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameCriticApp.Data
{
    public class GameRepo
    {
        private static List<GameModels> _games;

        private static GameRepo _instance;

        public static List<GameModels> Games
        {
            get
            {
                if (_games == null)
                {
                    _games = new List<GameModels>();
                    _games.Add(new GameModels
                    {
                        Id = 1,
                        Name = "Over Watch",
                        Rating = 10,
                        Description = "Fun FPS game, with unique characrer interations."
                    });
                }
                return _games;
            }
        }

        public static GameRepo Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new GameRepo();
                }
                return _instance;
            }
        }

        public static void AddGame(GameModels game)
        {
            _games.Add(game);
        }
    }
}