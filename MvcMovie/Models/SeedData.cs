using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R",
                    Studio = "Columbia Pictures"
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG",
                    Studio = "Columbia Pictures"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG",
                    Studio = "Sony Pictures"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "NR",
                    Studio = "Warner Bros."
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-3-24"),
                    Genre = "Crime",
                    Price = 9.99M,
                    Rating = "R",
                    Studio = "Paramount Pictures"
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Price = 10.99M,
                    Rating = "PG-13",
                    Studio = "Warner Bros."
                }
            );
            context.SaveChanges();
        }
    }
}