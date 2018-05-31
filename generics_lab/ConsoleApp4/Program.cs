using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance
            var movies = new List<Movie>();

            // add method
            var inceptionMovie = new Movie {
                Title = "Inception",
                ReleasedYear = 2010,
                OscarWon = 4
            };

            movies.Add(inceptionMovie);

            movies.Add(new Movie {
                Title = "The Matrix",
                ReleasedYear = 1999,
                OscarWon = 4
            });

            movies.Add(new Movie {
                Title = "The Wolf of Wall Street",
                ReleasedYear = 2010,
                OscarWon = 0
            });

            PrintAll(movies);

            // count
            Console.WriteLine(movies.Count);

            // get by index
            movies[1].PrintInfo();

            // contains => true
            Console.WriteLine(movies.Contains(inceptionMovie));

            // filter by title
            var filter = movies
                .Where(m => m.Title == "Inception")
                .FirstOrDefault();

            filter.PrintInfo();

            // sort by year
            var sorted = movies
                .OrderBy(m => m.ReleasedYear)
                .ToList();

            PrintAll(sorted);

            // oscar won sum
            var oscars = movies
                .Sum(m => m.OscarWon);

            Console.WriteLine($"Oscars sum: {oscars}");

            // group by year
            var groups = movies
                .GroupBy(g => g.ReleasedYear)
                .Select(s => new {
                     Year = s.Key,
                     Sum = s.Sum(x => x.OscarWon)
                 })
                 .ToList();

            foreach (var g in groups) {
                Console.WriteLine($"Year: {g.Year}, Oscars: {g.Sum}");
            }

            // remove
            movies.Remove(inceptionMovie);

            PrintAll(sorted);
            Console.WriteLine(movies.Count);

            Console.ReadLine();
        }

        public static void PrintAll(List<Movie> movies)
        {
            foreach (var movie in movies) {
                movie.PrintInfo();
            }
        }

        public class Movie
        {
            public int ReleasedYear { get; set; }

            public string Title { get; set; }

            public int OscarWon { get; set; }

            public void PrintInfo()
            {
                Console.WriteLine($"Title: {Title}, Released Year: {ReleasedYear}");
            }
        }
    }
}
