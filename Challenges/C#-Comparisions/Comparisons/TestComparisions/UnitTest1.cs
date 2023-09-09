using Comparisons;

namespace TestComparisions
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{

		}

		[Fact]
		public void SortByYear_ShouldSortMoviesByYearDescending()
		{
			// Arrange
			var movie1 = new Movie { Title = "Movie1", Year = 2000 };
			var movie2 = new Movie { Title = "Movie2", Year = 1990 };
			var movie3 = new Movie { Title = "Movie3", Year = 2010 };

			var movies = new List<Movie> { movie1, movie2, movie3 };

			// Act
			var sortedMovies = Program.SortByYear(movies);

			// Assert
			Assert.Equal(2010, sortedMovies[0].Year);
			Assert.Equal(2000, sortedMovies[1].Year);
			Assert.Equal(1990, sortedMovies[2].Year);
		}
		[Fact]
		public void SortByTitle_ShouldSortMoviesByTitleIgnoringPrefix()
		{
			// Arrange
			var movie1 = new Movie { Title = "The Movie", Year = 2000 };
			var movie2 = new Movie { Title = "A Great Movie", Year = 1990 };
			var movie3 = new Movie { Title = "Movie Without Prefix", Year = 2010 };

			var movies = new List<Movie> { movie1, movie2, movie3 };

			// Act
			var sortedMovies = Program.SortByTitle(movies);

			// Assert
			Assert.Equal("A Great Movie", sortedMovies[0].Title);
			Assert.Equal("The Movie", sortedMovies[1].Title);
			Assert.Equal("Movie Without Prefix", sortedMovies[2].Title);
		}


	}
}