using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LabNo1MenuArchivosPilas
{
    class Program
    {
        public struct Paciente
        {
            public Paciente(int idExpediente, string nombre, double edad, string diagnostico, int idPaciente)
            {
                IdExpediente = idExpediente;
                Nombre = nombre;
                Edad = edad;
                Diagnostico = diagnostico;
                Idpaciente = idPaciente;
            }

            public string Nombre { get; set; }
            public Double Edad { get; set; }
            public string Diagnostico { get; set; }
            public int IdExpediente { get; set; }
            public int Idpaciente { get; set; }

            public override string ToString() => $"({IdExpediente}{"        "}{Nombre}{"              "}{Edad}{"         "}{Diagnostico}{"              "}{IdExpediente}{"             "})";
        }
        Stack<Paciente> MisPacientes = new Stack<Paciente>();
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
                        lObjProceso.SubCrearPaciente();
                        Console.ReadKey();

                        break;
                    case ConsoleKey.D1:
                        lObjProceso.SubCrearPaciente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad2:
                        lObjProceso.SubEliminarPaciente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        lObjProceso.SubEliminarPaciente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad3:
                        lObjProceso.SubListarPaciente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        lObjProceso.SubListarPaciente();
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
        public void SubCrearPaciente()
        {

            Boolean lblnContinuaIngresando = true;
            int lStrIdExpediente = 0;
            int lStrIdPaciente = 0;
            String lStrDeseaContinuar = string.Empty;
            string lStrNombrePaciente = string.Empty;
            string lStrDiagnostico = string.Empty;
            Double lStrEdadPaciente = 0;
            int contador = MisPacientes.Count();

            while (lblnContinuaIngresando == true)
            {
                Console.Clear(); //Limpiar la pantalla
                Console.SetCursorPosition(0, 3);
                string StrTitulo = "INFORMACION A COMPLETAR DEL PACIENTE";
                Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                Console.WriteLine(StrTitulo);

                Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(35, 8); Console.WriteLine("ID DEL PACIENTE        :     [              " + (contador + 1) + "             ]");
                Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE DEL PACIENTE    :     [                                                 ]");
                Console.SetCursorPosition(35, 10); Console.WriteLine("EDAD DEL PACIENTE     :     [                                                 ]");
                Console.SetCursorPosition(35, 11); Console.WriteLine("DIAGNOSTICO           :     [                                                 ]");
                Console.SetCursorPosition(35, 12); Console.WriteLine("ID DEL EXPEDIENTE     :     [                                                 ]");
                Console.SetCursorPosition(25, 16); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));

                Console.SetCursorPosition(70, 8); lStrIdPaciente = (contador + 1);
                Console.SetCursorPosition(70, 9); lStrNombrePaciente = Console.ReadLine();
                Console.SetCursorPosition(70, 10); lStrEdadPaciente = double.Parse(Console.ReadLine());
                Console.SetCursorPosition(70, 11); lStrDiagnostico = Console.ReadLine();
                Console.SetCursorPosition(70, 12); lStrIdExpediente = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:      [         ]    ");
                Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                //rellenando o agregando elementos a la cola
                Paciente miPaciente = new Paciente();
                miPaciente.IdExpediente = lStrIdExpediente;
                miPaciente.Nombre = lStrNombrePaciente;
                miPaciente.Edad = lStrEdadPaciente;
                miPaciente.Diagnostico = lStrDiagnostico;
                miPaciente.Idpaciente = lStrIdPaciente;
                MisPacientes.Push(miPaciente);
                if (lStrDeseaContinuar.ToUpper() == "N")
                {
                    lblnContinuaIngresando = false;

                }
                contador = MisPacientes.Count();


                //Console.WriteLine("Dequeuing '{0}'", MisPacientes.Peek());
                Console.Write("            Presione una tecla para continuar...");
            }
        }
        public void SubEliminarPaciente()
        {
            int lIntLinea = 9;
            Console.Clear(); //Limpiar la pantalla
            Console.SetCursorPosition(0, 3);
            string StrTitulo = "LISTADO DE PILAS";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);

            Console.SetCursorPosition(5, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 110)));
            StrTitulo = "DETALLE DE PACIENTE A PROCESAR";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine("DETALLE DE PACIENTE A PROCESAR");
            Console.SetCursorPosition(5, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 110)));
            Console.SetCursorPosition(5, 8); Console.WriteLine("ID EXPEDIENTE        NOMBRE DEL PACIENTE              EDAD DEL PACIENTE         DIAGNOSTICO           ID PACIENTE             ");
            Console.SetCursorPosition(5, lIntLinea); Console.WriteLine(MisPacientes.Peek().IdExpediente);
            Console.SetCursorPosition(35, lIntLinea); Console.WriteLine(MisPacientes.Peek().Nombre);
            Console.SetCursorPosition(65, lIntLinea); Console.WriteLine(MisPacientes.Peek().Edad);
            Console.SetCursorPosition(85, lIntLinea); Console.WriteLine(MisPacientes.Peek().Diagnostico);
            Console.SetCursorPosition(115, lIntLinea); Console.WriteLine(MisPacientes.Peek().Idpaciente);
            String lStrDeseaContinuar = string.Empty;
            Console.SetCursorPosition(40, 10); Console.WriteLine("DESEA PROCESAR AL PACIENTE S/N:                 [  ]");
            Console.SetCursorPosition(90, 10); lStrDeseaContinuar = Console.ReadLine();
            if (lStrDeseaContinuar.ToUpper() == "S")
            {
                Console.SetCursorPosition(25, 18); Console.WriteLine("PACIENTE ELIMINADO...", MisPacientes.Pop().Nombre);

            }


            Console.SetCursorPosition(25, 20); Console.Write("            Presione una tecla para continuar...");

        }
        public void SubListarPaciente()
        {
            int lIntLinea = 9;
            Console.Clear(); //Limpiar la pantalla
            Console.SetCursorPosition(0, 3);
            string StrTitulo = "LISTADO DE PILAS";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);

            Console.SetCursorPosition(5, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 110)));
            StrTitulo = "DETALLE DE INFORMACION";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine("DETALLE DE INFORMACION");
            Console.SetCursorPosition(5, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 110)));
            Console.SetCursorPosition(5, 8); Console.WriteLine("ID PACIENTE        NOMBRE DEL PACIENTE              EDAD DEL PACIENTE         DIAGNOSTICO             ID EXPEDIENTE          ");


            foreach (Paciente number in MisPacientes)
            {
                Console.SetCursorPosition(5, lIntLinea); Console.WriteLine(number.Idpaciente);
                Console.SetCursorPosition(25, lIntLinea); Console.WriteLine(number.Nombre);
                Console.SetCursorPosition(65, lIntLinea); Console.WriteLine(number.Edad);
                Console.SetCursorPosition(82, lIntLinea); Console.WriteLine(number.Diagnostico);
                Console.SetCursorPosition(110, lIntLinea); Console.WriteLine(number.IdExpediente);
                lIntLinea += 1;
            }
            Console.SetCursorPosition(30, 30); Console.Write("            Presione una tecla para continuar...");
        }
        public void SubMenuPrincipal()
        {
            Console.Clear(); //Limpiar la pantalla
            Console.Title = "PILAS"; // Titulo de la pantalla.
            string StrTitulo = "PILAS";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(25, 2); Console.WriteLine("CURSO: PROGRAMACIÓN I ");
            Console.SetCursorPosition(25, 3); Console.WriteLine("NOMBRE: Javier Cifuentes");
            Console.SetCursorPosition(25, 4); Console.WriteLine("CARNET: 0900-20-6600");
            Console.SetCursorPosition(25, 5); Console.WriteLine("SECCION: C");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            StrTitulo = "MENU PRINCIPAL";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(30, 09); Console.WriteLine("    1. REGISTRAR PACIENTES");
            Console.SetCursorPosition(30, 10); Console.WriteLine("    2. ELIMINAR PACIENTES");
            Console.SetCursorPosition(30, 11); Console.WriteLine("    3. LISTAR PACIENTES");
            Console.SetCursorPosition(30, 12); Console.WriteLine("    4. SALIR [ESC]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(30, 16); Console.WriteLine("   ELIJA UNA OPCIÓN         [          ]          ");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(61, 16);
        }
    }
}