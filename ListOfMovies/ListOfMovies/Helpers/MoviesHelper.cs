using System;
using System.Collections.Generic;
using System.Text;
using ListOfMovies.Entities;

namespace ListOfMovies.Helpers
{
    public class MoviesHelper
    {
        public static List<Movie> GetAllKindOfMovies()
            {
            return new List<Movie>()
                {
                    new Movie() {Title = "Peaceful Warrior", Year = 2006, Rating = 7.3f, Duration = 120},
                    new Movie() {Title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe", Year = 2005, Rating = 6.9f, Duration = 143},
                    new Movie() {Title = "Lucy", Year = 2014, Rating = 6.4f, Duration = 89},
                    new Movie() {Title = "The Devil's Advocate", Year = 1997, Rating = 7.5f, Duration = 144},
                    new Movie() {Title = "The Godfather", Year = 1972, Rating = 9.2f, Duration = 175},
                    new Movie() {Title = "Spy", Year = 2015, Rating = 7.0f, Duration = 120},
                    new Movie() {Title = "The Shawshank Redemption", Year = 1994, Rating = 9.3f, Duration = 142},
                    new Movie() {Title = "The Lord of the Rings: The Two Towers", Year = 2002, Rating = 8.7f, Duration = 179},
                    new Movie() {Title = "Constantine", Year = 2005, Rating = 7.0f, Duration = 121},
                    new Movie() {Title = "2001: A Space Odyssey", Year = 1968, Rating = 8.3f, Duration = 149},
                    new Movie() {Title = "Berserk: The Golden Age Arc I - The Egg of the King", Year = 2012, Rating = 7.6f, Duration = 76},
                    new Movie() {Title = "The Blind Side", Year = 2009, Rating = 7.6f, Duration = 129},
                    new Movie() {Title = "Miracles from Heaven", Year = 2016, Rating = 7.1f, Duration = 109},
                    new Movie() {Title = "The Count of Monte Cristo", Year = 2002, Rating = 7.8f, Duration = 131},
                    new Movie() {Title = "Vampire Hunter D: Bloodlust", Year = 2000, Rating = 7.7f, Duration = 103},
                    new Movie() {Title = "Kingdom of Heaven", Year = 2005, Rating = 7.2f, Duration = 144},
                    new Movie() {Title = "Togo", Year = 2019, Rating = 8.1f, Duration = 113},
                    new Movie() {Title = "The Man Who Would Be King", Year = 1975, Rating = 7.8f, Duration = 129},
                    new Movie() {Title = "Million Dollar Baby", Year = 2004, Rating = 8.1f, Duration = 132},
                    new Movie() {Title = "Se7en", Year = 1995, Rating = 8.6f, Duration = 127},
                    new Movie() {Title = "The Naked Gun", Year = 1988, Rating = 7.6f, Duration = 85},
                    new Movie() {Title = "Tommy Boy", Year = 1995, Rating = 7.1f, Duration = 97},
                    new Movie() {Title = "The NeverEnding Story", Year = 1984, Rating = 7.4f, Duration = 102},
                    new Movie() {Title = "Leap Year", Year = 2010, Rating = 6.5f, Duration = 100},
                    new Movie() {Title = "Lethal Weapon", Year = 1987, Rating = 7.6f, Duration = 109},
                    new Movie() {Title = "Yip Man", Year = 2008, Rating = 8.0f, Duration = 106},
                    new Movie() {Title = "Star Wars: Episode V - The Empire Strikes Back", Year = 1980, Rating = 8.7f, Duration = 124},
                    new Movie() {Title = "Maleficent", Year = 2014, Rating = 7.0f, Duration = 97},
                    new Movie() {Title = "Airplane!", Year = 1980, Rating = 7.7f, Duration = 88},
                    new Movie() {Title = "21", Year = 2008, Rating = 6.8f, Duration = 123},
                    new Movie() {Title = "Dudes", Year = 2001, Rating = 7.9f, Duration = 90},
                    new Movie() {Title = "When I Grow Up, I'll Be a Kangaroo", Year = 2004, Rating = 8.4f, Duration = 92},
                    new Movie() {Title = "Barking at the Stars", Year = 1998, Rating = 8.7f, Duration = 95},
                    new Movie() {Title = "We Are Not Angels", Year = 1992, Rating = 8.4f, Duration = 98},
                    new Movie() {Title = "White Men Can't Jump", Year = 1992, Rating = 6.8f, Duration = 115},
                    new Movie() {Title = "Back to the Future", Year = 1985, Rating = 8.5f, Duration = 116},
                    new Movie() {Title = "Full Metal Jacket", Year = 1987, Rating = 8.3f, Duration = 116},

                };
            }
    }
}
