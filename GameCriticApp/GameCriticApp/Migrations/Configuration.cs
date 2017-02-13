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
                    new Genre { Id = 1, Name = "Shooter" },
                    new Genre { Id = 2,Name = "Strategy" },
                    new Genre { Id = 3, Name = "Role PLaying Game"},
                    new Genre { Id = 4, Name = "Massive Multiplayer Online"}
                );

            context.Games.AddOrUpdate(g => g.Name,
                    new Game
                    {
                        Id = 1,
                        Name = "Overwatch",
                        Company = "Blizzard",
                        Description = "6v6 team shooter",
                        GenreId = 1
                    },
                    new Game
                    {
                        Id = 2,
                        Name = "Civilization VI",
                        Company = "2K",
                        Description = "Build an empire to stand the test of Time",
                        GenreId = 2,
                        Reviews = new List<GameReview> { new GameReview {
                            Rating = 10, Body = "Best initial release of the series" }
                        }
                    }
                );
        }
    }
}
