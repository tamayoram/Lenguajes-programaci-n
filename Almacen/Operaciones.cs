using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen
{
    class Operaciones
    {
        public int precio1 { get; set; }
        public int precio2 { get; set; }
        public int precio3 { get; set; }

        public void operaciones(int precio1, int precio2, int precio3)
        {
            int valorTotal = 0;
            int promedio = 0;

            valorTotal = precio1 + precio2 + precio3;
            promedio = valorTotal / 3;

            Console.Write("El precio de los zapatos es " + precio1);
            Console.Write("El precio de los pantalones es " + precio2);
            Console.Write("El precio de los pantalones es " + precio3);

            Console.Write("El valor total es " + valorTotal);

            Console.Write("El precio promedio " + promedio);

        }
    }
}
