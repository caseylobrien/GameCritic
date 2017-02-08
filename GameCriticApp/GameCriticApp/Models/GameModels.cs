using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameCriticApp.Models
{
    public class GameModels
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public GenreModels Genre { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }
    }
}