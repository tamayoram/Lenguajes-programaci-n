using System;

namespace EjemploOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //programación estructurada
            Console.WriteLine("Saludo!");

            Console.Write("Número uno:");
            short numUno = short.Parse(Console.ReadLine());

            Console.Write("Número dos:");
            short numDos = short.Parse(Console.ReadLine());

            //int resultado = numUno + numDos;

            //Console.WriteLine("La suma es: " + resultado);

            //programación orientada a objetos

            //Forma 1 para crear instancias: operacionaritmetica operacionsuma = new operacionaritmetica();
            //Forma 2 para crear instancias: 
            var operacionsuma = new operacionaritmetica()
            {
                nUno = numUno,
                nDos = numDos


            };

            //usar los métodos de la clase
            operacionsuma.suma(numUno,numDos);

        }
    }
}
