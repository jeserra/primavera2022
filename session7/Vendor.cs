using System;
public class Vendor: Persona
{
    public Vendor(string name, string lastName) : base(name, lastName)
    {
        this.nacionalidad = "MExicana";
    }

    public Vendor (): base(String.Empty, String.Empty)
    {
        this.nacionalidad = "American";
    }
}