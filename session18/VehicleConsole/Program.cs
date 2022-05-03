using Vehicles;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido a la fabrica de Nissan");

Nissan vehicle = new Nissan();
vehicle.Color = "Rojo";
vehicle.Transmision = Transmision.Automatic;
vehicle.Model = NissanModel.Versa;
vehicle.Name = "Nissan Versa";
vehicle.Plate = "1232321";

Console.WriteLine("Vehiculo creado");
Console.WriteLine($"{vehicle.Name} {vehicle.Model} {vehicle.Color} {vehicle.Plate}");
Console.WriteLine($"Transmision: {vehicle.Transmision}");

