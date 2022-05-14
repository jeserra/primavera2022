namespace Movies;

public class Parser 
{
    public Movie Parse(string line)
    {
        var movie = new Movie();
        var values = line.Split(',');
        movie.Id = long.Parse(values[0]);
        movie.Title = values[1];
       // movie.Genre = (Genre)Enum.Parse(typeof(Genre), values[2]);
      //  movie.OriginalLanguage = (Original_Language)Enum.Parse(typeof(Original_Language), values[3]);
        movie.Overview = values[4];
       // movie.Popularity = long.Parse(values[5]);
        //movie.ProductionCompanies = values[6].Split('-').ToList();
        return movie;
    }
}