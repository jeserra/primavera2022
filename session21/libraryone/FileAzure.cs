using libraryone;

public class FileAzure : IFile
{
    public void Write(string text)
    {
        Console.WriteLine($"Escribir {text} en el un sistema de archivos en azure");
        // ...
    }
    public string Read()
    {
        Console.WriteLine("Leer del archivo de la nube");
        return "text";
    }
}