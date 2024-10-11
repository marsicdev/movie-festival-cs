namespace MovieFestival
{
	public class Program
	{
		public string Date { get; set; }

		public List<Movie> Movies { get; set; }

		public Program() 
		{ 
			Movies = new List<Movie>();
			Date = string.Empty;
		}

		public void AddMovie(Movie movie)
		{
			if (Movies == null)
				Movies = new List<Movie>(); 
				
			Movies.Add(movie);
		}

		public string GetData()
		{
			return $"{Date}, {Movies.Sum(movie => movie.Length)}, {Movies.Count} movies";
		}
	}
}
