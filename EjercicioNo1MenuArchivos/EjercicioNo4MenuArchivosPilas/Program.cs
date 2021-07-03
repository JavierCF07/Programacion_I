using System;
using System.Collections.Generic;

namespace EjercicioNo4MenuArchivosPilas
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            Stack<string> miPila = new Stack<string>();
            miPila.Push("Hola");
            miPila.Push("soy");
            miPila.Push("yo");

            for (byte i = 0; i < 3; i++)
            {
                palabra = (string)miPila.Pop();
                Console.WriteLine(palabra);
            }

        }
    }
}
