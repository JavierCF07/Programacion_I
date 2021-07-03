using System;

namespace ArraysConPunteros
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int[] datos = { 10, 20, 30 };
                Console.WriteLine("Leyendo el segundo dato...");
                fixed (int* posicionDato = &datos[1])
                {
                    Console.WriteLine("En posicionDato hay {0}", *posicionDato);
                }
                Console.WriteLine("Leyendo el primer dato...");
                fixed (int* posicionDato = datos)
                {
                    Console.WriteLine("Ahora en posicionDato hay {0}", *posicionDato);
                }
                const int tamanyoArray = 5;
                int* datos1 = stackalloc int[tamanyoArray];
                // Rellenamos el array 
                for (int i = 0; i < tamanyoArray; i++)
                {
                    datos1[i] = i * 10;
                }
                // Mostramos el array 
                for (int i = 0; i < tamanyoArray; i++)
                {
                    fixed (int* posicionDato = &datos[i])
                    {
                        Console.WriteLine("En posicionDato hay {0}, posiciones de apuntador ", *posicionDato);
                    }
                }
            }
        }
    }
}
