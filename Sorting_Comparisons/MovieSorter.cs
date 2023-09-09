using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Comparisons
{
    public static class MovieSorter
    {
        public static List<Movie> SortByYear(List<Movie> movies)
        {
            return movies.OrderByDescending(movie => movie.Year).ToList();
        }

        public static List<Movie> SortByTitle(List<Movie> movies)
        {
            var sortedMovies = movies.OrderBy(movie => RemoveArticles(movie.Title), StringComparer.OrdinalIgnoreCase)
                                     .ThenBy(movie => movie.Year)
                                     .ToList();
            return sortedMovies;
        }

        private static string RemoveArticles(string title)
        {            
            string[] articles = { "A ", "An ", "The " };
            foreach (var article in articles)
            {
                if (title.StartsWith(article, StringComparison.OrdinalIgnoreCase))
                {
                    title = title.Substring(article.Length);
                    break;
                }
            }
            return title;
        }
    }
}
