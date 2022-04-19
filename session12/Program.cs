// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int valor1 = 100;
int valor2 = 200;

Sumas sumas = new Sumas();

decimal valord1 = 500;
decimal valord2 = 600;

var resultado = sumas.sumar(valor1, valor2);

var resultadod = sumas.sumar(valord1, valord2);

Console.WriteLine(resultado);

Console.WriteLine(resultadod);

int [] arreglo = new int[10];

List<int> lista = new List<int>();
lista.Add(1);
lista.Add(2);
lista.Add(3);

Console.WriteLine(lista.Count);

Persona persona = new Persona();
persona.Name = "Juan";
persona.LastName = "Perez";

Persona persona2 = new Persona();
persona2.Name = "lalo";
persona2.LastName = "serrano";

List<Persona> lista2 = new List<Persona>();
lista2.Add(persona);
lista2.Add(persona2);

foreach(var item in lista2)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.LastName);
}

lista2.Remove(persona);

Console.WriteLine(lista2.Count);

lista2.Clear();



