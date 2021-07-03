using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Laboratorio_2
{
    class Program
    {
        string gStrTitulo = string.Empty;
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;
            Program lObjectProgram = new Program();

            do
            {
                lObjectProgram.SubMenuPrincipal();
                op = Console.ReadKey(true);

                switch (op.Key)
                {
                    case ConsoleKey.NumPad1:
                        lObjectProgram.SubAgregarPuesto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D1:
                        lObjectProgram.SubAgregarPuesto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad2:
                        lObjectProgram.SubAgregarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2:
                        lObjectProgram.SubAgregarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad3:
                        lObjectProgram.SubVerPlanillaLaboral();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3:
                        lObjectProgram.SubVerPlanillaLaboral();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad4:
                        lObjectProgram.SubAumentoSueldo();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D4:
                        lObjectProgram.SubAumentoSueldo();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad5:
                        lObjectProgram.SubBuscarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D5:
                        lObjectProgram.SubBuscarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                            case ConsoleKey.NumPad6:
                        lObjectProgram.SubModificarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D6:
                        lObjectProgram.SubModificarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad7:
                        lObjectProgram.SubEliminarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D7:
                        lObjectProgram.SubEliminarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad8:
                        lObjectProgram.SubEliminarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D8:
                        lObjectProgram.SubEliminarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Saliendo del sistema");
                        break;
                    default:
                        Console.WriteLine("Selecciona una opcion correcta");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (op.Key != ConsoleKey.Escape);
        }
        public void SubMenuPrincipal()
        {
            gStrTitulo = "MENU PRINCIPAL";
            Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
            Console.WriteLine(gStrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.WriteLine("                CURSO: PROGRAMACION 1");
            Console.WriteLine("                NOMBRE: JAVIER CIFUENTES");
            Console.WriteLine("                CARNE: 0900-20-6600");
            Console.WriteLine("                SECCION: B");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                1. INSERTAR PUESTO");
            Console.WriteLine("                2. INSERTAR EMPLEADO");
            Console.WriteLine("                3. VER PLANILLA LABORAL");
            Console.WriteLine("                4. AUMENTAR EL 5% AL SALARIO");
            Console.WriteLine("                5. BUSCAR UN EMPLEADO");
            Console.WriteLine("                6. MODIFICAR UN EMPLEADO");
            Console.WriteLine("                7. ELIMINAR REGISTRO");
            Console.WriteLine("                8. SALIDA [ESC]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                Elija una opcion: ");

        }
        public void SubAgregarPuesto()
        {
            string lStrInformacion = string.Empty;
            String lstrCadena = string.Empty;
            int lintIdPuesto = 0;
            Boolean lblnContinuaIngresando = true;
            String lStrDeseaContinuar = string.Empty;
            string lStrNombre = string.Empty;
            double lDblSueldo = 0;
            string lStrSeparador = "|";
            BinaryWriter lObjEscribir;
            BinaryReader lobjLeer;
            Console.Clear(); //Limpiar la pantalla                       
            try
            {
                if (File.Exists("c:/tmp/binario/puestos.txt"))
                {
                    FileStream fs = new FileStream("c:/tmp/binario/puestos.txt", FileMode.Open, FileAccess.Read);
                    lobjLeer = new BinaryReader(fs);
                    while (fs.Position != fs.Length)
                    {
                        lintIdPuesto = lobjLeer.ReadInt32();
                        lobjLeer.ReadString();
                        lobjLeer.ReadDouble();
                    }
                    lintIdPuesto += 1;
                    lobjLeer.Close();
                }
                else
                {
                    lintIdPuesto = 1;
                }
                if (lintIdPuesto != 0)
                {
                    using (FileStream sw = new FileStream("c:/tmp/binario/puestos.txt", FileMode.Append))
                    {
                        while (lblnContinuaIngresando == true)
                        {
                            Console.Clear(); //Limpiar la pantalla
                            Console.SetCursorPosition(0, 3);
                            string StrTitulo = "INFORMACION A COMPLETAR DEL PUESTOS";
                            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                            Console.WriteLine(StrTitulo);
                            Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                            Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 8); Console.WriteLine("ID PUESTO       :            [                                          ]");
                            Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE PUESTO   :            [                                          ]");
                            Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                            Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 15); Console.WriteLine("SALARIO        :        [                                          ]");
                            Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(70, 8); Console.WriteLine(Convert.ToString(lintIdPuesto).PadLeft(4, '0'));
                            Console.SetCursorPosition(70, 9); lStrNombre = Console.ReadLine();
                            Console.SetCursorPosition(70, 15); lDblSueldo = double.Parse(Console.ReadLine());
                            Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:        [  ]");
                            Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                            lObjEscribir = new BinaryWriter(sw);
                            lObjEscribir.Write(lintIdPuesto);
                            lObjEscribir.Write(lStrNombre);
                            lObjEscribir.Write(lDblSueldo);
                            lObjEscribir.Close();
                            if (lStrDeseaContinuar.ToUpper() == "N")
                            {
                                lblnContinuaIngresando = false;
                            }
                            lintIdPuesto += 1;
                        }

                        sw.Close();
                        //Cerrar el archivo
                        Console.Write("            Presione una tecla para continuar...");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR EN INTERACCION CON ARCHIVO: " + e.Message);
            }
            finally
            {
            }
        }
        public static bool FncValidaPuesto(int pIntPuesto)
        {
            bool lBlnResultado = false;
            string lStrCadena = string.Empty;
            int lIntPuestoRevision = 0;
            BinaryReader lObjLeer;
            if (File.Exists("c:/tmp/binario/puestos.txt"))
            {
                FileStream fs = new FileStream("c:/tmp/binario/puestos.txt", FileMode.Open, FileAccess.Read);
                lObjLeer = new BinaryReader(fs);

                bool lBlnSeguir = false;
                while (fs.Position != fs.Length && (lBlnSeguir == false))
                {
                    lIntPuestoRevision = lObjLeer.ReadInt32();
                    lObjLeer.ReadString();
                    lObjLeer.ReadDouble();
                    if (lIntPuestoRevision == pIntPuesto)
                    {
                        lBlnResultado = true;
                        lBlnSeguir = true;
                    }
                }
            }
            else
            {
                lBlnResultado = false;
            }
            return lBlnResultado;
        }
        public void SubAgregarEmpleado()
        {
            string lStrInformacion = string.Empty;
            string lStrCadena = string.Empty;
            int lIntIdEmpleado = 0;
            int lIntIdPuesto = 0;
            bool lBlnContinuaIngresando = true;
            string lStrDeseaContinuar = string.Empty;
            string lStrNombre = string.Empty;
            string lStrDireccion = string.Empty;
            string lStrTelefono = String.Empty;
            BinaryWriter lObjEscribir;
            BinaryReader lObjLeer;
            Console.Clear();

            try
            {
                if (File.Exists("c:/tmp/binario/empleado.txt"))
                {
                    FileStream fs = new FileStream("c:/tmp/binario/empleado.txt", FileMode.Open, FileAccess.Read);
                    lObjLeer = new BinaryReader(fs);

                    while (fs.Position != fs.Length)
                    {
                        lIntIdEmpleado = lObjLeer.ReadInt32();
                        lObjLeer.ReadString();
                        lObjLeer.ReadString();
                        lObjLeer.ReadString();
                        lObjLeer.ReadInt32();
                    }
                    lIntIdEmpleado += 1;
                    lObjLeer.Close();
                }
                else
                {
                    lIntIdEmpleado = 1;
                }
                if (lIntIdEmpleado != 0)
                {
                    using (FileStream sw = new FileStream("c:/tmp/binario/empleado.txt", FileMode.Append))
                    {
                        while (lBlnContinuaIngresando == true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 3);
                            gStrTitulo = "INFORMACION A COMPLETAR DEL EMPLEADO";
                            Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                            Console.WriteLine(gStrTitulo);

                            Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES");
                            Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 8); Console.WriteLine("ID EMPLEADO      :          [                ]");
                            Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE EMPLEADO  :          [                ]");
                            Console.SetCursorPosition(35, 10); Console.WriteLine("DIRECCION       :          [                ]");
                            Console.SetCursorPosition(35, 11); Console.WriteLine("TELEFONO        :          [                ]");
                            Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                            Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 15); Console.WriteLine("ID PUESTO       :          [                ]");
                            Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(70, 8); Console.WriteLine(Convert.ToString(lIntIdEmpleado).PadLeft(4, '0'));
                            Console.SetCursorPosition(70, 9); lStrNombre = Console.ReadLine();
                            Console.SetCursorPosition(70, 10); lStrDireccion = Console.ReadLine();
                            Console.SetCursorPosition(70, 11); lStrTelefono = Console.ReadLine();
                            Console.SetCursorPosition(70, 15); lIntIdPuesto = int.Parse(Console.ReadLine());
                            bool blnValidar = false;
                            blnValidar = FncValidaPuesto(lIntIdPuesto);
                            while (blnValidar == false)
                            {
                                Console.SetCursorPosition(35, 22); Console.WriteLine("EL ID NO EXISTE");
                                Console.SetCursorPosition(70, 15); Console.WriteLine("            ");
                                Console.SetCursorPosition(70, 15); lIntIdPuesto = int.Parse(Console.ReadLine());
                                blnValidar = FncValidaPuesto(lIntIdPuesto);
                            }

                            lObjEscribir = new BinaryWriter(sw);
                            lObjEscribir.Write(lIntIdEmpleado);
                            lObjEscribir.Write(lStrNombre);
                            lObjEscribir.Write(lStrDireccion);
                            lObjEscribir.Write(lStrTelefono);
                            lObjEscribir.Write(lIntIdPuesto);
                            lObjEscribir.Close();

                            lIntIdEmpleado += 1;
                            Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:       [  ]");
                            Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                            if (lStrDeseaContinuar.ToUpper() == "N")
                            {
                                lBlnContinuaIngresando = false;
                            }
                        }

                        sw.Close(); //Cerrar el archivo

                        Console.Write("            Presione una tecla para continuar...");
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR EN INTERACCION CON ARCHIVO: ", e.Message);
            }
            finally
            {

            }
        }
        public struct PlanillaLaboral
        {
            public int lIntPuesto;
            public string lStrNombrePuesto;
            public double lDblSueldo;
        };
        static List<PlanillaLaboral> FncObtenerPuesto()
        {
            string lStrCadena = string.Empty;

            var lObjResultado = new List<PlanillaLaboral>();
            PlanillaLaboral lObjPuesto;
            BinaryReader lObjLeer;

            if (File.Exists("c:/tmp/puestos.txt"))
            {
                FileStream fs = new FileStream("c:/tmp/binario/puestos.txt", FileMode.Open, FileAccess.Read);
                lObjLeer = new BinaryReader(fs);

                while (fs.Position != fs.Length)
                {
                    lObjPuesto.lIntPuesto = lObjLeer.ReadInt32();
                    lObjPuesto.lStrNombrePuesto = lObjLeer.ReadString();
                    lObjPuesto.lDblSueldo = lObjLeer.ReadDouble();
                    lObjResultado.Add(lObjPuesto);
                }
            }
            return lObjResultado;
        }
        public void SubVerPlanillaLaboral()
        {
            Console.Clear(); //Limpiar la pantalla
            BinaryReader lObjLeer;
            
            try
            {
                using (FileStream fs = new FileStream("c:/tmp/binario/empleado.txt", FileMode.Open, FileAccess.Read)) //Abrir el archivo
                {
                    
                    int lIntLinea = 9;
                    Console.Clear();
                    Console.SetCursorPosition(0, 3);
                    gStrTitulo = "PLANILLA LABORAL";
                    Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                    Console.WriteLine(gStrTitulo);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    gStrTitulo = "DETALLE";
                    Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                    Console.WriteLine(gStrTitulo);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.WriteLine("      Nombre Empleado          Nombre Puesto            Sueldo        Cuota Patronal      Sueldo Liquido");
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));

                    List<PlanillaLaboral> lObjPuestos = FncObtenerPuesto();

                    lObjLeer = new BinaryReader(fs);

                    while (fs.Position != fs.Length)
                    {
                        string lStrPuesto = string.Empty;

                        double lDblCuotaPatronal = 0.00;
                        double lDblSalarioLiquido = 0.00;
                        lObjLeer.ReadInt32();
                        Console.SetCursorPosition(5, lIntLinea); Console.Write(lObjLeer.ReadString());
                        lObjLeer.ReadString();
                        lObjLeer.ReadString();
                        int lIntPuestoTemp = 0;
                        lIntPuestoTemp = lObjLeer.ReadInt32();
                        foreach (PlanillaLaboral lObjPuesto in lObjPuestos)
                        {
                            if (lObjPuesto.lIntPuesto == lIntPuestoTemp)
                            {
                                Console.SetCursorPosition(37, lIntLinea); Console.Write(lObjPuesto.lStrNombrePuesto);
                                Console.SetCursorPosition(57, lIntLinea); Console.Write(lObjPuesto.lDblSueldo.ToString("N2"));
                                lDblCuotaPatronal = lObjPuesto.lDblSueldo * 0.0483;
                                lDblSalarioLiquido = lObjPuesto.lDblSueldo - lDblCuotaPatronal;
                                Console.SetCursorPosition(70, lIntLinea); Console.Write(lDblCuotaPatronal.ToString("N2"));
                                Console.SetCursorPosition(90, lIntLinea); Console.Write(lDblSalarioLiquido.ToString("N2"));
                                lIntLinea += 1;
                                break;
                            }
                        }
                    }
                    lObjLeer.Close();
                    Console.WriteLine("\n");
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR CON LA INTERACCION DEL ARCHIVO", e.Message);
            }
        }
        public void SubAumentoSueldo()
        {
            Console.Clear();
            BinaryReader lObjLeer;
            BinaryWriter lObjEscribir;

            try
            {
                using (FileStream fs = new FileStream("c:/tmp/binario/puestos.txt", FileMode.Open, FileAccess.Read))
                {
                    FileStream sw = new FileStream("c:/tmp/binario/tmp.txt", FileMode.Append);
                    
                    int lIntLinea = 9;
                    Console.Clear();
                    Console.SetCursorPosition(0, 3);
                    gStrTitulo = "PLANILLA LABORAL";
                    Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                    Console.WriteLine(gStrTitulo);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    gStrTitulo = "AUMENTO SALARIO";
                    Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                    Console.WriteLine(gStrTitulo);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.WriteLine("      ID       Nombre Puesto         Sueldo        Aumento         Nuevo Salario");
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));

                    lObjLeer = new BinaryReader(fs);
                    lObjEscribir = new BinaryWriter(sw);
                    int lIntPuesto = 0;
                    string lStrNombrePuesto = "";
                    Double lDblSalarioActual = 0;

                    while (fs.Position != fs.Length)
                    {
                        double lDblAumento;
                        double lDblNuevoSalario;
                        lIntPuesto = lObjLeer.ReadInt32();
                        lStrNombrePuesto = lObjLeer.ReadString();
                        lDblSalarioActual = lObjLeer.ReadDouble();
                        Console.SetCursorPosition(5, lIntLinea); Console.Write(lIntPuesto);
                        Console.SetCursorPosition(15, lIntLinea); Console.Write(lStrNombrePuesto);
                        lDblAumento = lDblSalarioActual * 0.05;
                        lDblNuevoSalario = lDblSalarioActual + lDblAumento;
                        Console.SetCursorPosition(38, lIntLinea); Console.Write(lDblSalarioActual.ToString("N2"));
                        Console.SetCursorPosition(56, lIntLinea); Console.Write(lDblAumento.ToString("N2"));
                        Console.SetCursorPosition(67, lIntLinea); Console.Write(lDblNuevoSalario.ToString("N2"));

                        lObjEscribir.Write(lIntPuesto);
                        lObjEscribir.Write(lStrNombrePuesto);
                        lObjEscribir.Write(lDblNuevoSalario);

                        lIntLinea += 1;
                    }
                    sw.Close();
                }
                lObjEscribir.Close();
                lObjLeer.Close();

                File.Delete("c:/tmp/binario/puestos.txt");
                File.Move("c:/tmp/binario/tmp.txt", "c:/tmp/binario/puestos.txt");
                Console.WriteLine("\n");
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR AL INTERACTUAR CON EL ARCHIVO ", e.Message);
            }
        }
        public void SubBuscarEmpleado()
        {
            Console.Clear();
            StreamReader leer;
            BinaryReader lObjLeer;
            string lStrNombreEmpleado;
            bool encontrado = false;
            string lStrSeparador = "|";
            int lIntLinea = 5;

            try
            {
                FileStream fs = new FileStream("c:/tmp/binario/empleado.txt", FileMode.Open, FileAccess.Read);
                lObjLeer = new BinaryReader(fs);
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                gStrTitulo = "BUSCAR EMPLEADO";
                Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                Console.WriteLine(gStrTitulo);
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                leer = File.OpenText("c:/tmp/empleado.txt"); //Abro el archivo
                Console.Write("Por favor digite el nombre del empleado a buscar: ");
                lStrNombreEmpleado = Console.ReadLine();
                string cadena;
                Console.Clear();
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                gStrTitulo = "DATOS DEL EMPLEADO";
                Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                Console.WriteLine(gStrTitulo);
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.WriteLine("      Nombre Empleado          Nombre Puesto            Sueldo        Cuota Patronal      Sueldo Liquido");
                List<PlanillaLaboral> lObjPuestos = FncObtenerPuesto();

                int lIntIdEmpleado = 0;
                string lStrNombre = string.Empty;
                string lStrDireccion = string.Empty;
                string lStrTelefono = string.Empty;
                int lIntIdPuesto = 0;

                while (fs.Position != fs.Length && encontrado == false)
                {
                    lIntIdEmpleado = lObjLeer.ReadInt32();
                    lStrNombre = lObjLeer.ReadString();
                    lStrDireccion = lObjLeer.ReadString();
                    lStrTelefono = lObjLeer.ReadString();
                    lIntIdPuesto = lObjLeer.ReadInt32();


                    if (lStrNombreEmpleado == lStrNombre)
                    {
                        double lDblCuotaPatronal = 0.00;
                        double lDblSalarioLiquido = 0.00;
                        encontrado = true;
                        gStrTitulo = "DATOS ACTUALES DEL EMPLEADO";
                        Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                        foreach (PlanillaLaboral lObjPuesto in lObjPuestos)
                        {
                            if (lObjPuesto.lIntPuesto == lIntIdPuesto)
                            {
                                Console.SetCursorPosition(5, lIntLinea); Console.Write(lStrNombre);
                                Console.SetCursorPosition(33, lIntLinea); Console.Write(lObjPuesto.lStrNombrePuesto);
                                Console.SetCursorPosition(57, lIntLinea); Console.Write(lObjPuesto.lDblSueldo.ToString("N2"));
                                lDblCuotaPatronal = lObjPuesto.lDblSueldo * 0.0483;
                                lDblSalarioLiquido = lObjPuesto.lDblSueldo - lDblCuotaPatronal;
                                Console.SetCursorPosition(70, lIntLinea); Console.Write(lDblCuotaPatronal.ToString("N2"));
                                Console.SetCursorPosition(90, lIntLinea); Console.Write(lDblSalarioLiquido.ToString("N2"));
                                Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                                lIntLinea += 1;
                                break;
                            }
                        }
                    }
                }
                if (fs.Position == fs.Length && encontrado == false)
                {
                    Console.Clear();
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    gStrTitulo = "BUSCAR EMPLEADO";
                    Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                    Console.WriteLine(gStrTitulo);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.WriteLine("No se encontro el registro");
                    Console.Write("\n\nPresione una tecla para continuar...");
                }
                leer.Close();
                lObjLeer.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine("Por favor revisar, no se pudo realizar la accion debido a un inconveniente" + e.Message);
            }


        }
        public void SubModificarEmpleado()
        {
            Console.Clear();
            StreamReader lObjLeer;
            StreamWriter lObjEscribir;
            BinaryReader lObjLeerBinario;
            BinaryWriter lObjEscribirBinario;
            string cadena = string.Empty;
            string respuesta = string.Empty;
            int lIntIDEmpleado = 0;
            bool encontrado = false;
            string lStrSeparador = "|";

            try
            {
                using (FileStream fs = new FileStream("c:/tmp/binario/empleado.txt", FileMode.Open, FileAccess.Read))
                {
                    FileStream sw = new FileStream("c:/tmp/binario/tmp.txt", FileMode.Append);
                    
                    lObjLeerBinario = new BinaryReader(fs);
                    lObjEscribirBinario = new BinaryWriter(sw);
                    int lIntIdEmpleado = 0;
                    string lStrNombreEmpleado = "";
                    string lStrDireccionEmpleado = "";
                    string lStrTelefonoEmpleado = "";
                    int lIntIdPuestoEmpleado = 0;

                    Console.Write("Por favor ingrese el ID del Empleado que desee modificar: ");
                    lIntIDEmpleado = int.Parse(Console.ReadLine());

                    while (fs.Position != fs.Length)
                    {
                        int lIntCodigoEmpleado = 0;
                        lIntCodigoEmpleado = lObjLeerBinario.ReadInt32();

                        lStrNombreEmpleado = lObjLeerBinario.ReadString();
                        lStrDireccionEmpleado = lObjLeerBinario.ReadString();
                        lStrTelefonoEmpleado = lObjLeerBinario.ReadString();
                        lIntIdPuestoEmpleado = lObjLeerBinario.ReadInt32();

                        if (lIntIDEmpleado == lIntCodigoEmpleado)
                        {
                            encontrado = true;
                            Console.WriteLine("********************************************************");
                            Console.WriteLine("ID    : " + lIntIDEmpleado);
                            Console.WriteLine("NOMBRE: " + lStrNombreEmpleado);
                            Console.WriteLine("DIRECCION: " + lStrDireccionEmpleado);
                            Console.WriteLine("TELEFONO: " + lStrTelefonoEmpleado);
                            Console.WriteLine("PUESTO: " + lIntIdPuestoEmpleado);
                            Console.WriteLine("********************************************************");
                            Console.WriteLine("Es el registro que buscabas? (S/N)");
                            respuesta = Console.ReadLine();
                            if (respuesta.ToUpper() == "S")
                            {
                                Console.Clear();

                                Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                                Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES");
                                Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                                Console.SetCursorPosition(35, 8); Console.WriteLine("ID EMPLEADO      :          [                ]");
                                Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE EMPLEADO  :          [                ]");
                                Console.SetCursorPosition(35, 10); Console.WriteLine("DIRECCION       :          [                ]");
                                Console.SetCursorPosition(35, 11); Console.WriteLine("TELEFONO        :          [                ]");
                                Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                                Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                                Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                                Console.SetCursorPosition(35, 15); Console.WriteLine("ID PUESTO       :          [                ]");
                                Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                                Console.SetCursorPosition(70, 8); Console.WriteLine(Convert.ToString(lIntIDEmpleado).PadLeft(4, '0'));
                                Console.SetCursorPosition(70, 9); lStrNombreEmpleado = Console.ReadLine();
                                Console.SetCursorPosition(70, 10); lStrDireccionEmpleado = Console.ReadLine();
                                Console.SetCursorPosition(70, 11); lStrTelefonoEmpleado = Console.ReadLine();
                                Console.SetCursorPosition(70, 15); lIntIdPuestoEmpleado = int.Parse(Console.ReadLine());
                                bool blnValidar = false;
                                blnValidar = FncValidaPuesto(lIntIdPuestoEmpleado);
                                while (blnValidar == false)
                                {
                                    Console.SetCursorPosition(35, 22); Console.WriteLine("EL ID NO EXISTE");
                                    Console.SetCursorPosition(70, 15); Console.WriteLine("            ");
                                    Console.SetCursorPosition(70, 15); lIntIdPuestoEmpleado = int.Parse(Console.ReadLine());
                                    blnValidar = FncValidaPuesto(lIntIdPuestoEmpleado);
                                }

                                lObjEscribirBinario.Write(lIntIDEmpleado);
                                lObjEscribirBinario.Write(lStrNombreEmpleado);
                                lObjEscribirBinario.Write(lStrDireccionEmpleado);
                                lObjEscribirBinario.Write(lStrTelefonoEmpleado);
                                lObjEscribirBinario.Write(lIntIdPuestoEmpleado);

                            }
                            else
                            {
                                lObjEscribirBinario.Write(lIntIDEmpleado);
                                lObjEscribirBinario.Write(lStrNombreEmpleado);
                                lObjEscribirBinario.Write(lStrDireccionEmpleado);
                                lObjEscribirBinario.Write(lStrTelefonoEmpleado);
                                lObjEscribirBinario.Write(lIntIdPuestoEmpleado);
                            }
                        }
                        else
                        {
                            lObjEscribirBinario.Write(lIntIDEmpleado);
                            lObjEscribirBinario.Write(lStrNombreEmpleado);
                            lObjEscribirBinario.Write(lStrDireccionEmpleado);
                            lObjEscribirBinario.Write(lStrTelefonoEmpleado);
                            lObjEscribirBinario.Write(lIntIdPuestoEmpleado);
                        }
                    }
                    sw.Close();
                }
                lObjLeerBinario.Close();
                lObjEscribirBinario.Close();
                File.Delete("c:/tmp/binario/empleado.txt");
                File.Move("c:/tmp/binario/tmp.txt", "c:/tmp/binario/empleado.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Favor validar lo que esta registrando " + e.Message);
            }
        }
        public void SubEliminarEmpleado()
        {
            Console.Clear();
            StreamReader lObjLeer;
            StreamWriter lObjEscribir;
            BinaryReader lObjLeerBinario;
            BinaryWriter lObjEscribirBinario;
            bool encontrado = false;
            string cadena;
            int lIntIDEmpleado = 0;
            string lStrSeparador = "|";

            try
            {
                using (FileStream fs = new FileStream("c:/tmp/binario/empleado.txt", FileMode.Open, FileAccess.Read))
                {
                    FileStream sw = new FileStream("c:/tmp/binario/tmp.txt", FileMode.Append);
                    lObjLeerBinario = new BinaryReader(fs);
                    lObjEscribirBinario = new BinaryWriter(sw);

                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    gStrTitulo = "ELIMINAR EMPLEADO";
                    Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                    Console.WriteLine(gStrTitulo);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.Write("                    Por favor ingrese el ID del empleado a eliminar: ");
                    lIntIDEmpleado = int.Parse(Console.ReadLine());

                    int lIntIdEmpleadoTmp = 0;
                    string lStrNombreEmpleado = "";
                    string lStrDireccionEmpleado = "";
                    string lStrTelefonoEmpleado = "";
                    int lIntIdPuestoEmpleado = 0;

                    while (fs.Position != fs.Length)
                    {
                        lIntIdEmpleadoTmp = lObjLeerBinario.ReadInt32();
                        lStrNombreEmpleado = lObjLeerBinario.ReadString();
                        lStrDireccionEmpleado = lObjLeerBinario.ReadString();
                        lStrTelefonoEmpleado = lObjLeerBinario.ReadString();
                        lIntIdPuestoEmpleado = lObjLeerBinario.ReadInt32();

                        if (lIntIDEmpleado == lIntIdEmpleadoTmp)
                        {

                            Console.WriteLine("Registro eliminado");
                            encontrado = true;
                        }
                        else
                        {
                            lObjEscribirBinario.Write(lIntIDEmpleado);
                            lObjEscribirBinario.Write(lStrNombreEmpleado);
                            lObjEscribirBinario.Write(lStrDireccionEmpleado);
                            lObjEscribirBinario.Write(lStrTelefonoEmpleado);
                            lObjEscribirBinario.Write(lIntIdPuestoEmpleado);
                            encontrado = false;
                        }
                    }
                    if (fs == null && encontrado == false)
                    {
                        Console.WriteLine("No existe el registro y no puede ser eliminado.");
                        lObjEscribirBinario.Write(lIntIDEmpleado);
                        lObjEscribirBinario.Write(lStrNombreEmpleado);
                        lObjEscribirBinario.Write(lStrDireccionEmpleado);
                        lObjEscribirBinario.Write(lStrTelefonoEmpleado);
                        lObjEscribirBinario.Write(lIntIdPuestoEmpleado);
                    }
                    sw.Close();
                }
                
                lObjLeerBinario.Close();
                lObjEscribirBinario.Close();

                File.Delete("c:/tmp/binario/empleado.txt");
                File.Move("c:/tmp/binario/tmp.txt", "c:/tmp/binario/empleado.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR CON LA INTERACCION CON EL ARCHIVO " + e.Message);
            }
        }
    }
}
