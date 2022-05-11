using libraryone;

public class File: IFile
{
    public void Write(string text)
    {
        Console.WriteLine($"Escribir {text} en el archivo en el disco");
        // ...
    }
    public string Read()
    {
        Console.WriteLine("Leer del archivo del disco");
        return "text";
    }
}