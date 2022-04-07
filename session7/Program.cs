
Vendor persona = new Vendor("Hugo", "Gonzalez");

Console.WriteLine("Nacionalidad : "+ persona.Nacionalidad());

Console.WriteLine("Edad :"+ persona.Age);

 Vendor vendor2 = new Vendor(); 

 Console.WriteLine("Name :"+ vendor2.Name);
Console.WriteLine("Nacionalidad : "+ vendor2.Nacionalidad());
vendor2.BirthDate = new DateTime(1990, 1, 1);
Console.WriteLine("Edad :"+ vendor2.Age);
 
