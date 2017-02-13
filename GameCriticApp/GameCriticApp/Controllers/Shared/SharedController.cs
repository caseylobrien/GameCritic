using GameCriticApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameCriticApp.Controllers.Shared
{
    public class SharedController : Controller
    {
        private GameCriticDb _db = new GameCriticDb();

        [ChildActionOnly]
        public ActionResult GenreDropDownList()
        {
            var models = new GenreViewModel();
            var selectItems = new List<SelectListItem>();
            _db.Genres.ToList().ForEach(g => selectItems.Add(new SelectListItem { Value = g.Id.ToString(), Text = g.Name }));
            models.SelectedOptions = selectItems.ToArray();

            return View(models);
        }
    }
}