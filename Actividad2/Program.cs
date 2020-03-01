using System;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hlabor = 8;
            string tipo;
            double valhora,sueldo,valhoraex;

            Console.Write("Ingrese el tipo de proyecto (A/B/NA): ");
            tipo = Console.ReadLine();

            switch (tipo)
            {
                case "NA":
                case "na":
                    valhora = 5000;
                    break;
                
                case "B":
                case "b":
                    valhora = 10000;
                    break;
                
                case "A":
                case "a":
                    valhora = 20000;
                    break;

                default:
                    Console.WriteLine("Verifique el tipo de proyecto ingresado");
                    valhora = 0;
                    break;
            }

            if (valhora != 0) { 
            
            sueldo = (valhora * hlabor) * 30;

            Console.WriteLine("Valor hora $ " + valhora);

            if (sueldo > 1500000) {
                Console.WriteLine("Sueldo mensual $ " + sueldo);
                Console.WriteLine("Salario es mayor a tope máximo");
            }
            else
            {
                Console.WriteLine("Sueldo mensual $ " + sueldo);
                valhoraex = valhora * (1 + 0.06);
                Console.WriteLine("Valor hora extra $ " + valhoraex);
                sueldo = sueldo + (3 * valhoraex);
                Console.WriteLine("Nuevo sueldo mensual $ " + sueldo);

            }
            }
            else
            {

            }
            
            Console.ReadKey();
            

        }
    }
}
