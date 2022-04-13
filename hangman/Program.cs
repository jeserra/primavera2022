
string [] words = new string[] {"Escoba", "Trapeador", "Pelota", 
                                    "Escalera", "Ventana",
                                     "Casa", "Juguete", "Libro", "Cheetos","Salon"};


Random rand = new Random();
var selected = rand.Next(words.Length);
var guess = words[selected];

var wordDictated = new char[guess.Length];

var failedAttempts = 0;

do 
{
    Console.WriteLine("Introduce una letra");
    var item = Console.ReadKey();
    Console.WriteLine();

    if (guess.ToLower().Contains(item.KeyChar.ToString().ToLower()))
    {
        for (int i = 0; i < guess.Length; i++)
        {
            if (guess[i] == item.KeyChar)
            {
                wordDictated[i] = item.KeyChar;
            }
        }
        Console.WriteLine(new string(wordDictated));
    }
    else
    {
        failedAttempts++;
        Console.WriteLine($"Has fallado {failedAttempts} veces");
    }


} while (failedAttempts<3 &&  (new string(wordDictated)!= guess));

if(failedAttempts ==3)
    Console.WriteLine($"Has perdido");
else
    Console.WriteLine($"Has ganado");

Console.ReadKey();


