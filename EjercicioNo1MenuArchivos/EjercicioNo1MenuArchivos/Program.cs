using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioNo1MenuArchivosListas
{
    class Program
    {
        public static void Main()
        {
        // Crea la lista enlazada.
        string[] palabras =
        { "el", "zorro", "saltó", "sobre", "el", "perro" };
        LinkedList<string> frase = new LinkedList<string>(palabras);
        Muestra(frase, "Valores de la lista enlazada:");
        Console.WriteLine("frase.Contains(\"saltó\") = {0}",
            frase.Contains("saltó"));


            // Añade la palabra 'hoy' al comienzo de la lista.
            frase.AddFirst("hoy");
            Muestra(frase, "Test 1: Añade 'hoy' al comienzo de la lista:");

        // Mueve el primer nodo hasta el último nodo.
        LinkedListNode<string> marca1 = frase.First;
        frase.RemoveFirst();
            frase.AddLast(marca1);
            Muestra(frase, "Test 2: Mueve el primer nodo al la última posición:");

        // Modifica el último nodo por 'ayer'.
        frase.RemoveLast();
            frase.AddLast("ayer");
            Muestra(frase, "Test 3: Modifica el último nodo por 'ayer':");

        // Mueve el último nodo al primero.
        marca1 = frase.Last;
            frase.RemoveLast();
            frase.AddFirst(marca1);
            Muestra(frase, "Test 4: Mueve el último nodo al primero:");


        // Indica con un paréntesis la última cocurrencia de 'el'.
        frase.RemoveFirst();
            LinkedListNode<string> actual = frase.FindLast("el");
        IndicaNodo(actual, "Test 5: Indica con un paréntesis la última cocurrencia de 'el'.:");

        // Añade 'perezoso' y  'viejo' después de 'el' (el LinkedListNode nombre actual).
        frase.AddAfter(actual, "viejo");
            frase.AddAfter(actual, "perezoso");
            IndicaNodo(actual, "Test 6: Añade 'perezoso' y  'viejo' después de 'el' :");

        // Indica el nodo 'zorro'
        actual = frase.Find("zorro");
            IndicaNodo(actual, "Test 7: Indica el nodo 'zorro':");

        // Añade 'rápido' and 'marrón' antes de  'zorro':
        frase.AddBefore(actual, "rápido");
            frase.AddBefore(actual, "marrón");
            IndicaNodo(actual, "Test 8:Añade 'rápido' y 'marrón' antes de  'zorro':");

        // Mantiene una referencia al nodo actual 'zorro',
        // y al nodo previo previous en la lista. Indica el nodo 'perro'.
        marca1 = actual;
            LinkedListNode<string> marca2 = actual.Previous;
        actual = frase.Find("perro");
            IndicaNodo(actual, "Test 9: Indica el nodo 'perro':");

        // el método AddBefore devuelve una InvalidOperationException
        // si se intenta añadir un nodo que ya pertenece a la lista.
        Console.WriteLine("Test 10: excepcion por intentar añadir el nodo (zorro) ya existe en la lista:");
            try
            {
                frase.AddBefore(actual, marca1);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }
Console.WriteLine();

// Elimina el nodo al que se refiere la marca1, y añade otro
// antes del nodo referenciado por el nodo actual.
// Indica el nodo referenciado por el actual.
frase.Remove(marca1);
frase.AddBefore(actual, marca1);
IndicaNodo(actual, "Test 11: Mueve un nodo referenciado (zorro)antes del nodo actual (perro):");

// Elimina el nodo referenciado por el actual.
frase.Remove(actual);
IndicaNodo(actual, "Test 12: Elimina el nodo actual (perro) e intenta indicarlo:");

// Añade un nodo después del nodo referenciado por la marca2.
frase.AddAfter(marca2, actual);
IndicaNodo(actual, "Test 13: Añade el nodo eliminado en el tTest 11 después de referenciarlo (marrón):");

// El método Remove encuentra y elimina el
// primer nodo que tiene un valor especificado.
frase.Remove("viejo");
Muestra(frase, "Test 14: Elimina el nodo que tiene el valor 'viejo':");

// Cuando la lista es convertida a una ICollection(de caracteres),
// el método Add añade un nodo  al final de la lista.
frase.RemoveLast();
ICollection<string> icoleccion = frase;
icoleccion.Add("rinoceronte");
Muestra(frase, "Test 15: Elimina el último nodo convirtiéndolo a ICollection,y añade 'rinoceronte':");

Console.WriteLine("Test 16: Copia la lista en un array:");
// Crea un array con el mismo número de elementos que la lista

string[] sArray = new string[frase.Count];
frase.CopyTo(sArray, 0);

foreach (string s in sArray)
{
    Console.WriteLine(s);
}

// Libera todos los nodos.
frase.Clear();

Console.WriteLine();
Console.WriteLine("Test 17: Limpia la lista. Contiene 'saltó' = {0}",
    frase.Contains("saltó"));

Console.ReadLine();
        }

        private static void Muestra(LinkedList<string> palabras, string testeo)
{
    Console.WriteLine(testeo);
    foreach (string palabra in palabras)
    {
        Console.Write(palabra + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

private static void IndicaNodo(LinkedListNode<string> nodo, string testeo)
{
    Console.WriteLine(testeo);
    if (nodo.List == null)
    {
        Console.WriteLine("Nodo '{0}' no está en la lista.\n",
            nodo.Value);
        return;
    }

    StringBuilder resultado = new StringBuilder("(" + nodo.Value + ")");
    LinkedListNode<string> nodoP = nodo.Previous;

    while (nodoP != null)
    {
        resultado.Insert(0, nodoP.Value + " ");
        nodoP = nodoP.Previous;
    }

    nodo = nodo.Next;
    while (nodo != null)
    {
        resultado.Append(" " + nodo.Value);
        nodo = nodo.Next;
    }

    Console.WriteLine(resultado);
    Console.WriteLine();
        }
    }
}
