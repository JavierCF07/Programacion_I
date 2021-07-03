//using System;
//using System.IO;

//namespace ExamenParcial_2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            long offset;

//            //Generar la rutina para abrir el archivo y hacer un recorrido desde el final del archivo hasta el inicio
//            // alphabet.txt contains "abcdefghijklmnopqrstuvwxyz"
//            using (FileStream fs = new FileStream("c:/tmp/AlfabetoNumeros.txt", FileMode.Open, FileAccess.Read))
//            {
//                for (offset = 1; offset <= fs.Length; offset++)
//                {
//                    fs.Seek(-offset, SeekOrigin.End);
//                    Console.Write(Convert.ToChar(fs.ReadByte()));
//                }
//                Console.WriteLine();
//            }
//            Console.ReadKey();
//        }
//    }
//}

using System;
using System.IO;

namespace ExamenParcial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nextByte;

            //Generar la rutina para desplegar en pantalla el contenido del archivo a partir de la posición 25.
            // AlfabetoNumeros.txt contiene "abcdefghijklmnopqrstuvwxyz123456789"
            using (FileStream fs = new FileStream("c:/tmp/AlfabetoNumeros.txt", FileMode.Open, FileAccess.Read))
            {
                
                fs.Seek(25, SeekOrigin.Begin);
                while ((nextByte = fs.ReadByte()) > 0)
                {
                    Console.Write(Convert.ToChar(nextByte));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}