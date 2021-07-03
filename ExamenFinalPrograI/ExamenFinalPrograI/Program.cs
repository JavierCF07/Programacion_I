using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExamenFinalPrograIPilas
{
    public struct Equipo
    {
        public int lIntIdEquipo;
        public string lStrDescripcion;
        public double lDblCostoEquipo;
        public double lDblCostoPrestamo;
        public string lStrFechaEntrega;
    }

    class Program
    {
        string gStrtitulo = string.Empty;
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;
            Program lObjProgram = new Program();

            do
            {
                lObjProgram.SubMenuPrincipal();
                op = Console.ReadKey(true);
                Console.WriteLine(op.Key);

                switch (op.Key)
                {
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        lObjProgram.SubRegistrarEquipo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D1:
                        Console.Clear();
                        lObjProgram.SubRegistrarEquipo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        lObjProgram.SubProcesarEquipo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        lObjProgram.SubProcesarEquipo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        lObjProgram.SubListarEquipo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        lObjProgram.SubListarEquipo();
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
        //Creando la pila
        Stack<Equipo> lObjEquipo = new Stack<Equipo>();
        Equipo lObjDato = new Equipo();
        public void SubMenuPrincipal()
        {
            Console.Clear(); //Limpiar la pantalla
            Console.Title = "EXAMEN FINAL PROGRAMACION I - PILAS"; // Titulo de la pantalla.
            string StrTitulo = "EXAMEN FINAL PROGRAMACION I - PILAS";
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
            Console.SetCursorPosition(30, 09); Console.WriteLine("    1. Registrar Equipo");
            Console.SetCursorPosition(30, 10); Console.WriteLine("    2. Procesar Equipo");
            Console.SetCursorPosition(30, 11); Console.WriteLine("    3. Ver Listado de Equipos");
            Console.SetCursorPosition(30, 12); Console.WriteLine("    4. Salida [Esc]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(30, 14); Console.WriteLine("   ELIJA EL NÚMERO DE OPCIÓN [  ]          ");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(61, 14);
        }
        public void SubRegistrarEquipo()
        {
            Boolean lblnContinuaIngresando = true;
            int lIntIDEquipo = 0;
            String lStrDeseaContinuar = string.Empty;
            while (lblnContinuaIngresando == true)
            {
                lObjDato = new Equipo();
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                gStrtitulo = "REGISTRAR EQUIPO";
                Console.SetCursorPosition((Console.WindowWidth - gStrtitulo.Length) / 2, Console.CursorTop); //Centrar el titulo
                Console.WriteLine(gStrtitulo);
                Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                Console.SetCursorPosition(34, 8); Console.WriteLine("ID EQUIPO            :            [                                          ]");
                Console.SetCursorPosition(34, 9); Console.WriteLine("DESCRIPCION EQUIPO   :            [                                          ]");
                Console.SetCursorPosition(35, 10); Console.WriteLine("COSTO EQUIPO        :            [                                          ]");
                Console.SetCursorPosition(35, 11); Console.WriteLine("COSTO PRESTAMO      :            [                                          ]");
                Console.SetCursorPosition(35, 12); Console.WriteLine("FECHA ENTREGA       :            [                                          ]");
                Console.SetCursorPosition(25, 13); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                if (lObjEquipo.Count == 0)
                {
                    lIntIDEquipo = 1;
                }
                else
                {
                    int conteo = lObjEquipo.Count();
                    lIntIDEquipo = conteo + 1;
                }
                
                Console.SetCursorPosition(70, 8); Console.WriteLine(lIntIDEquipo);
                Console.SetCursorPosition(70, 9); lObjDato.lStrDescripcion = Console.ReadLine();
                Console.SetCursorPosition(70, 10); lObjDato.lDblCostoEquipo = double.Parse(Console.ReadLine());
                Console.SetCursorPosition(70, 11); lObjDato.lDblCostoPrestamo = double.Parse(Console.ReadLine());
                Console.SetCursorPosition(70, 12); lObjDato.lStrFechaEntrega = Console.ReadLine();
                lObjDato.lIntIdEquipo = lIntIDEquipo;
                lObjEquipo.Push(lObjDato);
                Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S / N:      [   ]");
                Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                if (lStrDeseaContinuar.ToUpper() == "N")
                {
                    lblnContinuaIngresando = false;
                }
            }
        }
        public void SubProcesarEquipo()
        {
            String lStrDeseaContinuar = string.Empty;
            Console.Clear();
            int LIntNoLinea = 0;
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            gStrtitulo = "PROCESAR EQUIPO";
            Console.SetCursorPosition((Console.WindowWidth - gStrtitulo.Length)/2, Console.CursorTop);
            Console.WriteLine(gStrtitulo);
            Console.SetCursorPosition(5, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
            Console.SetCursorPosition(10, 6); Console.WriteLine("ID EQUIPO       DESCRIPCION                    COSTO EQUIPO     COSTO PRESTAMO   FECHA DE ENTREGA");
            Console.SetCursorPosition(5, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
            
            LIntNoLinea = 8;
            if (lObjEquipo.Count() > 0)
            {
                lObjDato = lObjEquipo.Peek();
                Console.SetCursorPosition(14, LIntNoLinea); Console.WriteLine(lObjDato.lIntIdEquipo);
                Console.SetCursorPosition(23, LIntNoLinea); Console.WriteLine(lObjDato.lStrDescripcion);
                Console.SetCursorPosition(60, LIntNoLinea); Console.WriteLine(lObjDato.lDblCostoEquipo);
                Console.SetCursorPosition(78, LIntNoLinea); Console.WriteLine(lObjDato.lDblCostoPrestamo);
                Console.SetCursorPosition(96, LIntNoLinea); Console.WriteLine(lObjDato.lStrFechaEntrega);
                Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA PROCESAR ESTE EQUIPO S/N:                  [   ]");
                Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
            }
            else
            {
                Console.SetCursorPosition(25, 25); Console.WriteLine("No existen registros...");
            }
            

            if (lStrDeseaContinuar.ToUpper() == "S")
            {
                lObjEquipo.Pop();

            }
            Console.SetCursorPosition(25, 25); Console.WriteLine("Presione cualquier tecla para continuar...");
        }
        public void SubListarEquipo()
        {
            String lStrDeseaContinuar = string.Empty;
            Console.Clear();
            int LIntNoLinea = 0;
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            gStrtitulo = "LISTAR EQUIPO";
            Console.SetCursorPosition((Console.WindowWidth - gStrtitulo.Length) / 2, Console.CursorTop);
            Console.WriteLine(gStrtitulo);
            Console.SetCursorPosition(5, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
            Console.SetCursorPosition(10, 6); Console.WriteLine("ID EQUIPO       DESCRIPCION                    COSTO EQUIPO     COSTO PRESTAMO   FECHA DE ENTREGA");
            Console.SetCursorPosition(5, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
            LIntNoLinea = 8;
            if (lObjEquipo.Count > 0)
            {
                foreach (Equipo lEquipo in lObjEquipo)
                {
                    Console.SetCursorPosition(14, LIntNoLinea); Console.WriteLine(lEquipo.lIntIdEquipo);
                    Console.SetCursorPosition(23, LIntNoLinea); Console.WriteLine(lEquipo.lStrDescripcion);
                    Console.SetCursorPosition(60, LIntNoLinea); Console.WriteLine(lEquipo.lDblCostoEquipo);
                    Console.SetCursorPosition(78, LIntNoLinea); Console.WriteLine(lEquipo.lDblCostoPrestamo);
                    Console.SetCursorPosition(96, LIntNoLinea); Console.WriteLine(lEquipo.lStrFechaEntrega);
                    LIntNoLinea += 1;
                }
            }
            else
            {
                Console.SetCursorPosition(25, 10); Console.WriteLine("No existen registros...");
            }
            
            Console.SetCursorPosition(25, 25); Console.WriteLine("Presione cualquier tecla para continuar...");
        }
    }
}
