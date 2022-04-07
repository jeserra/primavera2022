public class Persona
{
    public Persona(string name, string lastName)
    {
        this.Name = name;
        this.LastName = lastName;
        this.nacionalidad = "MExicana";
    }
    public string Name { get; }
    public string LastName { get;  }
    public DateTime BirthDate { get; set; }
    public string Localidad { get; set; }

    protected string nacionalidad;

    public int Age {get { return DateTime.Now.Year - BirthDate.Year; } }

    public string Nacionalidad() { return nacionalidad; }
} 