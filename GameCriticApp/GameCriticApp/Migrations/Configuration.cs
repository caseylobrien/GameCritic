namespace GameCriticApp.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameCriticApp.Models.GameCriticDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "GameCriticApp.Models.GameCriticDb";
        }

        protected override void Seed(GameCriticApp.Models.GameCriticDb context)
        {
            context.Genres.AddOrUpdate(g => g.Name,
                    new Genre { Name = "Shooter"},
                    new Genre { Name = "Strategy"},
                    new Genre { Name = "Role PLaying Game"},
                    new Genre { Name = "Massive Multiplayer Online"}
                );

            context.Games.AddOrUpdate(g => g.Name,
                    new Game
                    {
                        Name = "Overwatch",
                        Company = "Blizzard",
                        Description = "6v6 team shooter",
                        Genre = context.Genres.Find(1)
                    },
                    new Game
                    {
                        Name = "Civilization VI",
                        Company = "2K",
                        Description = "Build an empire to stand the test of Time",
                        Genre = context.Genres.Find(2),
                        Reviews = new List<GameReview> { new GameReview {
                            Rating = 10, Body = "Best initial release of the series" }
                        }
                    }
                );
        }
    }
}
