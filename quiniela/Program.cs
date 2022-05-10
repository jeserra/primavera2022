 

List<String> Equipos = new List<String>()
{
    "Atlas" , "Chivas", "Tigres", "America", "Cruz Azul", "Pachuca", "Puebla", "San Luis"
};

List<String> Participantes = new List<String>()
{
    "Dulce", "Alondra", "Andrea", "Gonzalo", "Eunice", "Eduardo", "?", "?"
};

var resultado =  GenerarQuiniela (Equipos, Participantes);

foreach (var item in resultado)
{
    Console.WriteLine(item);
}

List<String> GenerarQuiniela (List<String> Equipos, List<String>Participantes)
{
    List<String> EquiposParticipantes = new List<string>();

	var sortedEquipos = Equipos.OrderBy(_ => Guid.NewGuid());
    List<string> sortedParticipantes = Participantes.OrderBy(_ => Guid.NewGuid()).ToList();

    foreach (var item in sortedEquipos)
    {
        EquiposParticipantes.Add(item + " - " + sortedParticipantes.First());
        sortedParticipantes.RemoveAt(0);
    }
    return EquiposParticipantes;
}