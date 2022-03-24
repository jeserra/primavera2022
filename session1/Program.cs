
using System; // Librerias que se utilizan en el programa 
using System.Collections;

namespace session1  // Espacio de nombres 
{
    public class Program 
    {
        static void Main ()
        {
            Console.WriteLine ("Ingresa un numero");
            int input = 10;
            var resultado = sumar(input);            
            Console.WriteLine ("El resultado es {0}", resultado);
        }

        static int sumar(int input)
        {
            int resultado = input + input;
            return resultado;
        }
    }
}