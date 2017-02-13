using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameCriticApp.Models
{
    public class GenreViewModel
    {
        public string SelectedGenre { get; set; }
        public IEnumerable<SelectListItem> SelectedOptions { get; set; }
    }
}