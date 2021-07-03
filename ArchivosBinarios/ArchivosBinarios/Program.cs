using System;
using System.IO;
using System.Linq;

namespace ArchivosBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream leer;
            FileStream escribir;
            BinaryReader leerBinario;
            BinaryWriter escribirBinario;

            escribir = new FileStream("c:/tmp/empleado.dat", FileMode.OpenOrCreate, FileAccess.Write);
            escribirBinario = new BinaryWriter(escribir);

            escribirBinario.Write("Maria");
            escribirBinario.Write(20);
            escribirBinario.Write(9.9);
            escribirBinario.Write('F');

            escribirBinario.Write("Fulano");
            escribirBinario.Write(30);
            escribirBinario.Write(9.9);
            escribirBinario.Write('M');

            escribirBinario.Write("Mengano");
            escribirBinario.Write(40);
            escribirBinario.Write(9.9);
            escribirBinario.Write('M');

            escribir.Close();
            escribirBinario.Close();

            leer = new FileStream("c:/tmp/empleado.dat", FileMode.OpenOrCreate, FileAccess.Read);
            leerBinario = new BinaryReader(leer);

            while (leer.Position != leer.Length)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.WriteLine("Nombre  : " + leerBinario.ReadString());
                Console.WriteLine("Edad    : " + leerBinario.ReadInt32());
                Console.WriteLine("Estatura: " + leerBinario.ReadDouble());
                Console.WriteLine("Sexo    : " + leerBinario.ReadChar());
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            }

            leer.Close();
            leerBinario.Close();

            Console.ReadKey();
        }
    }
}
