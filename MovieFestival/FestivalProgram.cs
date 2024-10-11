namespace MovieFestival
{
	public class FestivalProgram
	{
		public string Date { get; set; }

		public List<string> Movies { get; set; }

		public FestivalProgram() 
		{ 
			Movies = new List<string>();
			Date = string.Empty;
		}

		public void AddMovie(string movie)
		{
			if (Movies == null)
				Movies = new List<string>(); 
				
			Movies.Add(movie);
		}

		public string GetData()
		{
			string data = string.Empty;

			if (Date != string.Empty)
				data = $"Total duration: {Date}\n";

			if(Movies != null)
			{
				foreach (string movie in Movies)
					data += $"{movie}\n";
			}

			return data;
	}
}
