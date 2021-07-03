using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// TAREA REALIZADA POR: JAVIER CIFUENTES
/// FECHA: 21/02/2021
/// OBJETIVO: LLEVAR EL CONTROL DE LAS OPCIONES QUE TIENE UN EMPLEADO.
/// </summary>
namespace Laboratorio_1
{
    class Program
    {

        //static void Main(string[] args) //Principal
        //{
        //    int NUM1, NUM2, RESUL;
        //    string linea;

        //    Console.Write("PRIMER NUMERO: "); //Escribe en pantalla
        //    linea = Console.ReadLine(); //Lee lo ingresado por el usuario
        //    NUM1 = int.Parse(linea); //Convierte la variable linea a int, e ingresa el valor en la variable NUM1
        //    Console.WriteLine("SEGUNDO NUMERO: ");
        //    linea = Console.ReadLine();
        //    NUM2 = int.Parse(linea);
        //    Console.WriteLine("RESULTADO: ");
        //    RESUL = NUM1 + NUM2;
        //    Console.WriteLine("LA SUMA ES: " + RESUL);
        //    RESUL = NUM1 - NUM2;
        //    Console.WriteLine("LA RESTA ES: {0} - {1} = {2}", NUM1, NUM2, RESUL);
        //    RESUL = NUM1 * NUM2;
        //    Console.WriteLine("LA MULTIPLICACION ES: " + RESUL);
        //    RESUL = NUM1 / NUM2;
        //    Console.WriteLine("LA DIVISION ES: " + RESUL);
        //    RESUL = NUM1 % NUM2;
        //    Console.WriteLine("EL RESIDUO ES: " + RESUL);
        //    Console.WriteLine("PULSE UNA TECLA: "); Console.ReadLine();
        //}

        /// <summary>
        /// Este procedimiento se utiliza para agregar informacion
        /// </summary>
        /// <param name="lintDato">Es un tipo de dato entero donde se guarda la edad</param>
        public void SubAgregar(int lintDato)
        {
            string lStrInformacion = string.Empty; //Variable local vacia
            Console.Clear(); //Limpiar la pantalla
            Console.WriteLine("Usted selecciono la opcion Agregar");
            Console.Write("Presione una tecla para continuar..."); //Write sirve para imprimir datos en pantalla en la misma linea
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo op; //Sirve para obtener info de la tecla seleccionada;

            do //Ciclo de repeticion
            {
                Console.Clear(); //Limpiar la pantalla
                Console.WriteLine("CLASE VIRTUAL INICIANDO A GENERAR CODIGO");
                Console.WriteLine("----------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red; //Cambia color a la letra en consola a rojo;
                Console.WriteLine("[A]Agregar");
                Console.WriteLine("[E]Eliminar");
                Console.WriteLine("[B]Buscar");
                Console.WriteLine("[Esc]Salir");
                Console.ForegroundColor = ConsoleColor.White; //Cambia color a la letra en consola en blanco;
                Console.WriteLine("Seleccione opcion...");
                op = Console.ReadKey(true); //Que no muestre la tecla señalada

                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Program lObjProceso = new Program(); //Crea una instancia del objeto;
                        lObjProceso.SubAgregar(10);
                        Console.WriteLine("Usted selecciono la opcion Agregar");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.E:
                        SubCiclo(10);
                        Console.WriteLine("Usted selecciono la opcion Eliminar");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        SubValidacion(15);
                        Console.WriteLine("Usted selecciono la opcion Buscar");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Feliz fin de semana");
                        break;
                }
            } while (op.Key != ConsoleKey.Escape);
        }
        /// <summary>
        /// Muestra valores segun la cantidad de veces.
        /// </summary>
        /// <param name="lintcantidadVeces">Dato entero para indicar el numero de repeticiones</param>
        public static void SubCiclo(int lintcantidadVeces)
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hola Mundo, el contador es {counter}");
                counter++;
            }

            Console.Write("Presione una tecla para continuar...");

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World, The index es {index}");
            }

            Console.WriteLine("Presione una tecla para continuar...");
        }

        public static void SubValidacion(int lintcantidadVeces)
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("Es mayor a 10");
            }
            else
            {
                Console.WriteLine("Es menor a 10");
            }
        }
    }
}