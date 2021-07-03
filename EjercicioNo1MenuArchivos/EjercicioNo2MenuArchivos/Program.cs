using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo2MenuArchivosListas
{
    //clase que define el nodo de la lista
    public class Nodo
    {
        public DatoCliente dato; // dato contenido en el nodo
        public Nodo siguiente; // puntero al siguiente nodo
        public Nodo comienzo; //Cabecera de la lista

        public struct DatoCliente
        {
            public int lIntIdCliente;
            public string lStrNombreCliente;
            public double lDblSaldo;
        }
        public void InsertarComienzo(DatoCliente dato)
        {
            Nodo Añadir = new Nodo();

            Añadir.dato = dato;
            Añadir.siguiente = comienzo;
            comienzo = Añadir;
        }

        public void InsertarFinal(DatoCliente dato)
        {
            if (comienzo == null)
            {
                comienzo = new Nodo();

                comienzo.dato = dato;
                comienzo.siguiente = null;
            }
            else
            {
                Nodo añadir = new Nodo();
                añadir.dato = dato;

                Nodo actual = comienzo;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }

                actual.siguiente = añadir;
            }
        }

    }
    // Clase que imprime todos los nodos de la lista
    public class ListaEnlazada
    {
        //private Nodo comienzo;

        public void imprimeTodosLosNodos(Nodo comienzo)
        {
            Nodo actual = comienzo;
            while (actual != null)
            {
                Console.WriteLine("Id Cliente: " + actual.dato.lIntIdCliente + "; " + " Nombre Cliente: " + actual.dato.lStrNombreCliente + "; " + " Saldo: " + actual.dato.lDblSaldo + ";");
                actual = actual.siguiente;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Añade al inicio:");
            ListaEnlazada miLista1 = new ListaEnlazada();
            Nodo miNodo1 = new Nodo();

            Nodo.DatoCliente lObjDatoCliente = new Nodo.DatoCliente();
            lObjDatoCliente.lIntIdCliente = 1;
            lObjDatoCliente.lStrNombreCliente = "Javier Cifuentes";
            lObjDatoCliente.lDblSaldo = 5465.5;

            miNodo1.InsertarComienzo(lObjDatoCliente);

            lObjDatoCliente = new Nodo.DatoCliente();
            lObjDatoCliente.lIntIdCliente = 2;
            lObjDatoCliente.lStrNombreCliente = "Daniel Cifuentes";
            lObjDatoCliente.lDblSaldo = 15253.4;

            miNodo1.InsertarComienzo(lObjDatoCliente);

            lObjDatoCliente = new Nodo.DatoCliente();
            lObjDatoCliente.lIntIdCliente = 3;
            lObjDatoCliente.lStrNombreCliente = "Leticia Funes";
            lObjDatoCliente.lDblSaldo = 3564.4;

            miNodo1.InsertarComienzo(lObjDatoCliente);

            miLista1.imprimeTodosLosNodos(miNodo1.comienzo);

            Console.WriteLine();

            Console.WriteLine("Añade al final:");
            ListaEnlazada miLista2 = new ListaEnlazada();
            Nodo miNodo2 = new Nodo();

            lObjDatoCliente = new Nodo.DatoCliente();
            lObjDatoCliente.lIntIdCliente = 1;
            lObjDatoCliente.lStrNombreCliente = "Javier Cifuentes";
            lObjDatoCliente.lDblSaldo = 5465.5;

            miNodo2.InsertarFinal(lObjDatoCliente);

            lObjDatoCliente = new Nodo.DatoCliente();
            lObjDatoCliente.lIntIdCliente = 2;
            lObjDatoCliente.lStrNombreCliente = "Daniel Cifuentes";
            lObjDatoCliente.lDblSaldo = 15253.4;

            miNodo2.InsertarFinal(lObjDatoCliente);

            lObjDatoCliente = new Nodo.DatoCliente();
            lObjDatoCliente.lIntIdCliente = 3;
            lObjDatoCliente.lStrNombreCliente = "Leticia Funes";
            lObjDatoCliente.lDblSaldo = 3564.4;

            miNodo2.InsertarFinal(lObjDatoCliente);

            miLista2.imprimeTodosLosNodos(miNodo2.comienzo);

            Console.ReadLine();

        }
    }
}
