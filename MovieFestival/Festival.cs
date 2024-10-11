namespace MovieFestival
{
	public class Festival
	{
		#region Properties

		public string Name { get; set; }
		public List<Program> Programs { get; set; } = new List<Program>();

		#endregion

		#region Constructors

		public Festival(string name)
		{
			Name = name;
		}

		public Festival(string name, List<Program> programs) : this(name)
		{
			Programs = programs;	
		}

		#endregion

		#region Public Methods

		public void AddProgram(Program program)
		{
			Programs.Add(program);
		}

		public string GetData()
		{
			string result = "Festival name: " + Name + "\n";

			int programCounter = 1;
			int moviesCounter = 0;

			foreach (Program program in Programs)
			{
				result += "Program " + programCounter + ": " + program.GetData() + "\n";
				programCounter++;
				moviesCounter += program.Movies.Count;
			}

			result += "Total number of movies: " + moviesCounter;

			return result;
		}

		#endregion
	}
}
