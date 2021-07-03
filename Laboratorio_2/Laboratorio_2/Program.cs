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
                        lObjectProgram.SubEliminarEmpleado();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D6:
                        lObjectProgram.SubEliminarEmpleado();
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
//            Console.WriteLine("                6. MODIFICAR UN EMPLEADO");
            Console.WriteLine("                6. ELIMINAR REGISTRO");
            Console.WriteLine("                7. SALIDA [ESC]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                Elija una opcion: ");

        }
        public void SubAgregarPuesto()
        {
            //Declaracion de variables inicializadas.
            string lStrInformacion = string.Empty;
            string lStrCadena = string.Empty;
            int lIntIdPuesto = 0;
            bool lblnContinuaIngresando = true;
            string lStrDeseaContinuar = string.Empty;
            string lStrNombre = string.Empty;
            double lDblSueldo = 0;
            string lStrSeparador = "|";
            Console.Clear(); //Limpiar pantalla

            try
            {
                if (File.Exists("c:/tmp/puestos.txt")) //Verifica si el archivo existe en la direccion
                {
                    using (Stream ms = new MemoryStream()) //Guarda en memoria el espacio para los indices
                    {
                        using (Stream fs = new FileStream("c:/tmp/puestos.txt", FileMode.Open, FileAccess.Read))
                        {
                            fs.CopyTo(ms);
                        }

                        ms.Seek(0, SeekOrigin.Begin); //Especifica el comienzo
                        using (StreamReader sr = new StreamReader(ms))
                        {
                            while ((lStrCadena = sr.ReadLine()) != null) //Si tiene informacion
                            {
                                String[] lStrConjuntoDatos = lStrCadena.Split("|"); //Crea un vector donde guarda la informacion
                                lIntIdPuesto = int.Parse(lStrConjuntoDatos[0]); //Guarda el indice
                            }
                            lIntIdPuesto += 1; //Suma 1 cada vez que recorre el ciclo
                        }
                    }
                }
                else
                {
                    lIntIdPuesto = 1; //Si no encuentra ningun dato anterior, le coloca el valor 1
                }
                if (lIntIdPuesto != 0)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream("c:/tmp/puestos.txt", FileMode.Append))) //Abre el archivo en modo escritura
                    {
                        while (lblnContinuaIngresando == true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 3);
                            gStrTitulo = "INFORMACION A COMPLETAR DE PUESTO";
                            Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop); //Centrar el titulo
                            Console.WriteLine(gStrTitulo);

                            Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                            Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 8); Console.WriteLine("ID PUESTO       :         [             ]");
                            Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE PUESTO   :         [             ]");
                            Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                            Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 15); Console.WriteLine("SALARIO         :         [             ]");
                            Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(70, 8); Console.WriteLine(Convert.ToString(lIntIdPuesto).PadLeft(4, '0')); //Coloca ceros a la izquierda del registro
                            Console.SetCursorPosition(70, 9); lStrNombre = Console.ReadLine();
                            Console.SetCursorPosition(70, 15); lDblSueldo = double.Parse(Console.ReadLine());

                            Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N: ");
                            Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();

                            sw.Write(Convert.ToString(lIntIdPuesto).PadRight(4, ' ')); sw.Write(lStrSeparador); // Coloca espacios a la derecha del registro
                            sw.Write(lStrNombre.PadRight(30, ' ')); sw.Write(lStrSeparador);
                            sw.WriteLine(Convert.ToString(lDblSueldo).PadLeft(10, '0'));
                            if (lStrDeseaContinuar.ToUpper() == "N")
                            {
                                lblnContinuaIngresando = false;
                            }
                            lIntIdPuesto += 1;
                        }
                        sw.Close(); //Cierra el archivo.

                        Console.Write("      Presione una tecla para continuar...");
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
        public static bool FncValidaPuesto(int pIntPuesto)
        {
            bool lBlnResultado = false;
            string lStrCadena = string.Empty;
            int lIntPuestoRevision = 0;
            if (File.Exists("c:/tmp/puestos.txt"))
            {
                using (Stream ms = new MemoryStream())
                {
                    using (Stream fs = new FileStream("c:/tmp/puestos.txt", FileMode.Open, FileAccess.Read))
                    {
                        fs.CopyTo(ms);
                    }

                    ms.Seek(0, SeekOrigin.Begin);
                    using (StreamReader sr = new StreamReader(ms))
                    {
                        bool lBlnSeguir = false;
                        while ((lStrCadena = sr.ReadLine()) != null && (lBlnSeguir == false))
                        {
                            String[] lStrConjuntoDatos = lStrCadena.Split('|');
                            lIntPuestoRevision = int.Parse(lStrConjuntoDatos[0]);
                            if (lIntPuestoRevision == pIntPuesto)
                            {
                                lBlnResultado = true;
                                lBlnSeguir = true;
                            }
                        }
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
            string lStrSeparador = "|";
            Console.Clear();

            try
            {
                if (File.Exists("c:/tmp/empleado.txt"))
                {
                    using (Stream ms = new MemoryStream())
                    {
                        using (Stream fs = new FileStream("c:/tmp/empleado.txt", FileMode.Open, FileAccess.Read))
                        {
                            fs.CopyTo(ms);
                        }

                        ms.Seek(0, SeekOrigin.Begin);
                        using (StreamReader sr = new StreamReader(ms))
                        {
                            while ((lStrCadena = sr.ReadLine()) != null)
                            {
                                String[] lStrConjuntoDatos = lStrCadena.Split("|");
                                lIntIdEmpleado = int.Parse(lStrConjuntoDatos[0]);
                            }
                            lIntIdEmpleado += 1;
                        }
                    }
                }
                else
                {
                    lIntIdEmpleado = 1;
                }
                if (lIntIdEmpleado != 0)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream("c:/tmp/empleado.txt", FileMode.Append)))
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

                            sw.Write(Convert.ToString(lIntIdEmpleado).PadRight(4, ' ')); sw.Write(lStrSeparador);
                            sw.Write(lStrNombre.PadRight(30, ' ')); sw.Write(lStrSeparador);
                            sw.Write(lStrDireccion.PadRight(30, ' ')); sw.Write(lStrSeparador);
                            sw.Write(lStrTelefono.PadRight(30, ' ')); sw.Write(lStrSeparador);
                            sw.WriteLine(Convert.ToString(lIntIdPuesto).PadRight(4, ' '));

                            if (lStrDeseaContinuar.ToUpper() == "N")
                            {
                                lBlnContinuaIngresando = false;
                            }
                            lIntIdEmpleado += 1;
                            Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:       [  ]");
                            Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
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
            if (File.Exists("c:/tmp/puestos.txt"))
            {
                using (Stream ms = new MemoryStream())
                {
                    using (Stream fs = new FileStream("c:/tmp/puestos.txt", FileMode.Open, FileAccess.Read))
                    {
                        fs.CopyTo(ms);
                    }

                    ms.Seek(0, SeekOrigin.Begin);
                    using (StreamReader sr = new StreamReader(ms))
                    {
                        while ((lStrCadena = sr.ReadLine()) != null)
                        {
                            String[] lStrConjuntoDatos = lStrCadena.Split("|");
                            lObjPuesto.lIntPuesto = int.Parse(lStrConjuntoDatos[0]);
                            lObjPuesto.lStrNombrePuesto = Convert.ToString(lStrConjuntoDatos[1]);
                            lObjPuesto.lDblSueldo = double.Parse(lStrConjuntoDatos[2]);

                            lObjResultado.Add(lObjPuesto);
                        }
                    }
                }
            }
            return lObjResultado;
        }
        public void SubVerPlanillaLaboral()
        {
            Console.Clear(); //Limpiar la pantalla

            try
            {
                using (var sr = new StreamReader("c:/tmp/empleado.txt")) //Abrir el archivo
                {
                    string lStrCadena;
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

                    while ((lStrCadena = sr.ReadLine()) != null)
                    {
                        String[] lStrConjuntoDatos = lStrCadena.Split("|");
                        string lStrPuesto = string.Empty;

                        double lDblCuotaPatronal = 0.00;
                        double lDblSalarioLiquido = 0.00;
                        Console.SetCursorPosition(5, lIntLinea); Console.Write(lStrConjuntoDatos[1]);
                        foreach (PlanillaLaboral lObjPuesto in lObjPuestos)
                        {
                            if (lObjPuesto.lIntPuesto == int.Parse(lStrConjuntoDatos[4]))
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

            try
            {
                string lStrSeparador = "|";
                StreamWriter lObjArchivoFinal;
                using (var sr = new StreamReader("c:/tmp/puestos.txt"))
                {
                    lObjArchivoFinal = File.CreateText("c:/tmp/tmp.txt");
                    string lStrCadena;
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

                    while ((lStrCadena = sr.ReadLine()) != null)
                    {
                        String[] lStrConjuntoDatos = lStrCadena.Split("|");
                        double lDblAumento;
                        double lDblNuevoSalario;

                        Console.SetCursorPosition(5, lIntLinea); Console.Write(lStrConjuntoDatos[0]);
                        Console.SetCursorPosition(15, lIntLinea); Console.Write(lStrConjuntoDatos[1]);
                        lDblAumento = double.Parse(lStrConjuntoDatos[2]) * 0.05;
                        lDblNuevoSalario = double.Parse(lStrConjuntoDatos[2]) + lDblAumento;
                        Console.SetCursorPosition(38, lIntLinea); Console.Write(double.Parse(lStrConjuntoDatos[2]).ToString("N2"));
                        Console.SetCursorPosition(56, lIntLinea); Console.Write(lDblAumento.ToString("N2"));
                        Console.SetCursorPosition(67, lIntLinea); Console.Write(lDblNuevoSalario.ToString("N2"));
                        lObjArchivoFinal.Write(Convert.ToString(lStrConjuntoDatos[0]).PadRight(4, ' ')); lObjArchivoFinal.Write(lStrSeparador);
                        lObjArchivoFinal.Write(lStrConjuntoDatos[1].PadRight(30, ' ')); lObjArchivoFinal.Write(lStrSeparador);
                        lObjArchivoFinal.WriteLine(Convert.ToString(lDblNuevoSalario).PadLeft(10, '0'));
                        lIntLinea += 1;
                    }
                    sr.Close();
                    lObjArchivoFinal.Close();
                    File.Delete("c:/tmp/puestos.txt");
                    File.Move("c:/tmp/tmp.txt", "c:/tmp/puestos.txt");
                }
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
            string lStrNombreEmpleado;
            bool encontrado = false;
            string lStrSeparador = "|";
            int lIntLinea = 5;

            try
            {
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


                while ((cadena = leer.ReadLine()) != null && encontrado == false)
                {
                    string[] lStrRegistrosArchivos = cadena.Split(lStrSeparador);
                    

                    if (lStrNombreEmpleado == lStrRegistrosArchivos[1].Trim())
                    {
                        double lDblCuotaPatronal = 0.00;
                        double lDblSalarioLiquido = 0.00;
                        encontrado = true;
                        gStrTitulo = "DATOS ACTUALES DEL EMPLEADO";
                        Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                        foreach (PlanillaLaboral lObjPuesto in lObjPuestos)
                        {
                            if (lObjPuesto.lIntPuesto == int.Parse(lStrRegistrosArchivos[4]))
                            {
                                Console.SetCursorPosition(7, lIntLinea); Console.Write(lStrRegistrosArchivos[1]);
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
                if (cadena == null && encontrado == false)
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
            }
            catch (Exception e)
            {

                Console.WriteLine("Por favor revisar, no se pudo realizar la accion debido a un inconveniente" + e.Message);
            }


        }
        public void SubModificarEmpleado()
        {
            Console.Clear();
            StreamReader leer;
            StreamWriter escribir;
            string cadena = string.Empty;
            string respuesta = string.Empty;
            int lIntIDEmpleado = 0;
            bool encontrado = false;
            string lStrSeparador = "|";

            if (File.Exists("c:/tmp/tmp.txt"))
            {
                File.Delete("c:/tmp/tmp.txt");
            }

            try
            {
                leer = File.OpenText("c:/tmp/empleado.txt");
                escribir = File.CreateText("c:/tmp/tmp.txt");


                while ((cadena = leer.ReadLine()) != null && encontrado == false)
                {
                    Console.Write("Por favor ingrese el ID del Empleado que desee modificar: ");
                    lIntIDEmpleado = int.Parse(Console.ReadLine());
                    string[] lStrCadenaRegistros = cadena.Split(lStrSeparador);

                    if (lIntIDEmpleado == int.Parse(lStrCadenaRegistros[0]))
                    {
                        Console.WriteLine("********************************************************");
                        Console.WriteLine("ID    : " + lStrCadenaRegistros[0]);
                        Console.WriteLine("NOMBRE: " + lStrCadenaRegistros[1]);
                        Console.WriteLine("DIRECCION: " + lStrCadenaRegistros[2]);
                        Console.WriteLine("TELEFONO: " + lStrCadenaRegistros[3]);
                        Console.WriteLine("PUESTO: " + lStrCadenaRegistros[4]);
                        Console.WriteLine("********************************************************");
                        Console.WriteLine("Es el registro que buscabas? (S/N)");
                        respuesta = Console.ReadLine();
                        if(respuesta.ToUpper() == "S")
                        {
                            Console.Clear();
                            string lStrNombreEmpleado = string.Empty, lStrDireccion = string.Empty, lStrTelefono = string.Empty;
                            int lIntIdPuesto = 0;

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

                            escribir.Write(Convert.ToString(lIntIDEmpleado).PadRight(4, ' ')); escribir.Write(lStrSeparador);
                            escribir.Write(lStrNombreEmpleado.PadRight(30, ' ')); escribir.Write(lStrSeparador);
                            escribir.Write(lStrDireccion.PadRight(30, ' ')); escribir.Write(lStrSeparador);
                            escribir.Write(lStrTelefono.PadRight(30, ' ')); escribir.Write(lStrSeparador);
                            escribir.WriteLine(Convert.ToString(lIntIdPuesto).PadRight(4, ' '));

                        }
                        else
                        {
                            escribir.WriteLine(cadena);
                        }
                    }
                    else
                    {
                        escribir.WriteLine(cadena);
                    }
                }
                leer.Close();
                escribir.Close();

                File.Delete("c:/tmp/empleado.txt");
                File.Move("c:/tmp/tmp.txt", "c:/tmp/empleado.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Favor validar lo que esta registrando " + e.Message);
            }
        }
        public void SubEliminarEmpleado()
        {
            Console.Clear();
            StreamReader leer;
            StreamWriter escribir;
            bool encontrado = false;
            string cadena;
            int lIntIDEmpleado = 0;
            string lStrSeparador = "|";

            try
            {
                leer = File.OpenText("c:/tmp/empleado.txt");
                escribir = File.CreateText("c:/tmp/tmp.txt");
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                gStrTitulo = "ELIMINAR EMPLEADO";
                Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                Console.WriteLine(gStrTitulo);
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.Write("                    Por favor ingrese el ID del empleado a eliminar: ");
                lIntIDEmpleado = int.Parse(Console.ReadLine());

                while ((cadena = leer.ReadLine()) != null)
                {
                    string[] lStrCadenaRegistro = cadena.Split(lStrSeparador);

                    if (lIntIDEmpleado == int.Parse(lStrCadenaRegistro[0]))
                    {
                        
                        Console.WriteLine("Registro eliminado");
                        encontrado = true;
                    }
                    else
                    {
                        escribir.WriteLine(cadena);
                        encontrado = false;
                    }
                }
                if (cadena == null && encontrado == false)
                {
                    Console.WriteLine("No existe el registro y no puede ser eliminado.");
                    escribir.WriteLine(cadena);
                }
                leer.Close();
                escribir.Close();

                File.Delete("c:/tmp/empleado.txt");
                File.Move("c:/tmp/tmp.txt", "c:/tmp/empleado.txt");

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR CON LA INTERACCION CON EL ARCHIVO " + e.Message);
            }
        }
    }
}