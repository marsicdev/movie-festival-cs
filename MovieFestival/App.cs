namespace MovieFestival;

class App
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi!");
        FestivalDetails();
    }

    private static void FestivalDetails()
    {
        Console.WriteLine("Please enter festival name:  ");
        string festivalName = Console.ReadLine();
        Console.WriteLine("Please enter number of movies:  ");
        int numberOfMovies = Convert.ToInt32(Console.ReadLine());

        List<string> movieDetailList = new List<string>();
        for (int i = 0; i < numberOfMovies; i++)
        {            
            Console.WriteLine($"Please enter movie #{i+1} details:  ");
            movieDetailList.Add(Console.ReadLine());
        }

        Console.WriteLine($"Festival name '{festivalName}', number of movies is {numberOfMovies}:");
        for (int i = 0; i < movieDetailList.Count; i++)
        {            
            Console.WriteLine($"    Movie #{i+1}: {movieDetailList[i]}");
        }
    } 
}

