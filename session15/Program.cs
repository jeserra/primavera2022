// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int [] arreglo = new int [10] {1,2,3,4,5,6,7,8,9,10};


var nQuery = 
    from item in arreglo
    where item % 2 == 0
    select item;

foreach (var item in nQuery)
{
    Console.WriteLine(item);
}

var nQueryMayor5 = 
    from item in arreglo
    where item > 5
    select item;

foreach (var item in nQueryMayor5)
{
    Console.WriteLine(item);
}   

Console.WriteLine("\n\n");
List<string> listado = new List<string>();  
listado.Add("Hola");
listado.Add("Mundo");
listado.Add("ayer");
listado.Add("tambien");

var squery = 
    from item in listado
    where item.Length > 5
    select item;

foreach (var item in squery)
{
    Console.WriteLine(item);
}


List<Auto> listadoAutos = new List<Auto>();

listadoAutos.Add(new Auto("Ford", "Fiesta", 80000));
listadoAutos.Add(new Auto("Chevrolet", "Silverado", 120000));
listadoAutos.Add(new Auto("Nissan", "Tsuru", 20000));
listadoAutos.Add(new Auto("Nissan", "Versa", 150000));

/*
var nQueryAutos = 
    from item in listadoAutos
    where item.Marca == "Nissan"
    select item;*/

var nQueryAutos2 = 
    from item2 in listadoAutos
    where item2.Precio > 130000
    select new { item2.Marca, item2.Modelo };
/*
foreach (var item in nQueryAutos)
{
    Console.WriteLine(item.Marca + " " + item.Modelo + " " + item.Precio + " " );
}*/

foreach (var item in nQueryAutos2)
{
    Console.WriteLine(item.Marca + " " + item.Modelo);
}






class Auto
{
    public Auto(string marca, string modelo, decimal precio)
    {
        Marca = marca;
        Modelo = modelo;
        Precio = precio;
    }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public decimal Precio { get; set; }
}