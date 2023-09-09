using System.Security.Cryptography.X509Certificates;

namespace Comparisons
{
	public class Program
	{
		static void Main(string[] args)
		{
			var movie1 = new Movie
			{
				Title = "The Shawshank Redemption",
				Year = 1999,
				Genres = new List<string> { "Drama", "Crime" }
			};

			var movie2 = new Movie
			{
				Title = "The Godfather",
				Year = 1972,
				Genres = new List<string> { "Drama", "Crime" }
			};

			var movie3 = new Movie
			{
				Title = "Pulp Fiction",
				Year = 1994,
				Genres = new List<string> { "Crime", "Drama" }
			};
			var movieList = new List<Movie> { movie1, movie2, movie3 };

			var newList = SortByYear(movieList);
			Console.WriteLine("Sorted Movie Data by Year:");
			foreach (var movie in newList)
			{
				Console.WriteLine($"Title: {movie.Title}");
				Console.WriteLine($"Year: {movie.Year}");
				Console.WriteLine("Genres:");
				foreach (var genre in movie.Genres)
				{
					Console.WriteLine($"- {genre}");
				}
				Console.WriteLine();
			}
			Console.WriteLine("-------------------------------------------------------------------------------------");
			var newList2 = SortByTitle(movieList);
			Console.WriteLine("Sorted Movie Data by Title:");
			foreach (var movie in newList2)
			{
				Console.WriteLine($"Title: {movie.Title}");
				Console.WriteLine($"Year: {movie.Year}");
				Console.WriteLine("Genres:");
				foreach (var genre in movie.Genres)
				{
					Console.WriteLine($"- {genre}");
				}
				Console.WriteLine();
			}

		}
		public static List<Movie> SortByYear(List<Movie> movies)
		{
			List<Movie> result = movies.OrderByDescending(movie => movie.Year).ToList();

			return result;

		}
		public static List<Movie> SortByTitle(List<Movie> movies)
		{
		
			List<Movie> result = movies
				.OrderBy(movie =>
				{
					string title = movie.Title;
					if (title.StartsWith("The ", StringComparison.OrdinalIgnoreCase))
					{
						title = title.Substring(4); 
					}
					else if (title.StartsWith("A ", StringComparison.OrdinalIgnoreCase))
					{
						title = title.Substring(2); 
					}
					else if (title.StartsWith("An ", StringComparison.OrdinalIgnoreCase))
					{
						title = title.Substring(3); 
					}
					return title;
				})
				.ToList();

			return result;
		}

	}
}