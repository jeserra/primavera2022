public class Gorrion :IAnimal, IVolador
{
    public void HaceRuido()
    {
        Console.WriteLine("Pio");
    }
    public void Come()
    {
        Console.WriteLine("Come");
    }

    public string Dientes { get; set; }

    public void Volar()
    {
        Console.WriteLine("Vuela gorrion");
    }
}