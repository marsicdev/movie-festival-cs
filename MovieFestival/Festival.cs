namespace MovieFestival
{
	public class Festival
	{
		#region Properties

		public string Name { get; set; }
		public List<string> Programs { get; set; } = new List<string>();

		#endregion

		#region Constructors

		public Festival(string name)
		{
			Name = name;
		}

		public Festival(string name, List<string> programs) : this(name)
		{
			Programs = programs;	
		}

		#endregion

		#region Public Methods

		public void AddProgram(string program)
		{
			Programs.Add(program);
		}

		public string GetData()
		{
			string result = "Festival name: " + Name + "\n" + "Total number of movies: " + GetTotalNumberOfMovies();

			int counter = 1;

			foreach (string program in Programs)
				result += "Program " + counter + ": " + program + "\n";

			return result;
		}

		#endregion

		#region Private Methods

		private int GetTotalNumberOfMovies()
		{
			return 0;
		}

		#endregion
	}
}
