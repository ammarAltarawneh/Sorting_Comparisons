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
            var sortedMovies = movies.OrderBy(movie => movie.Title, new TitleComparer()).ThenBy(movie => movie.Year).ToList();
            return sortedMovies;
        }

        private class TitleComparer : IComparer<string>
        {
            private readonly string[] Articles = { "A ", "An ", "The " };

            public int Compare(string x, string y)
            {
                // Remove articles and perform case-insensitive comparison
                x = RemoveArticles(x);
                y = RemoveArticles(y);

                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }

            private string RemoveArticles(string title)
            {
                foreach (var article in Articles)
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
}
