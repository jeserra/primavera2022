public class Mascota
{
    public string Raza {get;set;}
    public string Nombre {get;set;}
    public DateTime FechaNacimiento {get;set;}

    public int Edad ()
    {
        return DateTime.Now.Year - FechaNacimiento.Year;
    }

    public void Dormir()
    {
        Console.WriteLine("{0} está durmiendo", Nombre);
    }
    
}