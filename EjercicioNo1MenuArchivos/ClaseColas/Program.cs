using System;
using System.Collections.Generic;
using System.Linq;
namespace ClaseColas
{
    public struct DatoCliente
    {
        public int lIntIdCliente;
        public string lStrCliente;
        public double lDblSaldo;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;
            Program lObjProceso = new Program();
            Boolean lblnContinuaIngresando = true;
            String lStrDeseaContinuar = string.Empty;
            Queue<DatoCliente> LobjDatosClientes = new Queue<DatoCliente>();

            do
            {
                lObjProceso.SubMenuPrincipal();

                op = Console.ReadKey(true); //Que no muestre la tecla señalada
                Console.WriteLine(op.Key);
                //métodos son acciones, las propiedades son valores

                switch (op.Key)
                {
                    case ConsoleKey.NumPad1:
                        String StrTitulo = String.Empty;
                        DatoCliente lObjDato = new DatoCliente();
                        int lIntNoLinea = 0;
                        lblnContinuaIngresando = true;
                        while (lblnContinuaIngresando == true)
                        {
                            lObjDato = new DatoCliente();
                            Console.Clear(); //Limpiar la pantalla
                            Console.SetCursorPosition(0, 3);
                            StrTitulo = "INFORMACION DEL CLIENTE";
                            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                            Console.WriteLine(StrTitulo);
                            Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                            Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 8); Console.WriteLine("ID CLIENTE       :            [                                          ]");
                            Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE CLIENTE   :            [                                          ]");
                            Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                            Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 15); Console.WriteLine("SALDO        :        [                                          ]");
                            Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(70, 8); lObjDato.lIntIdCliente = int.Parse(Console.ReadLine());
                            Console.SetCursorPosition(70, 9); lObjDato.lStrCliente = Console.ReadLine();
                            Console.SetCursorPosition(70, 15); lObjDato.lDblSaldo = double.Parse(Console.ReadLine());
                            LobjDatosClientes.Enqueue(lObjDato);
                            Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:        [  ]");
                            Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                            if (lStrDeseaContinuar.ToUpper() == "N")
                            {
                                lblnContinuaIngresando = false;
                            }
                        }

                        break;
                    case ConsoleKey.D1:
                        //Agregando los elementos.
                        StrTitulo = String.Empty;
                        lblnContinuaIngresando = true;
                        while (lblnContinuaIngresando == true)
                        {
                            lObjDato = new DatoCliente();
                            Console.Clear(); //Limpiar la pantalla
                            Console.SetCursorPosition(0, 3);
                            StrTitulo = "INFORMACION DEL CLIENTE";
                            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                            Console.WriteLine(StrTitulo);
                            Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                            Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 8); Console.WriteLine("ID CLIENTE       :            [                                          ]");
                            Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE CLIENTE   :            [                                          ]");
                            Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                            Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 15); Console.WriteLine("SALARIO        :        [                                          ]");
                            Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(70, 8); lObjDato.lIntIdCliente = int.Parse(Console.ReadLine());
                            Console.SetCursorPosition(70, 9); lObjDato.lStrCliente = Console.ReadLine();
                            Console.SetCursorPosition(70, 15); lObjDato.lDblSaldo = double.Parse(Console.ReadLine());
                            LobjDatosClientes.Enqueue(lObjDato);
                            Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:        [  ]");
                            Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                            if (lStrDeseaContinuar.ToUpper() == "N")
                            {
                                lblnContinuaIngresando = false;
                            }
                        }


                        break;

                    case ConsoleKey.NumPad2:
                        //quitar elemento de  la colas .
                        Console.Clear(); //Limpiar la pantalla
                        Console.SetCursorPosition(0, 3);
                        StrTitulo = "PASAR CLIENTE";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine(StrTitulo);
                        Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                        Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 8); Console.WriteLine("ID CLIENTE       :            [                                          ]");
                        Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE CLIENTE   :            [                                          ]");
                        Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                        Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 15); Console.WriteLine("SALARIO        :        [                                          ]");
                        Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        lObjDato = new DatoCliente();
                        lObjDato = LobjDatosClientes.Peek();
                        Console.SetCursorPosition(70, 8); Console.WriteLine(lObjDato.lIntIdCliente);
                        Console.SetCursorPosition(70, 9); Console.WriteLine(lObjDato.lStrCliente);
                        Console.SetCursorPosition(70, 15); Console.WriteLine(lObjDato.lDblSaldo);
                        Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA PASAR A ESTE CLIENTE S/N:                  [  ]");
                        Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                        if (lStrDeseaContinuar.ToUpper() == "S")
                        {
                            LobjDatosClientes.Dequeue();
                        }

                        Console.ReadKey();

                        break;
                    case ConsoleKey.D2:
                        //quitar elemento de  la colas .
                        Console.Clear(); //Limpiar la pantalla
                        Console.SetCursorPosition(0, 3);
                        StrTitulo = "PASAR CLIENTE";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine(StrTitulo);
                        Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                        Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 8); Console.WriteLine("ID CLIENTE       :            [                                          ]");
                        Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE CLIENTE   :            [                                          ]");
                        Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                        Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 15); Console.WriteLine("SALARIO        :        [                                          ]");
                        Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        lObjDato = new DatoCliente();
                        lObjDato = LobjDatosClientes.Peek();
                        Console.SetCursorPosition(70, 8); Console.WriteLine(lObjDato.lIntIdCliente);
                        Console.SetCursorPosition(70, 9); Console.WriteLine(lObjDato.lStrCliente);
                        Console.SetCursorPosition(70, 15); Console.WriteLine(lObjDato.lDblSaldo);
                        Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA PASAR A ESTE CLIENTE S/N:                 [  ]");
                        Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                        if (lStrDeseaContinuar.ToUpper() == "S")
                        {
                            LobjDatosClientes.Dequeue();
                        }

                        Console.ReadKey();

                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear(); //Limpiar la pantalla
                        Console.SetCursorPosition(0, 3);
                        StrTitulo = "CLIENTES PENDIENTES DE PASAR ";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine(StrTitulo);
                        Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 6); Console.WriteLine("CODIGO CLIENTE              NOMBRE CLIENTE                       SALARIO");
                        Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        lIntNoLinea = 8;
                        foreach (DatoCliente lObjCliente in LobjDatosClientes)
                        {
                            Console.SetCursorPosition(35, lIntNoLinea); Console.WriteLine(lObjCliente.lIntIdCliente);
                            Console.SetCursorPosition(65, lIntNoLinea); Console.WriteLine(lObjCliente.lStrCliente);
                            Console.SetCursorPosition(100, lIntNoLinea); Console.WriteLine(lObjCliente.lDblSaldo);
                            lIntNoLinea += 1;
                        }

                        Console.ReadKey();

                        break;
                    case ConsoleKey.D3:
                        Console.Clear(); //Limpiar la pantalla
                        Console.SetCursorPosition(0, 3);
                        StrTitulo = "CLIENTES PENDIENTES DE PASAR ";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine(StrTitulo);
                        Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 6); Console.WriteLine("CODIGO CLIENTE              NOMBRE CLIENTE                       SALARIO");
                        Console.SetCursorPosition(35, 7); Console.WriteLine("===============================================================================");
                        lIntNoLinea = 8;
                        foreach (DatoCliente lObjCliente in LobjDatosClientes)
                        {
                            Console.SetCursorPosition(35, lIntNoLinea); Console.WriteLine(lObjCliente.lIntIdCliente);
                            Console.SetCursorPosition(65, lIntNoLinea); Console.WriteLine(lObjCliente.lStrCliente);
                            Console.SetCursorPosition(105, lIntNoLinea); Console.WriteLine(lObjCliente.lDblSaldo);
                            lIntNoLinea += 1;
                        }

                        Console.ReadKey();

                        break;

                    case ConsoleKey.D4:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.NumPad4:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("SALIENDO DEL SISTEMA.");

                        break;
                }
            } while ((op.Key != ConsoleKey.Escape));




        }
        public void SubMenuPrincipal()
        {
            Console.Clear(); //Limpiar la pantalla
            Console.Title = "CLASE NO.10 EJERCICIO DE MENUS Y COLAS"; // Titulo de la pantalla.
            string StrTitulo = "CLASE NO.10 EJERCICIO DE MENUS Y COLAS";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(25, 2); Console.WriteLine("CURSO: PROGRAMACIÓN 1 ");
            Console.SetCursorPosition(25, 3); Console.WriteLine("NOMBRE: ING. BAYRON MARTINEZ");
            Console.SetCursorPosition(25, 4); Console.WriteLine("CARNET: 090-01-431");
            Console.SetCursorPosition(25, 5); Console.WriteLine("SECCION: B");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            StrTitulo = "MENU PRINCIPAL";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
            Console.WriteLine(StrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(30, 09); Console.WriteLine("    1. Registrar  Cliente");
            Console.SetCursorPosition(30, 10); Console.WriteLine("    2. Pasar Cliente");
            Console.SetCursorPosition(30, 11); Console.WriteLine("    3. Ver Clientes en Cola");
            Console.SetCursorPosition(30, 12); Console.WriteLine("    4. Salida [Esc]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(30, 14); Console.WriteLine("   ELIJA EL NÚMERO DE OPCIÓN [  ]          ");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(61, 14);
        }

    }
}

