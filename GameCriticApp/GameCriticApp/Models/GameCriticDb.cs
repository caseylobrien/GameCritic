using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameCriticApp.Models
{
    public class GameCriticDb : DbContext
    {
        public GameCriticDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameReview> Reviews { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}