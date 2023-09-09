namespace Sorting_Comparisons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "The Shawshank Redemption", Year = 1994 },
            new Movie { Title = "The Godfather", Year = 1972 },
            new Movie { Title = "Pulp Fiction", Year = 1994 },
            new Movie { Title = "A Beautiful Mind", Year = 2001 },
            new Movie { Title = "Avatar", Year = 2009 },
            new Movie { Title = "A Few Good Men", Year = 1992 },
            new Movie { Title = "Inception ", Year = 2010 },
            new Movie { Title = "The Departed ", Year = 2006 }
        };

                Console.WriteLine("Original List:");
                foreach (var movie in movies)
                {
                    Console.WriteLine($"Title: {movie.Title}, Year: {movie.Year}");
                }

                Console.WriteLine("\nSorted by Year (Most Recent First):");
                var sortedByYear = MovieSorter.SortByYear(movies);
                foreach (var movie in sortedByYear)
                {
                    Console.WriteLine($"Title: {movie.Title}, Year: {movie.Year}");
                }

                Console.WriteLine("\nSorted by Title (Ignoring Articles):");
                var sortedByTitle = MovieSorter.SortByTitle(movies);
                foreach (var movie in sortedByTitle)
                {
                    Console.WriteLine($"Title: {movie.Title}, Year: {movie.Year}");
                }
            }
    }
}