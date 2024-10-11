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
	}
}
