using GameCriticApp.Data;
using GameCriticApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameCriticApp.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Index()
        {
            return View("GameIndexView", GameRepo.Games);
        }

        public ActionResult Details(int Id)
        {
            var game = GameRepo.Games.First(g => g.Id == Id);
            return View("GameDetailsView", game);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("GameCreateView");
        }

        [HttpPost]
        public ActionResult Create(GameModels game)
        {
            if(ModelState.IsValid)
            {
                var newGame = new GameModels();
                newGame.Id = GameRepo.Games.Max(g => g.Id) +1;
                newGame.Name = game.Name;
                newGame.Rating = game.Rating;
                newGame.Description = game.Description;

                GameRepo.AddGame(newGame);
                return RedirectToAction("Details", new { Id = newGame.Id });
            }
            
            return View(game);
        }
    }

    
}