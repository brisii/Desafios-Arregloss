using System;
using System.Collections.Generic;

class Compraclientes
{
    public string Cliente { get; set; } 
    public string Producto { get; set; }
    public decimal Precio { get; set; }
    public DateTime Fecha { get; set; }
}

class Program
{
    static void Main()
    {
        List<Compraclientes> compras = new List<Compraclientes>();

        // Agregar algunas compras de ejemplo
        compras.Add(new Compraclientes { Cliente = "Juan", Producto = "Leche", Precio = 2.50m, Fecha = new DateTime(2023, 3, 15) });
        compras.Add(new Compraclientes { Cliente = "Ana", Producto = "Pan", Precio = 1.00m, Fecha = new DateTime(2023, 3, 14) });
        compras.Add(new Compraclientes { Cliente = "Juan", Producto = "Huevos", Precio = 3.00m, Fecha = new DateTime(2023, 3, 13) });
        compras.Add(new Compraclientes { Cliente = "Carlos", Producto = "Manzanas", Precio = 2.00m, Fecha = new DateTime(2023, 3, 12) });
        compras.Add(new Compraclientes { Cliente = "Maria", Producto = "Arroz", Precio = 5.00m, Fecha = new DateTime(2023, 3, 11) });
        compras.Add(new Compraclientes { Cliente = "Juan", Producto = "Queso", Precio = 4.00m, Fecha = new DateTime(2023, 3, 10) });
        compras.Add(new Compraclientes { Cliente = "Ana", Producto = "Cereal", Precio = 3.50m, Fecha = new DateTime(2023, 3, 9) });

        // Crear un diccionario para agrupar las compras por cliente
        Dictionary<string, List<Compraclientes>> comprasPorCliente = new Dictionary<string, List<Compraclientes>>();
        foreach (Compraclientes compra in compras)
        {
            if (!comprasPorCliente.ContainsKey(compra.Cliente))
            {
                comprasPorCliente[compra.Cliente] = new List<Compraclientes>();
            }
            comprasPorCliente[compra.Cliente].Add(compra);
        }

        // Obtener las últimas 5 compras de cada cliente
        foreach (string cliente in comprasPorCliente.Keys)
        {
            Console.WriteLine("Últimas 5 compras de " + cliente + ":");
            List<Compraclientes> ultimasCompras = comprasPorCliente[cliente];
            ultimasCompras.Sort((c1, c2) => c2.Fecha.CompareTo(c1.Fecha)); // ordenar por fecha de más reciente a más antigua
            for (int i = 0; i < Math.Min(5, ultimasCompras.Count); i++)
            {
                Compraclientes compra = ultimasCompras[i];
                Console.WriteLine(" - " + compra.Producto + " por " + compra.Precio.ToString("C") + " el " + compra.Fecha.ToShortDateString());
            }
            Console.WriteLine();
        }
    }
}
