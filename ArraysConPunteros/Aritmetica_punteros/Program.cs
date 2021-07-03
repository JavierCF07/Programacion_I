using System;

namespace Aritmetica_punteros
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int letter = 27;
                int* pointerToLetter = &letter;

                Console.WriteLine($"Value of the variable: {letter}");
                Console.WriteLine($"Address of the `letter` variable: {(long)pointerToLetter:X}");

                *pointerToLetter = 'Z';
                Console.WriteLine($"Value of the `letter` variable after update: {letter}");
                Console.WriteLine($"Address of the `letter` variable: {(long)pointerToLetter:X}");

                char* pointerToChars = stackalloc char[123];

                for (int i = 65; i < 123; i++)
                {
                    pointerToChars[i] = (char)i;
                }

                Console.WriteLine("Uppercase letters: ");
                for (int i = 65; i < 91; i++)
                {
                    Console.Write(pointerToChars[i]);
                }

                const int count = 3;
                int[] numbers = new int[count] { 10, 20, 30 };
                fixed(int* pointerToFirst = &numbers[0])
                {
                    int* pointerToLast = pointerToFirst + (count - 1);

                    Console.WriteLine($"Value {*pointerToFirst} at address {(long)pointerToFirst}");
                    Console.WriteLine($"Value {*pointerToLast} at address {(long)pointerToLast}");
                }

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
            }
        }
    }
}
