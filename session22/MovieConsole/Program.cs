using Movies;

var repository = new Repository();

foreach (var movie in repository.GetAll())
{
    Console.WriteLine(movie.Title);
}

 