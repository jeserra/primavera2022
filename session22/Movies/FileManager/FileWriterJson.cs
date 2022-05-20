using Newtonsoft.Json;

namespace Movies;

public class FileWriterJson : IFileWriter
{
    public void Write(List<Movie> movies, string path)
    {
        var json = JsonConvert.SerializeObject(movies);
        File.WriteAllText(path, json); 
    }
}
