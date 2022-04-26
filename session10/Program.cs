using System;
using System.Collections.Generic;
using System.Text;

char c = 'a';
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"{c}");

string cadena = "hola mundo";

Console. WriteLine($"{cadena.ToUpper()}");

Console.WriteLine($" { cadena.ToLower()}");

Console.WriteLine($" sub string {cadena.Substring(0,3)}"); //substring 

Console.WriteLine($" { cadena.Replace("o","e")}");

string cadena2 = " esta nueva cadena";

Console.WriteLine($" {cadena + cadena2}");


var listapalabras = cadena2.Split(" ");

Console.WriteLine($"{listapalabras[0]}");
Console.WriteLine($"{listapalabras[1]}");
Console.WriteLine($"{listapalabras[2]}");
Console.WriteLine($"{listapalabras[3]}");

StringBuilder  strBuilder = new StringBuilder();
strBuilder.Append("primera paralbara");
strBuilder.Append(" segunda paralbara");
strBuilder.Append(" tercera paralbara");

Console.WriteLine($"{strBuilder.ToString()}");

int entero = 10 ;

string valorentero =  $"{String.Format("{0:C}", entero)}";


Console.WriteLine($"{valorentero}");


double doble = 10.123312;
string valordoble = $"{String.Format("{0,-10:C}", doble)}";

Console.WriteLine($"{valordoble}");




