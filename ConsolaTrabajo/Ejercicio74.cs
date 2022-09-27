using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTrabajo
{
    internal class Ejercicio74
    {
        private static void main(string[] args)
        {
            string cadena;

            Stack<string> pila = new Stack<string>();

            Console.WriteLine("ingrese una cadena en la cola");
            cadena = Console.ReadLine();

            while (cadena != "")
            {
                pila.Push(cadena);
                Console.WriteLine("Ingrese una proxima cadena en la cola");
                cadena = Console.ReadLine();
            }

            while (pila.Count > 0)
            {
                string dato = pila.Pop();
                Console.WriteLine(dato);

            }



            {

                Console.ReadKey();



            }
        }
    }
}
