// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Persona persona = new Persona();
persona.Nombre = "Juan";
persona.Apellido = "Perez";
persona.Edad = 25;
persona.Sexo = "Masculino";

persona.mascota = new Perro();
persona.mascota.Raza = "Perro";
persona.mascota.Nombre = "Firulais";
persona.mascota.Edad();
persona.mascota.Dormir();
((Perro) persona.mascota).Ladrar();


persona.Correr();
persona.Dormir();
persona.Comer("Chilaquiles");
