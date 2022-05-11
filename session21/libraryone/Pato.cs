using libraryone; 
public class Pato :IAnimal, IVolador
{
     public void HaceRuido()
    {
        Console.WriteLine("Cuac");
    }
    public void Come()
    {
        Console.WriteLine("Come");
    }

    public string Dientes { get; set; } 

    public void Volar()
    {
        Console.WriteLine("Vuela");
    }
}