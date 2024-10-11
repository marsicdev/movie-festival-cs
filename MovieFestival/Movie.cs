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
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        public Movie(int length, Genre genre, string title, int releaseYear)
        {
            Length = length;
            Genre = genre;
            Title = title;
            ReleaseYear = releaseYear;
        }

        public string GetData()
        {
            return $"{Title}, {Length}min, {Genre.GetData()}, {ReleaseYear}";
        }
    }
}
