public struct Casa 
{
    public string Localizacion {get;set;}
    public string M2 {get;set;}
    public string M2Construidos {get;set;}

    public Color Color {get;set;}

    public string ObtenerLocalizacion () 
    {
        return Localizacion ;
    }
}