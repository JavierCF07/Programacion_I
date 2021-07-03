using System;
using System.Collections.Generic;
using System.Linq;
namespace Clase1Pilas
{
    public struct DatoPaciente
    {
        public int lintIdExpediente;
        public string lStrNombrePaciente;
        public int lintEdad;
        public string lstrDiagnostico;
        public int lintIdPaciente;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;
            Program lObjProceso = new Program();
            Boolean lblnContinuaIngresando = true;
            String lStrDeseaContinuar = string.Empty;
            Stack<DatoPaciente> LobjDatosPaciente = new Stack<DatoPaciente>();

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
                        DatoPaciente lObjDato = new DatoPaciente();
                        int lIntNoLinea = 0;
                        lblnContinuaIngresando = true;
                        int lintIdExpedienteUltimo = 0;
                        while (lblnContinuaIngresando == true)
                        {
                            lObjDato = new DatoPaciente();
                            Console.Clear(); //Limpiar la pantalla
                            Console.SetCursorPosition(0, 3);
                            StrTitulo = "INFORMACION DEL PACIENTE";
                            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                            Console.WriteLine(StrTitulo);
                            Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                            Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 8); Console.WriteLine("ID EXPENDIENTE    :            [                                          ]");
                            Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE PACIENTE   :            [                                          ]");
                            Console.SetCursorPosition(35, 10); Console.WriteLine("EDAD              :            [                                          ]");
                            Console.SetCursorPosition(35, 11); Console.WriteLine("DIAGNOSTICO       :            [                                          ]");
                            Console.SetCursorPosition(35, 12); Console.WriteLine("ID PACIENTE       :            [                                          ]");
                            Console.SetCursorPosition(25, 13); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));

                            if (LobjDatosPaciente.Count == 0)
                            {
                                lintIdExpedienteUltimo = 1;
                            }
                            else
                            {
                                DatoPaciente lObjPacienteUltimo = new DatoPaciente();

                                lObjPacienteUltimo = LobjDatosPaciente.Peek();
                                lintIdExpedienteUltimo = lObjPacienteUltimo.lintIdExpediente + 1;

                            }


                            Console.SetCursorPosition(70, 8); Console.WriteLine(lintIdExpedienteUltimo);
                            Console.SetCursorPosition(70, 9); lObjDato.lStrNombrePaciente = Console.ReadLine();
                            Console.SetCursorPosition(70, 10); lObjDato.lintEdad = int.Parse(Console.ReadLine());
                            Console.SetCursorPosition(70, 11); lObjDato.lstrDiagnostico = Console.ReadLine();
                            Console.SetCursorPosition(70, 12); lObjDato.lintIdPaciente = int.Parse(Console.ReadLine());
                            lObjDato.lintIdExpediente = lintIdExpedienteUltimo;
                            LobjDatosPaciente.Push(lObjDato);
                            Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:        [  ]");
                            Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                            if (lStrDeseaContinuar.ToUpper() == "N")
                            {
                                lblnContinuaIngresando = false;
                            }
                        }


                        break;
                    case ConsoleKey.D1:
                        StrTitulo = String.Empty;
                        lObjDato = new DatoPaciente();
                        lIntNoLinea = 0;
                        lblnContinuaIngresando = true;
                        lintIdExpedienteUltimo = 0;
                        while (lblnContinuaIngresando == true)
                        {
                            lObjDato = new DatoPaciente();
                            Console.Clear(); //Limpiar la pantalla
                            Console.SetCursorPosition(0, 3);
                            StrTitulo = "INFORMACION DEL POACIENTE";
                            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                            Console.WriteLine(StrTitulo);
                            Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                            Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 8); Console.WriteLine("ID EXPENDIENTE    :            [                                          ]");
                            Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE PACIENTE   :            [                                          ]");
                            Console.SetCursorPosition(35, 10); Console.WriteLine("EDAD              :            [                                          ]");
                            Console.SetCursorPosition(35, 11); Console.WriteLine("DIAGNOSTICO       :            [                                          ]");
                            Console.SetCursorPosition(35, 12); Console.WriteLine("ID PACIENTE       :            [                                          ]");
                            Console.SetCursorPosition(25, 13); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            DatoPaciente lObjPacienteUltimo = new DatoPaciente();
                            //lObjPacienteUltimo = LobjDatosPaciente.Peek();
                            lintIdExpedienteUltimo = lObjPacienteUltimo.lintIdExpediente + 1;

                            Console.SetCursorPosition(70, 8); Console.WriteLine(lintIdExpedienteUltimo);
                            Console.SetCursorPosition(70, 9); lObjDato.lStrNombrePaciente = Console.ReadLine();
                            Console.SetCursorPosition(70, 10); lObjDato.lintEdad = int.Parse(Console.ReadLine());
                            Console.SetCursorPosition(70, 11); lObjDato.lstrDiagnostico = Console.ReadLine();
                            Console.SetCursorPosition(70, 12); lObjDato.lintIdPaciente = int.Parse(Console.ReadLine());
                            lObjDato.lintIdExpediente = lintIdExpedienteUltimo;
                            LobjDatosPaciente.Push(lObjDato);
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
                        StrTitulo = "PASAR PACIENTE";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine(StrTitulo);
                        Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                        Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 8); Console.WriteLine("ID EXPEDIENTE       :            [                                          ]");
                        Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE PACIENTE  :            [                                          ]");
                        Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                        Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 15); Console.WriteLine("DIAGNOSTICO        :        [                                          ]");
                        Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        lObjDato = new DatoPaciente();
                        lObjDato = LobjDatosPaciente.Peek();
                        Console.SetCursorPosition(70, 8); Console.WriteLine(lObjDato.lintIdExpediente);
                        Console.SetCursorPosition(70, 9); Console.WriteLine(lObjDato.lStrNombrePaciente);
                        Console.SetCursorPosition(70, 15); Console.WriteLine(lObjDato.lstrDiagnostico);
                        Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA PASAR A ESTE PACIENTE S/N:                  [  ]");
                        Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                        if (lStrDeseaContinuar.ToUpper() == "S")
                        {
                            LobjDatosPaciente.Pop();
                        }

                        Console.ReadKey();

                        break;
                    case ConsoleKey.D2:
                        //quitar elemento de  la colas .
                        Console.Clear(); //Limpiar la pantalla
                        Console.SetCursorPosition(0, 3);
                        StrTitulo = "PASAR PACIENTE";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine(StrTitulo);
                        Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                        Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 8); Console.WriteLine("ID EXPEDIENTE       :            [                                          ]");
                        Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE PACIENTE  :            [                                          ]");
                        Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                        Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(35, 15); Console.WriteLine("DIAGNOSTICO        :        [                                          ]");
                        Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        lObjDato = new DatoPaciente();
                        lObjDato = LobjDatosPaciente.Peek();
                        Console.SetCursorPosition(70, 8); Console.WriteLine(lObjDato.lintIdExpediente);
                        Console.SetCursorPosition(70, 9); Console.WriteLine(lObjDato.lStrNombrePaciente);
                        Console.SetCursorPosition(70, 15); Console.WriteLine(lObjDato.lstrDiagnostico);
                        Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA PASAR A ESTE PACIENTE S/N:                  [  ]");
                        Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                        if (lStrDeseaContinuar.ToUpper() == "S")
                        {
                            LobjDatosPaciente.Pop();
                        }

                        Console.ReadKey();

                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear(); //Limpiar la pantalla
                        Console.SetCursorPosition(0, 3);
                        StrTitulo = "PACIENTES PENDIENTES DE PASAR ";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine(StrTitulo);
                        Console.SetCursorPosition(5, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(10, 6); Console.WriteLine("ID EXPEDIENTE   NOMBRE PACIENTE         EDAD      DIAGNOSTICO    ");
                        Console.SetCursorPosition(5, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        lIntNoLinea = 8;
                        foreach (DatoPaciente lObjPaciente in LobjDatosPaciente)
                        {
                            Console.SetCursorPosition(10, lIntNoLinea); Console.WriteLine(lObjPaciente.lintIdExpediente);
                            Console.SetCursorPosition(25, lIntNoLinea); Console.WriteLine(lObjPaciente.lStrNombrePaciente);
                            Console.SetCursorPosition(60, lIntNoLinea); Console.WriteLine(lObjPaciente.lintEdad);
                            Console.SetCursorPosition(70, lIntNoLinea); Console.WriteLine(lObjPaciente.lstrDiagnostico);
                            lIntNoLinea += 1;
                        }

                        Console.ReadKey();

                        break;
                    case ConsoleKey.D3:
                        Console.Clear(); //Limpiar la pantalla
                        Console.SetCursorPosition(0, 3);
                        StrTitulo = "PACIENTES PENDIENTES DE PASAR ";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine(StrTitulo);
                        Console.SetCursorPosition(5, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        Console.SetCursorPosition(10, 6); Console.WriteLine("ID EXPEDIENTE   NOMBRE PACIENTE         EDAD      DIAGNOSTICO    ");
                        Console.SetCursorPosition(5, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                        lIntNoLinea = 8;
                        foreach (DatoPaciente lObjPaciente in LobjDatosPaciente)
                        {
                            Console.SetCursorPosition(10, lIntNoLinea); Console.WriteLine(lObjPaciente.lintIdExpediente);
                            Console.SetCursorPosition(30, lIntNoLinea); Console.WriteLine(lObjPaciente.lStrNombrePaciente);
                            Console.SetCursorPosition(70, lIntNoLinea); Console.WriteLine(lObjPaciente.lintEdad);
                            Console.SetCursorPosition(80, lIntNoLinea); Console.WriteLine(lObjPaciente.lstrDiagnostico);
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
            Console.Title = "CLASE NO.10 EJERCICIO DE MENUS Y PILAS"; // Titulo de la pantalla.
            string StrTitulo = "CLASE NO.10 EJERCICIO DE MENUS Y PILAS";
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
            Console.SetCursorPosition(30, 09); Console.WriteLine("    1. Registrar  Paciente");
            Console.SetCursorPosition(30, 10); Console.WriteLine("    2. procesar  Paciente");
            Console.SetCursorPosition(30, 11); Console.WriteLine("    3. Ver Listado de Pacientes");
            Console.SetCursorPosition(30, 12); Console.WriteLine("    4. Salida [Esc]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(30, 14); Console.WriteLine("   ELIJA EL NÚMERO DE OPCIÓN [  ]          ");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(61, 14);
        }

    }
}
