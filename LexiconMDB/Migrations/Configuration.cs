namespace LexiconMDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LexiconMDB.DAL;
    using LexiconMDB.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LexiconMDB.DAL.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieDBContext context)
        {
            context.Movies.AddOrUpdate(
                m => m.Title,
                new Movie {
                    Title = "Return of the killing Tomatoes",
                    Genre = Genre.Horror,
                    AgeLimit = 15,
                    Length = 90,
                    MetaScore = 7
                },
                new Movie {
                    Title = "Programmers Academy XII",
                    Genre = Genre.Comedy,
                    AgeLimit = 12,
                    Length = 110,
                    MetaScore = 16
                },
                new Movie {
                    Title = "Finalizer 7",
                    Genre = Genre.Action,
                    AgeLimit = 15,
                    Length = 95,
                    MetaScore = 57
                },
                new Movie {
                    Title = "The Lord of the Earrings",
                    Genre = Genre.Drama,
                    AgeLimit = 11,
                    Length = 205,
                    MetaScore = 91
                });

            
        }
    }
}
