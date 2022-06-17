namespace Movies
{
    public interface IRepository
    {
        List<Movie> GetAll();
        List<Movie> GetMovieByName(string title);
    }
}