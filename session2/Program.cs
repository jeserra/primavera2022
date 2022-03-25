
using System; // Librerias que se utilizan en el programa 
using System.Collections;

namespace session1  // Espacio de nombres 
{
    public class Program 
    {
        static void Main ()
        {
            int  entero = 100;
            byte enterobyte = 249;
            
            decimal moneda = 12.55m;
            float monedafloat = 12.55f;
            
            DateTime fechadate = DateTime.Now;

            string cadena = "Hola mundo";

            bool booleano = true;

            var variable = "esta es una cadena";
            var enterovar = 100;

            Console.WriteLine ($"Este es un entero {entero}", entero);   // Escribe en pantalla}
            Console.WriteLine ($"Este es un byte {enterobyte}", enterobyte);
            Console.WriteLine ($"Este es un decimal {moneda}", moneda);
            Console.WriteLine ($"Este es un float {monedafloat}", monedafloat);
            Console.WriteLine ($"Este es un DateTime {fechadate}", fechadate);
            Console.WriteLine ($"Este es un string {cadena}", cadena);
            Console.WriteLine ($"Este es un bool {booleano}", booleano);
            Console.WriteLine ($"Este es una cadena {variable}", variable);
            Console.WriteLine ($"Este es un entero var {enterovar}", enterovar);

          

        }

 
    }
}