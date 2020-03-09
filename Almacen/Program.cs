using System;

namespace Almacen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el precio de los zapatos: ");
            int zapatos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio de los pantalones: ");
            int pantalones = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio de las camisetas: ");
            int camisetas = int.Parse(Console.ReadLine());

            var valoresAlmacen = new Operaciones()
            {
                precio1 = zapatos,
                precio2 = pantalones,
                precio3 = camisetas
            };

            valoresAlmacen.operaciones(valoresAlmacen.precio1, valoresAlmacen.precio2, valoresAlmacen.precio3);
        }
    }
}
