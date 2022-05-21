using System.Xml.Serialization;

namespace Movies;

public class FileWriterXml : IFileWriter
{
    public void Write(List<Movie> movies, string path)
    {
        var serializer = new XmlSerializer(typeof(List<Movie>));
        using (var writer = new StreamWriter(path))
        {
            serializer.Serialize(writer, movies);
        }
    }
}