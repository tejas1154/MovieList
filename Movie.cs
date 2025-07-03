using System;
using System.Collections.Generic;

namespace MovieStoreApp
{
    public class MaximumMovieException : Exception
    {
        public override string Message
        {
            get
            {
                return "Maximum of 5 movies are allowed only";
            }
        }
    }

    public class InvalidIdException : Exception 
    {
        public override string Message
        {
            get
            {
                return "Invalid Id. Movie with such Id is not present";
            }
        }
    }
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public string Genre { get; set; }

        private static List<Movie> movieList = new List<Movie>();
        private const int MaxMovies = 5;

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Year: {YearOfRelease}, Genre: {Genre}";
        }
        public static void AddMovie()
        {
            try
            {
                if (movieList.Count >= MaxMovies)
                {
                    throw new MaximumMovieException();
                }

                Movie movie = new Movie();

                Console.Write("Enter Movie ID: ");
                movie.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Movie Name: ");
                movie.Name = Console.ReadLine();

                Console.Write("Enter Year of Release: ");
                movie.YearOfRelease = int.Parse(Console.ReadLine());

                Console.Write("Enter Genre: ");
                movie.Genre = Console.ReadLine();

                movieList.Add(movie);
                Console.WriteLine("Movie added successfully.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }   
        public static void DisplayAllMovies()
        {
            if (movieList.Count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            Console.WriteLine("All Movies:");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }
        }

        public static void FindMovieById()
        {
            try
            {
                Console.Write("Enter Movie ID to search: ");
                int id = int.Parse(Console.ReadLine());

                Movie foundMovie = null;

                foreach (Movie m in movieList)
                {
                    if (m.Id == id)
                    {
                        foundMovie = m;
                        break;
                    }
                }


                if (foundMovie != null)
                {
                    Console.WriteLine("Movie Found:");
                    Console.WriteLine(foundMovie);
                }
                else
                    throw new InvalidIdException();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        
        public static void RemoveMovieById()
        {
            try
            {
                Console.Write("Enter Movie ID to remove: ");
                int id = int.Parse(Console.ReadLine());

                Movie movieToRemove = null;

                foreach (Movie m in movieList)
                {
                    if (m.Id == id)
                    {
                        movieToRemove = m;
                        break;
                    }
                }

                if (movieToRemove != null)
                {
                    movieList.Remove(movieToRemove);
                    Console.WriteLine("Movie removed successfully.");
                }
                else
                    throw new InvalidIdException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void ClearAllMovies()
        {
            movieList.Clear();
            Console.WriteLine("All movies cleared.");
        }
    }
}
