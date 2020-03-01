using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string art1 = "Zapatos",art2="Tenis",art3="Camisetas",art4="Jeans";
            double part1 = 350000, part2 = 280000, part3 = 175000, part4 = 200000,costo,promedio;

            costo = part1 + part2 + part3 + part4;
            promedio = costo / 4;

            Console.WriteLine(art1 +" "+ part1);
            Console.WriteLine(art2 + " " + part2);
            Console.WriteLine(art3 + " " + part3);
            Console.WriteLine(art4 + " " + part4);
            Console.WriteLine("El costo de los cuatro artículo es de "+ costo);
            Console.WriteLine("El precio promedio es " + promedio);

            part4 = part4 * (1 + 0.062);
            part1 = part1 * 0.992;

            Console.WriteLine("El nuevo valor de "+art1+" es "+part1);
            Console.WriteLine("El nuevo valor de " + art4 + " es " + part4);
            Console.ReadKey();

        }
    }
}
