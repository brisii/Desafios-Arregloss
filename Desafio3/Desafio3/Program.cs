using System;
using System.Collections.Generic;

class Program
{
    static List<string> elementos = new List<string>(); 

    static void Main()
    {
        
        while (true)
        {
            Console.WriteLine("Menú de operaciones:");
            Console.WriteLine("1. Agregar dato");
            Console.WriteLine("2. Eliminar dato");
            Console.WriteLine("3. Mostrar dato");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese la operación a realizar: ");

           
            string seleccion = Console.ReadLine().Trim();
            if (seleccion == "1")
            {
                
                Console.Write("Ingrese el dato a agregar: ");
                string elemento = Console.ReadLine().Trim();
                elementos.Add(elemento);
                Console.WriteLine("Dato agregado correctamente.");
            }
            else if (seleccion == "2")
            {
                
                Console.Write("Ingrese el dato a eliminar: ");
                string elemento = Console.ReadLine().Trim();
                bool eliminado = elementos.Remove(elemento);
                if (eliminado)
                {
                    Console.WriteLine("dato eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("El dato no existe en la lista.");
                }
            }
            else if (seleccion == "3")
            {
                
                Console.WriteLine("Dato actuales:");
                foreach (string elemento in elementos)
                {
                    Console.WriteLine("- " + elemento);
                }
            }
            else if (seleccion == "4")
            {
                
                break;
            }
            else
            {
                Console.WriteLine("Operación no válida.");
            }
            Console.WriteLine();
        }
    }
}

