using System;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string art1 = "Zapatos", art2 = "Tenis", art3 = "Camisetas", art4 = "Jeans";
            double p1 = 350000, p2 = 280000, p3 = 175000, p4 = 200000, total, promedio;

            total = p1 + p2 + p3 + p4;
            promedio = total / 4;
            Console.WriteLine("Almacen WC");
            Console.WriteLine("Precio de los " + art1 + " " + " $"+p1);
            Console.WriteLine("Precio de los " + art2 + " " +" $"+ p2);
            Console.WriteLine("Precio de las " + art3 + " " +" $"+ p3);
            Console.WriteLine("Precio de los " + art4 + " " +" $"+ p4);
            Console.WriteLine("Total: " +" $"+ total);
            Console.WriteLine("Promedio de precios: " + " $"+ promedio);

            p4 = p4 * (1 + 0.062);
            p1 = p1 * 0.992;

            Console.WriteLine("Nuevo precio " + art1 + " :$ " + p1);
            Console.WriteLine("Nuevo precio " + art4 + " :$ " + p4);
            Console.ReadKey();
        }
    }
}
