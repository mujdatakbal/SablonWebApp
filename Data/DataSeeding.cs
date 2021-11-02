using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SablonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SablonWebApp.Data
{
    public class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();
            context.Database.Migrate();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Movies.Count()==0)
                {
                    context.Movies.AddRange(
                    new List<Movie>()
                    {
                        new Movie() {Title = "m 1", Description = "D m1", ImageUrl = "1.jpg", GenreId= 1},
                        new Movie() {Title = "m 2", Description = "D m2", ImageUrl = "2.jpg", GenreId= 1},
                        new Movie() {Title = "m 3", Description = "D m3", ImageUrl = "3.jpg", GenreId= 1},
                        new Movie() {Title = "m 4", Description = "D m4", ImageUrl = "4.jpg", GenreId= 2},
                        new Movie() {Title = "m 5", Description = "D m5", ImageUrl = "5.jpg", GenreId= 2},
                        new Movie() {Title = "m 6", Description = "D m6", ImageUrl = "6.jpg", GenreId= 2},
                        new Movie() {Title = "m 7", Description = "D m7", ImageUrl = "7.jpg", GenreId= 3},
                        new Movie() {Title = "m 8", Description = "D m8", ImageUrl = "8.jpg", GenreId= 3},
                        new Movie() {Title = "m 9", Description = "D m9", ImageUrl = "9.jpg", GenreId= 3}
                    }); ;
                }
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(new List<Genre>() { new Genre() { Name = "G1" } });
                    context.Genres.AddRange(new List<Genre>() { new Genre() { Name = "G2" } });
                    context.Genres.AddRange(new List<Genre>() { new Genre() { Name = "G3" } });
                    context.Genres.AddRange(new List<Genre>() { new Genre() { Name = "G4" } });
                    context.Genres.AddRange(new List<Genre>() { new Genre() { Name = "G5" } });
                }
                context.SaveChanges();
            }

        }
    }
}
