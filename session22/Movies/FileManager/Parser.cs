namespace Movies;

public class Parser 
{
    public Movie Parse(string line)
    {
        var movie = new Movie();
        var values = line.Split(',');
        movie.Id = long.Parse(values[0]);
        movie.Title = values[1];
        //Action-Science Fiction-Comedy-Family-Adventure

        movie.Genre = ParseGenre(values[2]);
        movie.OriginalLanguage = ParseOriginalLanguage(values[3]);
        movie.Overview = values[4];
        //movie.Popularity = long.Parse(values[5]);
        //movie.ProductionCompanies = values[6].Split('-').ToList();
        return movie;
    }

    public Genre ParseGenre(string line)
    {
        Genre returnValue = new Genre();
        var values = line.Split('-');
        foreach (var item in values)
        {
            if(item.Any(Char.IsWhiteSpace))
            {
                if(item == "Science Fiction")
                    returnValue = returnValue | Genre.Science | Genre.Fiction;
            }
            else 
            {
                if (Enum.TryParse<Genre>(item, out var genreValue))
                    returnValue = returnValue | genreValue;
            }
        }
        return returnValue;
    }

    public Original_Language ParseOriginalLanguage(string item)
    {
 
        if (Enum.TryParse<Original_Language>(item, out var languageValue))
            return languageValue;
        else
            return Original_Language.none;
    }
}