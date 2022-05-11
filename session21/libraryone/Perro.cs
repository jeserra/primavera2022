using libraryone;

public class Perro:  IAnimal
{
    public void HaceRuido()
    {
        Console.WriteLine("Guau");
    }
    public void Come()
    {
        Console.WriteLine("Come");
    }

    public string Dientes { get; set; }
}