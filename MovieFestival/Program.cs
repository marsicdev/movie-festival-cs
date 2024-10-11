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
			string data = string.Empty;

			if (Date != string.Empty)
				data = $"Total duration: {Date}\n";

			if (Movies != null)
			{
				foreach (var movie in Movies)
					data += $"{movie.GetData()}\n";
			}

			return data;
		}

        public Program CreateProgram()
        {
            Console.WriteLine("Date: ");
            string MyDate = Console.ReadLine();
            Program MyProgram = new Program();
			MyProgram.Date = MyDate;

			return MyProgram;
        }
    }
}
