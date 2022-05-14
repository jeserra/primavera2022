namespace Movies;
public class Repository
{     
    public List<Movie> GetAll ()
    {         
        var listMovieStrings = FileReader.ReadFile(@"C:\Users\joser\OneDrive\Documentos\TRSF\Spring 2022\movies.csv");

        List<Movie>  ListMovies = new List<Movie>();        
        foreach (var item in listMovieStrings.Skip(1))
        {
            var parser = new Parser();
            var movie = parser.Parse(item);
            ListMovies.Add(movie);
        }

        return ListMovies;
    }
}