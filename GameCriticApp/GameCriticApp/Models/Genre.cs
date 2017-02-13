using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameCriticApp.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}