using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EjercicioNo3MenuArchivosColas
{
    class Program
    {
        public struct Estudiante
        {
            public Estudiante(string nombre, string carnet)
            {
                Nombre = nombre;
                Carnet = carnet;
            }

            public string Nombre { get; set; }
            public string Carnet { get; set; }

            public override string ToString() => $"({Nombre}, {Carnet})";
        }
        Queue<Estudiante> MisEstudiantes = new Queue<Estudiante>();
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;
            Program lObjProceso = new Program();

            do
            {
                lObjProceso.SubMenuPrincipal();

                op = Console.ReadKey(true); //Que no muestre la tecla señalada
                Console.WriteLine(op.Key);
                //métodos son acciones, las propiedades son valores

                switch (op.Key)
                {
                    case ConsoleKey.NumPad1:
                        lObjProceso.SubCrearCola();
                        Console.ReadKey();

                        break;
                    case ConsoleKey.D1:
                        lObjProceso.SubCrearCola();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad2:
                        lObjProceso.SubEliminarCola();
                        Console.ReadKey();

                        break;
                    case ConsoleKey.D2:
                        lObjProceso.SubEliminarCola();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad3:
                        lObjProceso.SubListarCola();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        lObjProceso.SubListarCola();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad4:
                        Environment.Exit(0);

                        break;

                    case ConsoleKey.D4:
                        Environment.Exit(0);
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("SALIENDO DEL SISTEMA.");

                        break;
                }
            } while ((op.Key != ConsoleKey.Escape));

        }
        public void SubCrearCola()
        {

            Boolean lblnContinuaIngresando = true;
            String lStrDeseaContinuar = string.Empty;
            string lStrNombreEmpelado = string.Empty;
            string lStrDepartamentoDEmpleado = string.Empty;
            while (lblnContinuaIngresando == true)
            {
                Console.Clear(); //Limpiar la pantalla
                Console.SetCursorPosition(0, 3);
                string StrTitulo = "INFORMACION A COMPLETAR DEL ESTUDIANTE";
                Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                Console.WriteLine(StrTitulo);

                Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(35, 8); Console.WriteLine("NOMBRE       :            [                                          ]");
                Console.SetCursorPosition(35, 9); Console.WriteLine("CARNET       :            [                                          ]");
                Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));

                Console.SetCursorPosition(70, 8); lStrNombreEmpelado = Console.ReadLine();
                Console.SetCursorPosition(70, 9); lStrDepartamentoDEmpleado = Console.ReadLine();

                Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:        [  ]");
                Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                //rellenando o agregando elementos a la cola
                Estudiante miEstudiante = new Estudiante();
                miEstudiante.Nombre = lStrNombreEmpelado;
                miEstudiante.Carnet = lStrDepartamentoDEmpleado;
                MisEstudiantes.Enqueue(miEstudiante);
                if (lStrDeseaContinuar.ToUpper() == "N")
                {
                    lblnContinuaIngresando = false;

                }



                //Console.WriteLine("Dequeuing '{0}'", MisEstudiantes.Peek());
                Console.Write("            Presione una tecla para continuar...");
            }
        }
        public void SubEliminarCola()
        {
            Console.Clear(); //Limpiar la pantalla
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(15, 4); Console.WriteLine("COLA ELIMINADA");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(25, 7); Console.WriteLine("\nESTUDIANTE ELIMINADO... '{0}'", MisEstudiantes.Dequeue());
        }
        public void SubListarCola()
        {
            Console.Clear(); //Limpiar la pantalla
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(15, 4); Console.WriteLine("INFORMACIÓN DE LAS COLAS");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));

            //Console.SetCursorPosition(52, 6);
            foreach (Estudiante number in MisEstudiantes)
            {
                Console.WriteLine(number);
            }
            Console.SetCursorPosition(30, 30); Console.Write("            Presione una tecla para continuar...");
        }
        public void SubMenuPrincipal()
        {
            Console.Clear(); //Limpiar la pantalla
            Console.Title = "Colas"; // Titulo de la pantalla.
            string StrTitulo = "Colas";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(25, 2); Console.WriteLine("CURSO: PROGRAMACIÓN 1 ");
            Console.SetCursorPosition(25, 3); Console.WriteLine("NOMBRE: Javier Cifuentes");
            Console.SetCursorPosition(25, 4); Console.WriteLine("CARNET: 0900-20-6600");
            Console.SetCursorPosition(25, 5); Console.WriteLine("SECCION: C");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            StrTitulo = "MENU PRINCIPAL";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(30, 09); Console.WriteLine("    1. ALTA DE ALUMNO");
            Console.SetCursorPosition(30, 10); Console.WriteLine("    2. BAJA DE ALUMNO");
            Console.SetCursorPosition(30, 11); Console.WriteLine("    3. LISTAR EMPLEADO");
            Console.SetCursorPosition(30, 12); Console.WriteLine("    4. SALIR DEL SISTEMA [ESC]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(30, 16); Console.WriteLine("   ELIJA EL NÚMERO DE OPCIÓN [  ]          ");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(61, 16);
        }
    }
}