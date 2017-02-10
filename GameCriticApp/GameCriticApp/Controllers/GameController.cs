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
        private GameCriticDb _db = new GameCriticDb();

        public ActionResult Index()
        {
            var models = _db.Games.ToList().OrderBy(g => g.Name);
            return View("GameIndexView", models);
        }

        public ActionResult Details(int Id)
        {
            var game = _db.Games.Find(Id);
            return View("GameDetailsView", game);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("GameCreateView");
        }

        [HttpPost]
        public ActionResult Create(Game game)
        {
            if(ModelState.IsValid)
            {
                var newGame = new Game();
                newGame.Id = _db.Games.Max(g => g.Id) +1;
                newGame.Name = game.Name;
                newGame.Description = game.Description;

                _db.Games.Add(newGame);
                _db.SaveChanges();
                return RedirectToAction("Details", new { Id = newGame.Id });
            }
            
            return View(game);
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    
}