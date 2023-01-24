using System;
using MovieDatabaseLab;

bool runProgram = true;

List<Movie> AllMovies = new List<Movie>()
{
    new Movie("Midsommar", "Thriller"),
    new Movie("The Big Lebowski", "Comedy"),
    new Movie("No Country for Old Men", "Drama"),
    new Movie("Ray", "Biopic"),
    new Movie("Requiem For a Dream", "Drama"),
    new Movie("Star Wars III", "Scifi"),
    new Movie("American Psycho", "Thriller"),
    new Movie("The Dark Knight", "Action"),
    new Movie("Blade Runner 2049", "Scifi"),
    new Movie("Django", "Drama")
};




Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("There are 15 movies in this list.");


while (runProgram == true)
{
    Console.WriteLine("What category are you interested in?");
    string choice = Console.ReadLine();

    foreach (Movie m in AllMovies)
    {
        if(m.Category == choice)
        {
            Console.WriteLine(m.Title, m.Category);
        }
    }









    Console.WriteLine("Continue? y/n");
    string again = Console.ReadLine();
    if (again == "y" || again == "yes")
    {
        runProgram = true;
    }
    else
    {
        Console.WriteLine("Goodbye");
        runProgram = false;
    }

}








