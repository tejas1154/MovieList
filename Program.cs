using MovieStoreApp;

namespace MovieStoreapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to movie store developed by: Tejas Ramane");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add new Movie");
                Console.WriteLine("2. Display All Movies");
                Console.WriteLine("3. Find Movie by ID");
                Console.WriteLine("4. Remove Movie by ID");
                Console.WriteLine("5. Clear All Movies");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        Movie.AddMovie();
                        break;
                    case "2":
                        Movie.DisplayAllMovies();
                        break;
                    case "3":
                        Movie.FindMovieById();
                        break;
                    case "4":
                        Movie.RemoveMovieById();
                        break;
                    case "5":
                        Movie.ClearAllMovies();
                        break;
                    case "6":
                        Console.WriteLine("Exiting application.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
