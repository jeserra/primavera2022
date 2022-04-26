public class Persona: IDisposable
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }

    public void Dispose()
    {
        Console.WriteLine("Dispose");
    }
    ~Persona()
    { 
        Console.WriteLine("Persona destruyendose");
    }
}