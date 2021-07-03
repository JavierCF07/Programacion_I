using System;

namespace M3_Apuntadores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------Haremos un swap-------");

            int a = 3;
            int b = 8;

            Console.WriteLine("a={0} y b ={1}", a, b);

            //Invocamos el swap

            unsafe { swap(&a, &b); }
            Console.WriteLine("a={0} y b ={1}", a, b);
        }

        unsafe public static void swap(int* a, int* b)
        {
            int temp = *b;
            *b = *a;
            *a = temp;
        }
    }
}
