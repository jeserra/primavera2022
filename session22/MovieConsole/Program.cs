using Movies;

var repository = new Repository();


Console.WriteLine("Titulo    --    Genero  --- Idioma");
foreach (var movie in repository.GetAll().Take(10))
{
    Console.WriteLine($"{movie.Title}    --    {movie.Genre}  ---    {movie.OriginalLanguage}");
}
 
 