namespace MovieFestival;

class App
{
    static void Main(string[] args)
    {

        string drama = new Genre("Drama").GetData();

        Console.WriteLine(drama);
    }
}

