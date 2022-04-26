public static class Paseo 
{ 

    public static void Pasear ()
    { 
        var persona = new Persona();
        persona.Name = "Dulce";
        persona.Surname = "Villalobos";
        persona.Email = "Correodulce@gmail.com";

        Console.WriteLine("Nombre : " + persona.Name);        
    }
}