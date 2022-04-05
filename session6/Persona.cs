public class Persona 
{


    private Nacionalidad nacionalidad 
    {

    }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Sexo { get; set; }

    public Mascota mascota {get;set;}

    public void Dormir()
    { 
        Console.WriteLine("{0} {1} está durmiendo", Nombre, Apellido);
    }

    public void Correr ()
    { 
        Console.WriteLine("{0} {1} está corriendo", Nombre, Apellido);
    }
    public void Comer(string comida)
    { 
        Console.WriteLine("{0} {1} está comiendo {2}", Nombre, Apellido, comida);
    }

    public void Saludar()
    { 
        Console.WriteLine("Hola, soy {0} {1}", Nombre, Apellido);
    } 
}