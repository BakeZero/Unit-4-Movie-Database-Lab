using System;
using System.Diagnostics;

namespace Unit_4_Movie_Database_Lab
{
    internal class Program
    {
        static void Main()
        {
            string an = "animated";
            string dr = "drama";
            string ho = "horror";
            string sc = "scifi";
            List<Movie> moviesList = new List<Movie>();
            moviesList.Add(new Movie("Interstellar", sc));
            moviesList.Add(new Movie("Your Name", an));
            moviesList.Add(new Movie("Weathering With You", an));
            moviesList.Add(new Movie("Suzume", an));
            moviesList.Add(new Movie("Spirited Away", an));
            moviesList.Add(new Movie("Blade Runner 2049", sc));
            moviesList.Add(new Movie("Pulp Fiction", dr));
            moviesList.Add(new Movie("Dune", sc));
            moviesList.Add(new Movie("American Psycho", ho));
            moviesList.Add(new Movie("Halloween", ho));
            moviesList.Add(new Movie("Annihilation", ho));
            moviesList.Add(new Movie("The Wolf of Wall Street", dr));
            moviesList.Add(new Movie("Jaws", ho));

            moviesList = moviesList.OrderBy(x => x.Title).ToList();

            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine("There are " + moviesList.Count + " movies in this list.");
            do
            {
                Console.Write("What category are you interested in? (animated, drama, horror, scifi): ");
                string prompt = Console.ReadLine();
                if (prompt.ToLower() == "animated" || prompt.ToLower() == "drama" || prompt.ToLower() == "horror" || prompt.ToLower() == "scifi")
                {
                    foreach (Movie elem in moviesList)
                    {
                        if (elem.Category == prompt)
                            elem.Display();
                    }
                }
                else
                    Console.WriteLine("Invalid category.");
            } while (Continue());

        }

        static bool Continue()
        {
            Console.Write("Continue? (y/n): ");
            string prompt = Console.ReadLine();
            if (prompt.ToLower() == "y")
            {
                return true;
            }
            else if (prompt.ToLower() == "n")
            {
                return false;
            }
            else
                return Continue();
        }
    }
}