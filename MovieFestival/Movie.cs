using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
	public class Movie
	{
		public int Length { get; set; }
		public string Genre { get; set; }
		public string Title { get; set; }

		public Movie(int length, string genre, string title)
		{
			Length = length;
			Genre = genre;
			Title = title;
		}

		public string GetData()
		{
			string movie = $"{Title}, {Length}min, {Genre[0]}{char.ToUpper(Genre[Genre.Length - 1])}";
			return movie;
		}
        public Movie CreateMovie()
        {
            Console.WriteLine("Genre: ");
			string MyGenre = Console.ReadLine();
            Console.WriteLine("Length: ");
            int MyLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("TItle: ");
            string MyTitle = Console.ReadLine();

			return new Movie(MyLength, MyGenre, MyTitle);
        }
    }
}
