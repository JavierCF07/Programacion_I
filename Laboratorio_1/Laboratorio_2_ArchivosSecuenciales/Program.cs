using System;
using System.IO;
using System.Linq;

/// <summary>
/// Clase No 4.
/// Autor: Javier Cifuentes.
/// Tema: Codigo para menu y archivos.
/// Objetivo: Practicar con funcionalidad para desplejar un menu y luego 
/// trabajar con archivos.
/// </summary>
namespace Laboratorio_2_ArchivosSecuenciales
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo op; //Contiene informacion de la tecla presionada.
            Program lObjProceso = new Program(); //Instancia declarada de la clase Programa.

            do //Ciclo que se repite al menos 1 vez.
            {

                lObjProceso.SubMenuPrincipal();

                op = Console.ReadKey(true); //Que no muestre la tecla señalada
                Console.WriteLine(op.Key); //Metodos son acciones, las propiedades son valores

                switch (op.Key)
                {
                    case ConsoleKey.NumPad1:
                        lObjProceso.SubCrearArchivos();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D1:
                        lObjProceso.SubCrearArchivos();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad2:
                        lObjProceso.SubBorrarArchivo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        lObjProceso.SubBorrarArchivo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad3:
                        lObjProceso.SubRenombrarArchivo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        lObjProceso.SubRenombrarArchivo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad4:
                        lObjProceso.SubAgregarInformacionArchivo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        lObjProceso.SubAgregarInformacionArchivo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad5:
                        lObjProceso.SubListarInformacionArchivo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        lObjProceso.SubListarInformacionArchivo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad6:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.D6:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Saliendo del sistema");
                        break;
                }
            } while (op.Key != ConsoleKey.Escape);
        }

        public void SubMenuPrincipal()
        {
            Console.Clear(); //Limpiar la pantalla
            Console.Title = "CLASE NO.4 EJERCICIO DE MENUS Y ARCHIVOS"; //Titulo de la consola.
            string StrTitulo = "CLASE NO.4 EJERCICIO DE MENUS Y ARCHIVOS"; //Se declara la variable StrTitulo con el siguiente texto.
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Obtiene el ancho de la pantalla y se resta con las posiciones del titulo, para posicionarlo arriba y dejarlo centrado.
            Console.WriteLine(StrTitulo); //Escribe el titulo en pantalla.
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115))); //Escribe en pantalla, y concatena el valor dado mediante el Repeat
            Console.SetCursorPosition(25, 2); Console.WriteLine("CURSO: PROGRAMACION 1"); //Posiciona fila y columna el titulo del curso.
            Console.SetCursorPosition(25, 3); Console.WriteLine("NOMBRE: JAVIER CIFUENTES");
            Console.SetCursorPosition(25, 4); Console.WriteLine("CARNE: 0900-20-6600");
            Console.SetCursorPosition(25, 5); Console.WriteLine("SECCION: B");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            StrTitulo = "MENU PRINCIPAL";
            Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop);
            Console.WriteLine(StrTitulo);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.ForegroundColor = ConsoleColor.Red; //Cambia color a la letra.
            Console.SetCursorPosition(30, 09); Console.WriteLine("    1. CREACION DE ARCHIVO");
            Console.SetCursorPosition(30, 10); Console.WriteLine("    2. ELIMINACION DE ARCHIVO");
            Console.SetCursorPosition(30, 11); Console.WriteLine("    3. RENOMBRAR EL ARCHIVO");
            Console.SetCursorPosition(30, 12); Console.WriteLine("    4. AGREGAR INFORMACION AL ARCHIVO");
            Console.SetCursorPosition(30, 13); Console.WriteLine("    5. LISTAR INFORMACION DEL ARCHIVO");
            Console.SetCursorPosition(30, 14); Console.WriteLine("    6. SALIDA [ESC]");
            Console.ForegroundColor = ConsoleColor.White; //Cambia color a la letra.
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(30, 16); Console.WriteLine("     ELIJA EL NUMERO DE OPCION [   ]           ");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(61, 16);
        }

        public void SubCrearArchivos()
        {
            string lStrInformacion = string.Empty; //Crea variable inicializada vacia.
            Console.Clear(); //Limpiar la pantalla
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(15, 4); Console.WriteLine("CREACION DEL ARCHIVO");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(20, 6); Console.WriteLine("INGRESE EL PATH DEL ARCHIVO:_______________");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(52, 6);
            string lstrPath;
            lstrPath = Console.ReadLine();
            if (lstrPath.Length < 2)
            {
                Console.Clear();
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.SetCursorPosition(20, 1); Console.WriteLine("           FAVOR INGRESAR UNA RUTA VALIDA");
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.SetCursorPosition(20, 3); Console.WriteLine("           PRESIONE UNA TECLA PARA CONTINUAR");
            }
            if (lstrPath.Length > 2)
            {
                try
                {

                    StreamWriter sw = new StreamWriter(lstrPath); //Funcion para creacion de un archivo
                    sw.Close(); //Cierre de archivo
                    Console.SetCursorPosition(20, 10); Console.WriteLine("          [" + lstrPath + "]");
                    Console.SetCursorPosition(0, 11); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.SetCursorPosition(20, 12); Console.WriteLine("RESULTADO: EL ARCHIVO A SIDO CREADO EXITOSAMENTE");
                    Console.SetCursorPosition(0, 13); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.SetCursorPosition(30, 14); Console.WriteLine("PRESIONE UNA TECLA PARA CONTNUAR...");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al crear archivo: " + e.Message);
                }
                finally
                {

                }
            }
        }

        public void SubBorrarArchivo()
        {
            string lStrInformacion = string.Empty;
            Console.Clear(); //Limpia la pantalla
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(15, 4);
            Console.WriteLine("BORRAR ARCHIVO");

            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("INGRESE EL PATH DEL ARCHIVO:____________________");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(52, 6);
            string lstrPath;
            lstrPath = Console.ReadLine();
            if (lstrPath.Length < 2)
            {
                Console.Clear();
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.SetCursorPosition(20, 1);
                Console.WriteLine("           FAVOR INGRESAR UNA RUTA VALIDA");
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.SetCursorPosition(20, 3);
                Console.WriteLine("           PRESIONE UNA TECLA PARA CONTINUAR...");
            }
            if (lstrPath.Length > 2)
            {
                try
                {
                    if (File.Exists(lstrPath))
                    {
                        File.Delete(lstrPath);
                        Console.SetCursorPosition(20, 10);
                        Console.WriteLine("    [" + lstrPath + "]");
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                        Console.SetCursorPosition(20, 12);
                        Console.WriteLine("EL ARCHIVO FUE ELIMINADO CORRECTAMENTE");
                        Console.SetCursorPosition(0, 13);
                        Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                        Console.SetCursorPosition(30, 14);
                        Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR...");
                    }
                    else
                    {
                        Console.SetCursorPosition(20, 10);
                        Console.WriteLine("           [" + lstrPath + "]");
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                        Console.SetCursorPosition(20, 12);
                        Console.WriteLine("EL ARCHIVO NO EXISTE, FAVOR REVISAR");
                        Console.SetCursorPosition(0, 13);
                        Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                        Console.SetCursorPosition(30, 14);
                        Console.Write("Presione una tecla para continuar...");
                    }
                }
                catch (Exception e)
                {
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.SetCursorPosition(20, 10);
                    Console.WriteLine("ERROR AL BORRAR EL ARCHIVO {0}", e.ToString());
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                }
            }
        }

        public void SubRenombrarArchivo()
        {
            String lStrInformacion = string.Empty;
            Console.Clear(); //Limpiar pantalla
            Console.SetCursorPosition(0, 3);

            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(15, 4);
            Console.WriteLine("RENOMBRAR ARCHIVO");

            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("INGRESE EL PATH DEL ARCHIVO:____________________________");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(52, 6);
            string lstrPath;
            lstrPath = Console.ReadLine();

            Console.SetCursorPosition(20, 8);
            Console.WriteLine("           INGRESE EL NOMBRE NUEVO DEL ARCHIVO:          ");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(52, 8);
            string lStrPathNuevo;

            lStrPathNuevo = Console.ReadLine();

            if (lstrPath.Length < 2)
            {
                Console.Clear();
                Console.SetCursorPosition(20, 10);
                Console.WriteLine("            [" + lstrPath + "]");
                Console.SetCursorPosition(0, 11);
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.SetCursorPosition(20, 12);
                Console.WriteLine("DEBE INGRESAR UN PATH CORRECTO");
                Console.SetCursorPosition(0, 13);
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.SetCursorPosition(30, 14);
                Console.Write("PRESIONE UNA TECLA PARA CONTINUAR...");
            }
            if (lstrPath.Length > 2)
            {
                if (!File.Exists(lStrPathNuevo))
                {
                    File.Move(lstrPath, lStrPathNuevo);
                    Console.SetCursorPosition(20, 10);
                    Console.WriteLine("         [" + lstrPath + "]");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.SetCursorPosition(20, 12);
                    Console.WriteLine("EL ARCHIVO FUE RENOMBRADO CORRECTAMENTE");
                    Console.SetCursorPosition(0, 13);
                    Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                    Console.SetCursorPosition(30, 14);
                    Console.Write("PRESIONE UNA TECLA PARA CONTINUAR...");
                }
            }
        }

        public void SubAgregarInformacionArchivo()
        {
            string lStrInformacion = string.Empty;
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(15, 4); Console.WriteLine("ARCHIVO AL CUAL DESEA AGREGAR INFORMACION");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(20, 6); Console.WriteLine("INGRESE EL PATH DEL ARCHIVO:______________");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(52, 6);
            string lstrPath = string.Empty;
            lstrPath = Console.ReadLine();

            if (lstrPath.Length < 2)
            {
                Console.Clear();
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.SetCursorPosition(20, 1); Console.WriteLine("        FAVOR INGRESAR UNA RUTA VALIDA       ");
                Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
                Console.SetCursorPosition(20, 3); Console.Write("            PRESIONE UNA TECLA PARA CONTINUAR");
            }
            if (lstrPath.Length > 2)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(lstrPath, FileMode.Append)))
                    {
                        Boolean lblnContinuaIngresando = true;
                        string lStrDeseaContinuar = string.Empty;
                        int lintIdAlumno = 0;
                        string lStrNombreAlumno = string.Empty;
                        string lStrDireccionAlumno = string.Empty;
                        int lintEdad = 0;
                        string lStrCarreraUniversitaria = string.Empty;
                        string lStrSemestre = string.Empty;
                        string lStrSeparador = "|";
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
                            Console.SetCursorPosition(35, 8); Console.WriteLine("ID ALUMNO       :            [                                          ]");
                            Console.SetCursorPosition(35, 9); Console.WriteLine("NOMBRE ALUMNO   :            [                                          ]");
                            Console.SetCursorPosition(35, 10); Console.WriteLine("DIRECCION ALUMNO:            [                                          ]");
                            Console.SetCursorPosition(35, 11); Console.WriteLine("EDAD            :            [                                          ]");
                            Console.SetCursorPosition(25, 12); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 13); Console.WriteLine("DATOS ESPECIFICOS");
                            Console.SetCursorPosition(25, 14); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(35, 15); Console.WriteLine("CARRERA UNIVERSITARIA:        [                                          ]");
                            Console.SetCursorPosition(35, 16); Console.WriteLine("SEMESTRE             :        [                                          ]");
                            Console.SetCursorPosition(25, 17); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 85)));
                            Console.SetCursorPosition(70, 8); lintIdAlumno = int.Parse(Console.ReadLine());
                            Console.SetCursorPosition(70, 9); lStrNombreAlumno = Console.ReadLine();
                            Console.SetCursorPosition(70, 10); lStrDireccionAlumno = Console.ReadLine();
                            Console.SetCursorPosition(70, 11); lintEdad = int.Parse(Console.ReadLine());

                            Console.SetCursorPosition(70, 15); lStrCarreraUniversitaria = Console.ReadLine();
                            Console.SetCursorPosition(70, 16); lStrSemestre = Console.ReadLine();

                            Console.SetCursorPosition(40, 18); Console.WriteLine("DESEA CONTINUAR INGRESANDO REGISTROS S/N:        [  ]");
                            Console.SetCursorPosition(90, 18); lStrDeseaContinuar = Console.ReadLine();
                            if (lStrDeseaContinuar.ToUpper() == "N")
                            {
                                lblnContinuaIngresando = false;
                            }
                            sw.Write(Convert.ToString(lintIdAlumno).PadRight(20, ' ')); sw.Write(lStrSeparador);
                            sw.Write(lStrNombreAlumno.PadRight(30, ' ')); sw.Write(lStrSeparador);
                            sw.Write(lStrDireccionAlumno.PadRight(30, ' ')); sw.Write(lStrSeparador);
                            sw.Write(Convert.ToString(lintEdad).PadRight(5, ' ')); sw.Write(lStrSeparador);
                            sw.Write(lStrCarreraUniversitaria.PadRight(30, ' ')); sw.Write(lStrSeparador);
                            sw.WriteLine(lStrSemestre.PadRight(20, ' '));
                        }
                        sw.Close();
                        Console.Write("           PRESIONE UNA TECLA PARA CONTINUAR...");
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
        }

        public void SubListarInformacionArchivo()
        {
            Console.Clear(); //Limpiar la pantalla
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(15, 4); Console.WriteLine("ARCHIVO AL CUAL DESEA AGREGAR INFORMACION");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(20, 6); Console.WriteLine("INGRESE EL PATH DEL ARCHIVO:_______________");
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 115)));
            Console.SetCursorPosition(52, 6);
            string lstrPath;
            lstrPath = Console.ReadLine();
            if (lstrPath.Length < 2)
            {
                Console.Clear();
                Console.WriteLine("                -------------------------------------------------");
                Console.WriteLine("                         FAVOR INGRESAR UNA RUTA VALIDA             ");
                Console.WriteLine("                -------------------------------------------------");
                Console.Write("                      PRESIONE UNA TECLA PARA CONTINUAR");
            }
            if (lstrPath.Length > 2)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(lstrPath))
                    {
                        Console.WriteLine("        ________________________________________________________________");

                        String lstrCadena;
                        int lIntLinea = 9;
                        Console.Clear(); //Limpiar la pantalla
                        Console.SetCursorPosition(0, 3);
                        string StrTitulo = "LISTADO DE ESTUDIANTES";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine(StrTitulo);

                        Console.SetCursorPosition(5, 5); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 110)));
                        StrTitulo = "DETALLE DE INFORMACION";
                        Console.SetCursorPosition((Console.WindowWidth - StrTitulo.Length) / 2, Console.CursorTop); //Centrar cursor para desplegar el titulo.
                        Console.WriteLine("DETALLE DE INFORMACION");
                        Console.SetCursorPosition(5, 7); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 110)));
                        Console.SetCursorPosition(5, 8); Console.WriteLine("ID        NOMBRE              DIRECCION               EDAD       CARRERA             SEMESTRE");

                        while ((lstrCadena = sr.ReadLine()) != null)
                        {

                            String[] lStrConjuntoDatos = lstrCadena.Split('|');
                            Console.SetCursorPosition(5, lIntLinea); Console.Write(lStrConjuntoDatos[0]);
                            Console.SetCursorPosition(15, lIntLinea); Console.Write(lStrConjuntoDatos[1]);
                            Console.SetCursorPosition(35, lIntLinea); Console.Write(lStrConjuntoDatos[2]);
                            Console.SetCursorPosition(60, lIntLinea); Console.Write(lStrConjuntoDatos[3]);
                            Console.SetCursorPosition(70, lIntLinea); Console.Write(lStrConjuntoDatos[4]);
                            Console.SetCursorPosition(90, lIntLinea); Console.Write(lStrConjuntoDatos[5]);
                            lIntLinea += 1;
                        }
                        Console.SetCursorPosition(5, lIntLinea); Console.WriteLine(string.Concat(Enumerable.Repeat("=", 110)));
                    }
                    Console.SetCursorPosition(30, 30); Console.Write("            Presione una tecla para continuar...");
                }
                catch (IOException e)
                {
                    Console.WriteLine("        ________________________________________________________________");
                    Console.WriteLine("            OCURRIO UN ERROR AL LEER EL ARCHIVO, FAVOR REVISE");
                    Console.WriteLine("   " + e.Message);
                    Console.WriteLine("        ________________________________________________________________");

                }
            }
        }
    }
}
