using libraryone;

/*IFile file = new FileAzure();

file.Read();
file.Write("mi texto");
*/


List<IAnimal> animals = new List<IAnimal>();
animals.Add(new Pato());
animals.Add(new Perro());
animals.Add(new Gorrion());

foreach (IAnimal animal in animals) 
{
    animal.HaceRuido();
    animal.Come();
    animal.Dientes = "Dientes";
    
    if (animal is IVolador)
    {
        ((IVolador)animal).Volar();
    }
}  



