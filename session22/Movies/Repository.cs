namespace Movies;
public class Repository : IRepository
{
    public List<Movie> ListMovies { get; set; }
    private bool LoadedFile { get; set; } = false;

    public void LoadFile(String filename)
    {
        try
        {
            ListMovies = new List<Movie>();
            var listMovieStrings = FileReader.ReadFile(filename);
            foreach (var item in listMovieStrings.Skip(1).Take(100))
            {
                //  Console.WriteLine(item);
                var parser = new Parser();
                var movie = parser.Parse(item);
                ListMovies.Add(movie);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        LoadedFile = true;
    }

    public List<Movie> GetAll()
    {
        if (LoadedFile == false)
        {
            throw new Exception("No se ha cargado el archivo");
        }
        return ListMovies;
    }

    public List<Movie> GetMovieByName(String title)
    {
        //Console.WriteLine("leyendo movies por nombre");
        if (LoadedFile == false)
        {
            throw new Exception("No se ha cargado el archivo");
        }
        return ListMovies.Where(m => m.Title.Contains(title)).ToList();
    }

    public long Create (Movie movie)
    {
        throw new NotImplementedException();
    }
}

 