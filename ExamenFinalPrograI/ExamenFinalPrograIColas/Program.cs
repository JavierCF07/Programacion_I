using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenFinalPrograIColas
{
    public struct Cliente
    {
        public int lIntIDTurno;
        public string lStrNombreCliente;
        public string lStrAsunto;
        public int lIntEdad;
        public string lStrfechaHora;
    }
    class Program
    {
        
        Queue<Cliente> lObjDatosClientes = new Queue<Cliente>();
        Cliente lObjDato = new Cliente();
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;

            Program lObjProgram = new Program();

            do
            {
                lObjProgram.SubMenuPrincipal();
                op = Console.ReadKey(true);
                switch (op.Key)
                {
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        lObjProgram.SubRegistrarCliente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D1:
                        Console.Clear();
                        lObjProgram.SubRegistrarCliente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        lObjProgram.SubProcesarCliente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        lObjProgram.SubProcesarCliente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        lObjProgram.SubListarCliente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        lObjProgram.SubListarCliente();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("\nSaliendo del sistema");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("Saliendo del sistema");
                        break;
                    default:
                        Console.WriteLine("Por favor ingresar una opcion correcta");
                        break;
                }

            } while ((op.Key != ConsoleKey.Escape));
        }
        public void SubMenuPrincipal()
        {
            Console.Clear(); //Limpiar la pantalla
            Console.Title = "EXAMEN FINAL PROGRAMACION I - COLAS"; // Titulo de la pantalla.
            string StrTitulo = "EXAMEN FINAL PROGRAMACION I - COLAS";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(25, 2); Console.WriteLine("CURSO: PROGRAMACIÓN 1 ");
            Console.SetCursorPosition(25, 3); Console.WriteLine("NOMBRE: JAVIER ESTUARDO CIFUENTES FUNES");
            Console.SetCursorPosition(25, 4); Console.WriteLine("CARNET: 0900-20-6600");
            Console.SetCursorPosition(25, 5); Console.WriteLine("SECCION: C");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            StrTitulo = "MENU PRINCIPAL";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(30, 09); Console.WriteLine("    1. Registrar Cliente");
            Console.SetCursorPosition(30, 10); Console.WriteLine("    2. Pasar  Cliente");
            Console.SetCursorPosition(30, 11); Console.WriteLine("    3. Ver Listado de Clientes");
            Console.SetCursorPosition(30, 12); Console.WriteLine("    4. Salida [Esc]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(30, 14); Console.WriteLine("   ELIJA EL NÚMERO DE OPCIÓN [  ]          ");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(61, 14);
        }
        public void SubRegistrarCliente()
        {
            Boolean lblnContinuaIngresando = true;
            int lIntIDTurno = 0;
            String lStrDeseaContinuar = string.Empty;
            while (lblnContinuaIngresando == true)
            {
                lObjDato = new Cliente();
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                string gStrtitulo = "REGISTRAR CLIENTE";
                Console.SetCursorPosition((Console.WindowWidth - gStrtitulo.Length) / 2, Console.CursorTop); //Centrar el titulo
                Console.WriteLine(gStrtitulo);
                Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(34, 8); Console.WriteLine("ID TURNO                  :      [                                          ]");
                Console.SetCursorPosition(34, 9); Console.WriteLine("NOMBRE DEL CLIENTE        :      [                                          ]");
                Console.SetCursorPosition(35, 10); Console.WriteLine("ASUNTO                   :      [                                          ]");
                Console.SetCursorPosition(35, 11); Console.WriteLine("EDAD                     :      [                                          ]");
                Console.SetCursorPosition(35, 12); Console.WriteLine("FECHA Y HORA DE INICIO   :      [                                          ]");
                Console.SetCursorPosition(25, 13); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                if (lObjDatosClientes.Count == 0)
                {
                    lIntIDTurno = 1;
                }
                else
                {
                    int conteo = lObjDatosClientes.Count();
                    lIntIDTurno = conteo + 1;
                }

                Console.SetCursorPosition(70, 8); Console.WriteLine(lIntIDTurno);
                Console.SetCursorPosition(70, 9); lObjDato.lStrNombreCliente = Console.ReadLine();
                Console.SetCursorPosition(70, 10); lObjDato.lStrAsunto = Console.ReadLine();
                Console.SetCursorPosition(70, 11); lObjDato.lIntEdad = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(70, 12); lObjDato.lStrfechaHora = Console.ReadLine();
                lObjDato.lIntIDTurno = lIntIDTurno;
                lObjDatosClientes.Enqueue(lObjDato);
                Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S / N:      [  ]");
                Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                if (lStrDeseaContinuar.ToUpper() == "N")
                {
                    lblnContinuaIngresando = false;
                }
                Console.SetCursorPosition(15, 25); Console.WriteLine("Pulse cualquier tecla para continuar...");
            }

        }
        public void SubProcesarCliente()
        {
            String lStrDeseaContinuar = string.Empty;
            Console.Clear();
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            string gStrtitulo = "PASAR AL CLIENTE";
            Console.SetCursorPosition((Console.WindowWidth - gStrtitulo.Length) / 2, Console.CursorTop);
            Console.WriteLine(gStrtitulo);
            Console.SetCursorPosition(5, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
            if (lObjDatosClientes.Count() > 0)
            {
                lObjDato = lObjDatosClientes.Peek();
                Console.SetCursorPosition(14, 8); Console.WriteLine("ID TURNO               : " + lObjDato.lIntIDTurno);
                Console.SetCursorPosition(14, 9); Console.WriteLine("NOMBRE DEL CLIENTE     : " + lObjDato.lStrNombreCliente);
                Console.SetCursorPosition(14, 10); Console.WriteLine("ASUNTO                : " + lObjDato.lStrAsunto);
                Console.SetCursorPosition(14, 11); Console.WriteLine("EDAD                  : " + lObjDato.lIntEdad);
                Console.SetCursorPosition(14, 12); Console.WriteLine("FECHA Y HORA DE INICIO: " + lObjDato.lStrfechaHora);
                Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA PASAR ESTE CLIENTE S/N:                  [    ]");
                Console.SetCursorPosition(5, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
            }
            else
            {
                Console.SetCursorPosition(5, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(14, 13); Console.WriteLine("No existen registros...");
            }

            if (lStrDeseaContinuar.ToUpper() == "S")
            {
                lObjDatosClientes.Dequeue();
            }

            Console.SetCursorPosition(15, 25); Console.WriteLine("Pulse cualquier tecla para continuar...");
        }
        public void SubListarCliente()
        {
            String lStrDeseaContinuar = string.Empty;
            Console.Clear();
            int LIntNoLinea = 0;
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            string gStrtitulo = "LISTAR CLIENTE";
            Console.SetCursorPosition((Console.WindowWidth - gStrtitulo.Length) / 2, Console.CursorTop);
            Console.WriteLine(gStrtitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(10, 6); Console.WriteLine("ID TURNO      NOMBRE CLIENTE        ASUNTO                                  EDAD     FECHA Y HORA DE INICIO");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            LIntNoLinea = 8;
            if (lObjDatosClientes.Count() > 0)
            {
                foreach (Cliente lObjCliente in lObjDatosClientes)
                {
                    lObjDato = lObjDatosClientes.Peek();
                    Console.SetCursorPosition(14, LIntNoLinea); Console.WriteLine(lObjCliente.lIntIDTurno); ;
                    Console.SetCursorPosition(23, LIntNoLinea); Console.WriteLine(lObjCliente.lStrNombreCliente);
                    Console.SetCursorPosition(44, LIntNoLinea); Console.WriteLine(lObjCliente.lStrAsunto);
                    Console.SetCursorPosition(87, LIntNoLinea); Console.WriteLine(lObjCliente.lIntEdad);
                    Console.SetCursorPosition(99, LIntNoLinea); Console.WriteLine(lObjCliente.lStrfechaHora);
                    LIntNoLinea += 1;
                }
            }
            else
            {
                Console.SetCursorPosition(14,13); Console.WriteLine("No existen registros...");
            }
            

            Console.SetCursorPosition(15, 25); Console.WriteLine("Pulse cualquier tecla para continuar...");

        }
    }
}
