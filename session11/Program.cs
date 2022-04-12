// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Casa casa = new Casa(); ;
casa.Localizacion = "Hidalgo 127";
casa.M2 ="200";
casa.M2Construidos ="120";

casa.Color = Color.Green;

Console.WriteLine($"La casa localizada en { casa.Localizacion } contiene { casa.M2Construidos }");

Console.WriteLine($"La casa es color { casa.Color }");

var documento = new Document();
documento.id = 1;
documento.name = "CFDI";
documento.Status = Status.Processed;

Console.WriteLine($"El documento{documento.id} {documento.name} fue {documento.Status}");

 var MesElegido =  (int)Meses.Enero ;
    Console.WriteLine($"El mes elegido es { MesElegido }");