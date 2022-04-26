// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 
using ( var persona = new Persona())
{ 

    persona.Name = "John";
    persona.Surname = "Doe";
    persona.Email = "mimail@hotmail.com";
    Console.WriteLine("Nombre : " + persona.Name);
}
 
//persona.Dispose();


//Paseo.Pasear();
// Heap  Memory 

// Se guardan los objetos instanciados 


//Console.WriteLine("Nombre : " + persona.Name);

Moneda.Country= "Mexican";
Moneda.DolarValue = 0.05;
Moneda.Name = "Peso";

GC.Collect();

//Console.WriteLine("Nombre : " + persona.Name);

// Stack Memory 
// Aqui se guardan los objetos estaticos