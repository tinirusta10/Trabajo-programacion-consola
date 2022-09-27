﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTrabajo
{
    internal class Ejercicio73
    {
        static void Main(string[] args)
        {
            string cadena;

            Queue<string> ColaStr = new Queue<string>();

            Console.WriteLine("ingrese una cadena en la cola");
            cadena = Console.ReadLine();

            while (cadena != "")
            {
                ColaStr.Enqueue(cadena);
                Console.WriteLine("Ingrese una proxima cadena en la cola");
                cadena = Console.ReadLine();
            }

            while (ColaStr.Count > 0)
            {
                Console.WriteLine(ColaStr.Dequeue());
            }

            Console.ReadKey();

        }
    }
}
