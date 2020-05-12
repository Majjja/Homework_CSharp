using ListOfMovies.Entities;
using ListOfMovies.Helpers;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ListOfMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = MoviesHelper.GetAllKindOfMovies();

            //1.    Find all movies that their titles starts with "L"
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Movies that their titles starts with \"L\"");
            Console.ResetColor();

            //Lambda syntax
            var moviesTitlesStartsWithL = movies
                                            .Where(movie => movie.Title.StartsWith('L'))
                                            .ToList();
            moviesTitlesStartsWithL.ForEach(movie => Console.WriteLine(movie.Title));

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var moviesTitlesStartsWithL2 = (from movie in movies
                                            where movie.Title.StartsWith('L')
                                            select movie)
                                           .ToList();
            moviesTitlesStartsWithL2.ForEach(movie => Console.WriteLine(movie.Title));

            Console.WriteLine("------------------------------------------");


            //2.    Find the NUMBER of movies that have rating higher than 7.5
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NUMBER of movies that have rating higher than 7.5");
            Console.ResetColor();

            //Lambda syntax
            var moviesWithHigherRating = movies
                                            .Where(movie => movie.Rating > 7.5)
                                            .ToList()
                                            .Count();
            Console.WriteLine(moviesWithHigherRating);

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var moviesWithHigherRating2 = (from movie in movies
                                           where movie.Rating > 7.5
                                           select movie)
                                          .ToList()
                                          .Count();
            Console.WriteLine(moviesWithHigherRating2);
            Console.WriteLine("------------------------------------------");

            //3.    Find all movies TITLES with year of production before 2005
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All movies TITLES with year of production before 2005");
            Console.ResetColor();

            //Lambda syntax
            //Query syntax
            var moviesProducedBefore2005 = movies
                                            .Where(movie => movie.Year < 2005)
                                            .Select(movie => movie.Title)
                                            .ToList();
            moviesProducedBefore2005.ForEach(title => Console.WriteLine(title));

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var moviesProducedBefore2005_2 = (from movie in movies
                                              where movie.Year < 2005
                                              select movie.Title)
                                             .ToList();
            moviesProducedBefore2005_2.ForEach(title => Console.WriteLine(title));
            Console.WriteLine("------------------------------------------");


            //4.    Find all movies TITLES and RATING that have rating higher then 8.0
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All movies TITLES and RATING that have rating higher then 8.0");
            Console.ResetColor();

            //Lambda syntax
            var titlesAndRatingsOfHighRatedMovies = movies
                                            .Where(movie => movie.Rating > 8.0)
                                            .Select(movie => new { movie.Title, movie.Rating })
                                            .ToList();
            titlesAndRatingsOfHighRatedMovies.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}"));

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var titlesAndRatingsOfHighRatedMovies2 = (from movie in movies
                                                      where movie.Rating > 8.0
                                                      select new { movie.Title, movie.Rating })
                                                     .ToList();
            titlesAndRatingsOfHighRatedMovies2.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}"));
            Console.WriteLine("------------------------------------------");

            //5.    Find first 5 movies that have duration time longer then 2 hours
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("First 5 movies that have duration time longer then 2 hours");
            Console.ResetColor();

            //Lambda syntax
            var moviesLongerThen2Hours = movies
                                            .Where(movie => movie.Duration > 120)
                                            .Take(5)
                                            .ToList();
            moviesLongerThen2Hours.ForEach(movie => Console.WriteLine(movie.Title));

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var moviesLongerThen2Hours2 = (from movie in movies
                                           where movie.Duration > 120
                                           select movie)
                                          .Take(5)
                                          .ToList();
            moviesLongerThen2Hours2.ForEach(movie => Console.WriteLine(movie.Title));
            Console.WriteLine("------------------------------------------");


            //6.    Find last 3 movies TITLES and DURATION that have duration less then 2 hours
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Last 3 movies TITLES and DURATION that have duration less then 2 hours");
            Console.ResetColor();

            //Lambda syntax
            var moviesDurationLessThen2Hours = movies
                                            .Where(movie => movie.Duration < 120)
                                            .Select(movie => new { movie.Title, movie.Duration })
                                            .TakeLast(3)
                                            .ToList();
            moviesDurationLessThen2Hours.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Duration {movie.Duration}"));

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var moviesDurationLessThen2Hours2 = (from movie in movies
                                                 where movie.Duration < 120
                                                 select new { movie.Title, movie.Duration })
                                                .TakeLast(3)
                                                 .ToList();
            moviesDurationLessThen2Hours2.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Duration {movie.Duration}"));
            Console.WriteLine("------------------------------------------");

            //7.    Find all movies TITLES and RATING and order them by DURATION(DESC) -no condition needed
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All movies TITLES and RATING and order them by DURATION(DESC)");
            Console.ResetColor();

            //Lambda syntax
            var allMoviesTitlesAndRatings = movies
                                            .OrderByDescending(movie => movie.Duration)
                                            .Select(movie => new { movie.Title, movie.Rating })
                                            .ToList();
            allMoviesTitlesAndRatings.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}"));

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var allMoviesTitlesAndRatings2 = (from movie in movies
                                              orderby movie.Duration descending
                                              select movie)
                                             .Select(movie => new { movie.Title, movie.Rating })
                                             .ToList();
            allMoviesTitlesAndRatings2.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}"));
            Console.WriteLine("------------------------------------------");

            //8.    Find all movies with TITLES that don't start with A and TITLES include more than 7 characters
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All movies with TITLES that don't start with A and TITLES include more than 7 characters");
            Console.ResetColor();

            //Lambda syntax
            var moviesTitlesWith7Char = movies
                                            .Where(movie => !movie.Title.StartsWith('A'))
                                            .Where(movie => movie.Title.Count() > 7)
                                            .Select(movie => movie.Title)
                                            .ToList();
            moviesTitlesWith7Char.ForEach(title => Console.WriteLine(title));

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var moviesTitlesWith7Char2 = (from movie in movies
                                          where !movie.Title.StartsWith('A') && movie.Title.Count() > 7
                                          select movie.Title)
                                         .ToList();
            moviesTitlesWith7Char2.ForEach(title => Console.WriteLine(title));
            Console.WriteLine("------------------------------------------");

            //9.    Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour
            //    and 50min
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour and 50min");
            Console.ResetColor();

            //Lambda syntax
            var moviesRatings = movies
                                    .Where(movie => movie.Rating > 7.2 && movie.Duration < 110)
                                    .Select(movie => movie.Rating)
                                    .ToList();
            moviesRatings.ForEach(rating => Console.WriteLine(rating));

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var moviesRatings2 = (from movie in movies
                                  where movie.Rating > 7.2 && movie.Duration < 110
                                  select movie.Rating)
                                 .ToList();
            moviesRatings2.ForEach(rating => Console.WriteLine(rating));
            Console.WriteLine("------------------------------------------");


            //10.    Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
            //    longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All movies TITLES and RATINGS that have TITLES with less than 10 characters, " +
                "DURATION longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)");
            Console.ResetColor();

            //Lambda syntax
            var moviesTitlesAndRatings = movies
                                    .Where(movie => movie.Title.Count() < 10)
                                    .Where(movie => movie.Duration > 120)
                                    .Where(movie => movie.Rating > 6.7)
                                    .OrderBy(movie => movie.Title)
                                    .Select(movie => new { movie.Title, movie.Rating })
                                    .ToList();
            moviesTitlesAndRatings.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}"));

            //Query syntax
            Console.WriteLine("------------------------------------------");
            var moviesTitlesAndRatings2 = (from movie in movies
                                           where movie.Title.Count() < 10
                                           where movie.Duration > 120
                                           where movie.Rating > 6.7
                                           orderby movie.Title
                                           select movie)
                                           .Select(movie => new { movie.Title, movie.Rating })
                                          .ToList();
            moviesTitlesAndRatings2.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}"));
            Console.WriteLine("------------------------------------------");

        }
    }
}
