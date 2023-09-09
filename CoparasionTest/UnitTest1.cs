using System.Collections.Generic;
namespace CoparasionTest
{
    public class UnitTest1
    {
        [Fact]
        public void SortByYear_ShouldSortMoviesByYearDescending()
        {
            List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "The Shawshank Redemption", Year = 1994 },
            new Movie { Title = "The Godfather", Year = 1972 },
            new Movie { Title = "Pulp Fiction", Year = 1994 },
            new Movie { Title = "A Beautiful Mind", Year = 2001 },
            new Movie { Title = "Avatar", Year = 2009 }
        };

            var sortedMovies = MovieSorter.SortByYear(movies);

            Assert.Equal(2009, sortedMovies[0].Year);
            Assert.Equal(1972, sortedMovies[4].Year);
        }

        [Fact]
        public void SortByTitle_ShouldSortMoviesByTitleIgnoringArticles()
        {
            List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "The Shawshank Redemption", Year = 1994 },
            new Movie { Title = "The Godfather", Year = 1972 },
            new Movie { Title = "Pulp Fiction", Year = 1994 },
            new Movie { Title = "A Beautiful Mind", Year = 2001 },
            new Movie { Title = "Avatar", Year = 2009 }
        };

            var sortedMovies = MovieSorter.SortByTitle(movies);

            Assert.Equal("A Beautiful Mind", sortedMovies[0].Title);
            Assert.Equal("The Godfather", sortedMovies[4].Title);
        }
    }
}