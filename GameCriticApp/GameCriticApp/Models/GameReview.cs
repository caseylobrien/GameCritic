using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameCriticApp.Models
{
    public class GameReview
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int GameId { get; set; }
        public int Rating { get; set; }
    }
}