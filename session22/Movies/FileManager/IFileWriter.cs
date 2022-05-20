namespace Movies;
public interface IFileWriter
{
    public void Write(List<Movie> movies, string path);
}