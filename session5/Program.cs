
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

            Console.WriteLine ("El resultado es: " + resultado);

             multiplicar(ref input);

            Console.WriteLine(input);

            if(dividir(input, out int output))
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("No se puede dividir por 0");
            }

            ImprimirResultado("Hola");
            ImprimirResultado("Hola", "Sobreescribir Mensaje");
            
            int[] numeros = {1,2,3,4,5};
            ImprimirArreglo(numeros);

         

        }

// parametro por valor
        static int sumar (int numero)
        {
            return numero + 10;
        }

        static int restar(int numero)
        {
            return numero - 10;
        }

// parametro por referencia
        static void multiplicar(ref int numero)
        {
            numero = numero * 10;
        }

// parametro output
        static bool dividir( int numero, out int resultado)
        {
            try 
            {
                resultado = numero / 10;
                return true;
            }
            catch (DivideByZeroException)
            {
                resultado = 0;
                return false;
            }
            
        }

        static void ImprimirResultado(string resultado, string mensaje ="bien hecho")
        {
            Console.WriteLine(resultado);
            Console.WriteLine(mensaje);
        }

        static void ImprimirArreglo (int [] arreglo)
        {
            foreach (var item in arreglo)
            {
                Console.WriteLine(item);
            }
        }

      

    }
}