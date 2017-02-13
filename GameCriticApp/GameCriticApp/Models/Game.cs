using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameCriticApp.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public virtual ICollection<GameReview> Reviews { get; set; }
    }
}