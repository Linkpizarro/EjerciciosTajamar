using CochesNuGet;
using NuGetNorthwindApiDPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosNorthwind cliente = new DatosNorthwind();
            ListaProductos productos = cliente.GetProductos();
            foreach (Producto p in productos.Productos)
            {
                Console.WriteLine("Nombre: " + p.Nombre);
                Console.WriteLine("Cantidad: " + p.Cantidad);
                Console.WriteLine("Stock: " + p.Stock);
                Console.WriteLine("---------------------------------------------");
            }
            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
