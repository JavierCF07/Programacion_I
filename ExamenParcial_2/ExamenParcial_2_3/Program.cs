using System;
using System.IO;
using System.Linq;

namespace ExamenParcial_2_3
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
                        lObjectProgram.SubInsertarProducto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D1:
                        lObjectProgram.SubInsertarProducto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.I:
                        lObjectProgram.SubInsertarProducto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad2:
                        lObjectProgram.SubListarProductos();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2:
                        lObjectProgram.SubListarProductos();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.L:
                        lObjectProgram.SubListarProductos();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad3:
                        lObjectProgram.SubAumentarPrecio();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3:
                        lObjectProgram.SubAumentarPrecio();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.A:
                        lObjectProgram.SubAumentarPrecio();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad4:
                        lObjectProgram.SubBuscarProducto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D4:
                        lObjectProgram.SubBuscarProducto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.B:
                        lObjectProgram.SubBuscarProducto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad5:
                        lObjectProgram.SubEliminarProducto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D5:
                        lObjectProgram.SubEliminarProducto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        lObjectProgram.SubEliminarProducto();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad6:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("\nSaliendo del programa...");
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
            Console.WriteLine("                Examen Parcial II");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                1. INSERTAR PRODUCTO [I]");
            Console.WriteLine("                2. VER LISTADO DE PRODUCTOS [L]");
            Console.WriteLine("                3. AUMENTAR 5% AL PRECIO [A]");
            Console.WriteLine("                4. BUSCAR PRODUCTO [B]");
            Console.WriteLine("                5. ELIMINAR PRODUCTO [D]");
            Console.WriteLine("                6. SALIDA [ESC]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                Elija una opcion: ");
        }
        public void SubInsertarProducto()
        {
            Console.Clear();
            BinaryWriter lObjEscribir;
            BinaryReader lObjLeer;
            int lIntCodigoProducto = 0;
            string lStrDescripcionProducto = string.Empty;
            double lDblPrecio = 0;
            int lIntExistencia = 0;
            string lStrContinuarIngresando = string.Empty;
            bool lBlnContinuar = false;

            try
            {
                if (File.Exists("c:/tmp/binario/Productos.txt"))
                {
                    //Lee el archivo y le coloca la secuencia del codigo, esto para evitar duplicidad
                    FileStream fs = new FileStream("c:/tmp/binario/Productos.txt", FileMode.Open, FileAccess.Read);
                    lObjLeer = new BinaryReader(fs);

                    while (fs.Position != fs.Length)
                    {
                        lIntCodigoProducto = lObjLeer.ReadInt32();
                        lStrDescripcionProducto = lObjLeer.ReadString();
                        lDblPrecio = lObjLeer.ReadDouble();
                        lIntExistencia = lObjLeer.ReadInt32();
                    }
                    lIntCodigoProducto += 1; //Aumenta a 1 el codigo del producto si ya existen productos.
                    lObjLeer.Close();
                }
                else
                {
                    lIntCodigoProducto = 1; //Si no existen registros, le coloca la secuencia de 1;
                }

                if (lIntCodigoProducto != 0)
                {
                    
                    using (FileStream sw = new FileStream("c:/tmp/binario/Productos.txt", FileMode.Append, FileAccess.Write))
                    {
                        lObjEscribir = new BinaryWriter(sw);
                        do
                        {
                            lBlnContinuar = true;
                            Console.Clear(); //Limpiar la pantalla
                            Console.SetCursorPosition(0, 3);
                            string StrTitulo = "INFORMACION A COMPLETAR DEL PRODUCTO";
                            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                            Console.WriteLine(StrTitulo);
                            Console.SetCursorPosition(25, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 6); Console.WriteLine("DATOS GENERALES ");
                            Console.SetCursorPosition(25, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 8); Console.WriteLine("ID DEL PRODUCTO              :  [                             ]");
                            Console.SetCursorPosition(35, 9); Console.WriteLine("DESCRIPCION DEL PRODUCTO     :  [                             ]");
                            Console.SetCursorPosition(35, 10); Console.WriteLine("PRECIO                      :  [                             ]");
                            Console.SetCursorPosition(35, 11); Console.WriteLine("EXISTENCIA                  :  [                             ]");
                            Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(70, 8); Console.WriteLine(Convert.ToString(lIntCodigoProducto).PadLeft(4, '0'));
                            Console.SetCursorPosition(70, 9); lStrDescripcionProducto = Console.ReadLine();
                            Console.SetCursorPosition(70, 10); lDblPrecio = double.Parse(Console.ReadLine());
                            Console.SetCursorPosition(70, 11); lIntExistencia = int.Parse(Console.ReadLine());
                            Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:        [  ]");
                            Console.SetCursorPosition(90, 18); lStrContinuarIngresando = Console.ReadLine();
                            
                            lObjEscribir.Write(lIntCodigoProducto);
                            lObjEscribir.Write(lStrDescripcionProducto);
                            lObjEscribir.Write(lDblPrecio);
                            lObjEscribir.Write(lIntExistencia);
                            lIntCodigoProducto += 1;

                            if (lStrContinuarIngresando.ToUpper() == "N")
                            {
                                lBlnContinuar = false;
                            }
                        } while (lBlnContinuar == true);
                        lObjEscribir.Close();
                        sw.Close();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                    }
                    
                }
                
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Por favor revisar el codigo: " + e.Message + " " + e.StackTrace.Substring(e.StackTrace.Length -7, 7) );
            }
            finally
            {
                
            }
        }
        public void SubListarProductos()
        {
            Console.Clear();
            BinaryReader lObjLeer;

            using (FileStream fs = new FileStream("c:/tmp/binario/Productos.txt", FileMode.Open, FileAccess.Read))
            {
                lObjLeer = new BinaryReader(fs);
                int lIntLinea = 9;
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                gStrTitulo = "LISTADO DE PRODUCTOS";
                Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                Console.WriteLine(gStrTitulo);
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                gStrTitulo = "DETALLE";
                Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                Console.WriteLine(gStrTitulo);
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.WriteLine("     Código 	    Descripción	                      Precio		      Existencia       Utilidad");
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));

                int lIntCodigoProducto = 0;
                string lStrDescripcion = string.Empty;
                double lDblPrecio = 0;
                int lIntExistencia = 0;
                double lDblUtilidad = 0;

                while (fs.Position != fs.Length)
                {
                    lIntCodigoProducto = lObjLeer.ReadInt32();
                    lStrDescripcion = lObjLeer.ReadString();
                    lDblPrecio = lObjLeer.ReadDouble();
                    lIntExistencia = lObjLeer.ReadInt32();
                    Console.SetCursorPosition(6, lIntLinea); Console.Write(lIntCodigoProducto);
                    Console.SetCursorPosition(20, lIntLinea); Console.Write(lStrDescripcion);
                    Console.SetCursorPosition(54, lIntLinea); Console.Write(lDblPrecio.ToString("N2"));
                    Console.SetCursorPosition(78, lIntLinea); Console.Write(lIntExistencia);
                    lDblUtilidad = lDblPrecio * 0.11;
                    Console.SetCursorPosition(95, lIntLinea); Console.Write(lDblUtilidad.ToString("N2"));

                    lIntLinea += 1;
                }
                lObjLeer.Close();
                Console.WriteLine("\n");
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.WriteLine("\n\n     Pulse cualquier tecla para continuar...");
            }
        }
        public void SubAumentarPrecio()
        {
            Console.Clear();
            BinaryReader lObjLeer;
            BinaryWriter lObjEscribir;
            int lIntCodigoProducto = 0;
            string lStrDescripcionProducto = string.Empty;
            double lDblPrecio = 0;
            int lIntExistencia = 0;
            double lDblAumento = 0;
            double lDblNuevoSalario = 0;
            double lDblUtilidad = 0;

            try
            {
                using (FileStream fs = new FileStream("c:/tmp/binario/Productos.txt", FileMode.Open, FileAccess.Read))
                {
                    FileStream sw = new FileStream("c:/tmp/binario/tmp.txt", FileMode.Append);

                    lObjLeer = new BinaryReader(fs);
                    lObjEscribir = new BinaryWriter(sw);

                    int lIntLinea = 9;
                    Console.Clear();
                    Console.SetCursorPosition(0, 3);
                    gStrTitulo = "AUMENTO DEL PRECIO DEL 5%";
                    Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                    Console.WriteLine(gStrTitulo);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    gStrTitulo = "DETALLE";
                    Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                    Console.WriteLine(gStrTitulo);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.WriteLine("  Código 	    Descripción	               Precio      Aumento       Nuevo Salario     Existencia     Utilidad");
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));

                    while (fs.Position != fs.Length)
                    {
                        lIntCodigoProducto = lObjLeer.ReadInt32();
                        lStrDescripcionProducto = lObjLeer.ReadString();
                        lDblPrecio = lObjLeer.ReadDouble();
                        lIntExistencia = lObjLeer.ReadInt32();
                        Console.SetCursorPosition(3, lIntLinea); Console.Write(lIntCodigoProducto);
                        Console.SetCursorPosition(20, lIntLinea); Console.Write(lStrDescripcionProducto);
                        lDblAumento = lDblPrecio * 0.05;
                        lDblNuevoSalario = lDblPrecio + lDblAumento;
                        Console.SetCursorPosition(47, lIntLinea); Console.Write(lDblPrecio.ToString("N2"));
                        Console.SetCursorPosition(60, lIntLinea); Console.Write(lDblAumento.ToString("N2"));
                        Console.SetCursorPosition(74, lIntLinea); Console.Write(lDblNuevoSalario.ToString("N2"));
                        Console.SetCursorPosition(94, lIntLinea); Console.Write(lIntExistencia);
                        lDblUtilidad = lDblPrecio * 0.11;
                        Console.SetCursorPosition(107, lIntLinea); Console.Write(lDblUtilidad.ToString("N2"));

                        lObjEscribir.Write(lIntCodigoProducto);
                        lObjEscribir.Write(lStrDescripcionProducto);
                        lObjEscribir.Write(lDblNuevoSalario);
                        lObjEscribir.Write(lIntExistencia);

                        lIntLinea += 1;
                    }
                    Console.WriteLine();
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.WriteLine();
                    Console.WriteLine("Pulse cualquier tecla para continuar...");
                    sw.Close();
                }
                lObjLeer.Close();
                lObjEscribir.Close();

                File.Delete("c:/tmp/binario/Productos.txt");
                File.Move("c:/tmp/binario/tmp.txt", "c:/tmp/binario/Productos.txt");
            }
            catch (Exception e)
            {

                Console.WriteLine("Por favor revisar el codigo: "+ e.Message);
            }


        }
        public void SubBuscarProducto()
        {
            Console.Clear();
            BinaryReader lObjLeer;
            int lIntCodigoProducto = 0;
            string lStrDescripcionProducto = string.Empty;
            double lDblPrecio = 0;
            int lIntExistencia = 0;
            string respuesta = string.Empty;
            string lStrNombre = string.Empty;
            double lDblUtilidad = 0;
            bool encontrado = false;

            try
            {
                using (FileStream fs = new FileStream("c:/tmp/binario/Productos.txt", FileMode.Open, FileAccess.Read))
                {
                    lObjLeer = new BinaryReader(fs);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.SetCursorPosition(10, 2); Console.Write("Por favor escriba el nombre del producto: ");
                    Console.SetCursorPosition(53, 2); lStrNombre = Console.ReadLine();
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));

                    while (fs.Position != fs.Length)
                    {
                        lIntCodigoProducto = lObjLeer.ReadInt32();
                        lStrDescripcionProducto = lObjLeer.ReadString();
                        lDblPrecio = lObjLeer.ReadDouble();
                        lIntExistencia = lObjLeer.ReadInt32();

                        if (lStrDescripcionProducto == lStrNombre)
                        {
                            Console.WriteLine("********************************************************");
                            Console.WriteLine("ID        : " + lIntCodigoProducto);
                            Console.WriteLine("NOMBRE    : " + lStrDescripcionProducto);
                            Console.WriteLine("PRECIO    : " + lDblPrecio);
                            Console.WriteLine("EXISTENCIA: " + lIntExistencia);
                            Console.WriteLine("********************************************************");
                            Console.WriteLine("Es el registro que buscabas? (S/N)");
                            respuesta = Console.ReadLine();
                            if (respuesta.ToUpper() == "S")
                            {
                                encontrado = true;
                                int lIntLinea = 9;
                                Console.Clear();
                                Console.SetCursorPosition(0, 3);
                                gStrTitulo = "BUSCAR PRODUCTO";
                                Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                                Console.WriteLine(gStrTitulo);
                                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                                gStrTitulo = "DETALLE";
                                Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                                Console.WriteLine(gStrTitulo);
                                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                                Console.WriteLine("     Código 	    Descripción	                      Precio		      Existencia       Utilidad");
                                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                                Console.SetCursorPosition(6, lIntLinea); Console.Write(lIntCodigoProducto);
                                Console.SetCursorPosition(20, lIntLinea); Console.Write(lStrDescripcionProducto);
                                Console.SetCursorPosition(54, lIntLinea); Console.Write(lDblPrecio.ToString("N2"));
                                Console.SetCursorPosition(78, lIntLinea); Console.Write(lIntExistencia);
                                lDblUtilidad = lDblPrecio * 0.11;
                                Console.SetCursorPosition(95, lIntLinea); Console.Write(lDblUtilidad.ToString("N2"));
                                lIntLinea += 1;
                                break;
                            }
                        }

                    }
                    if (fs.Position == fs.Length && encontrado == false)
                        Console.WriteLine("NO EXISTE EL REGISTRO");
                    Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                    lObjLeer.Close();
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine("Por favor revisar el codigo: " + e.Message + " " + e.StackTrace.Substring(e.StackTrace.Length - 7, 7));
            }
           
        }
        public void SubEliminarProducto()
        {
            Console.Clear();
            BinaryReader lObjLeer;
            BinaryWriter lObjEscribir;
            int lIntCodigoProducto = 0;
            string lStrDescripcionProducto = string.Empty;
            double lDblPrecio = 0.0;
            int lIntExistencia = 0;
            bool encontrado = false;
            string lStrNombre = string.Empty;
            string respuesta = string.Empty;

            try
            {
                using (FileStream fs = new FileStream("c:/tmp/binario/Productos.txt", FileMode.Open, FileAccess.Read))
                {
                    FileStream sw = new FileStream("c:/tmp/binario/tmp.txt", FileMode.Append);
                    lObjLeer = new BinaryReader(fs);
                    lObjEscribir = new BinaryWriter(sw);

                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    gStrTitulo = "ELIMINAR PRODUCTO";
                    Console.SetCursorPosition((Console.WindowWidth - gStrTitulo.Length) / 2, Console.CursorTop);
                    Console.WriteLine(gStrTitulo);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.Write("                    Por favor ingrese el nombre del producto a eliminar: ");
                    lStrNombre = Console.ReadLine();

                    while (fs.Position != fs.Length)
                    {
                        lIntCodigoProducto= lObjLeer.ReadInt32();
                        lStrDescripcionProducto = lObjLeer.ReadString();
                        lDblPrecio = lObjLeer.ReadDouble();
                        lIntExistencia = lObjLeer.ReadInt32();

                        if (lStrDescripcionProducto == lStrNombre)
                        {
                            Console.WriteLine("********************************************************");
                            Console.WriteLine("ID        : " + lIntCodigoProducto);
                            Console.WriteLine("NOMBRE    : " + lStrDescripcionProducto);
                            Console.WriteLine("PRECIO    : " + lDblPrecio);
                            Console.WriteLine("EXISTENCIA: " + lIntExistencia);
                            Console.WriteLine("********************************************************");
                            Console.WriteLine("Es el registro que buscabas? (S/N)");
                            respuesta = Console.ReadLine();
                            if (respuesta.ToUpper() == "S")
                            {
                                Console.WriteLine("Registro eliminado");
                                encontrado = true;
                            }
                            else
                            {
                                lObjEscribir.Write(lIntCodigoProducto);
                                lObjEscribir.Write(lStrDescripcionProducto);
                                lObjEscribir.Write(lDblPrecio);
                                lObjEscribir.Write(lIntExistencia);
                                encontrado = false;
                            }
                        }
                        else
                        {
                            lObjEscribir.Write(lIntCodigoProducto);
                            lObjEscribir.Write(lStrDescripcionProducto);
                            lObjEscribir.Write(lDblPrecio);
                            lObjEscribir.Write(lIntExistencia);
                            encontrado = false;
                        }
                    }
                    if (fs == null && encontrado == false)
                    {
                        Console.WriteLine("No existe el registro y no puede ser eliminado.");
                        lObjEscribir.Write(lIntCodigoProducto);
                        lObjEscribir.Write(lStrDescripcionProducto);
                        lObjEscribir.Write(lDblPrecio);
                        lObjEscribir.Write(lIntExistencia);
                    }
                    sw.Close();
                }
                lObjLeer.Close();
                lObjEscribir.Close();

                File.Delete("c:/tmp/binario/Productos.txt");
                File.Move("c:/tmp/binario/tmp.txt", "c:/tmp/binario/Productos.txt");
            }


            catch (Exception e)
            {

                Console.WriteLine("Por favor revisar el codigo: " + e.Message);
            }

        }
    }
}
