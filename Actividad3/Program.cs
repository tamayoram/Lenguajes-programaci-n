using System;

namespace Actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            double PrecioIndividual = 2500, PrecioDoble = 4600, PrecioFamiliar = 5200,CobroSinIva,CobroConIva,CobroConDescuento, iva=0.19,descuento;
            int dias;
            string TipoHospedaje;

            Console.Write("Ingrese la cantidad de días de hospedaje (cero (0) o un número negativo detienen la ejecución): ");
            dias = int.Parse(Console.ReadLine());

            while (dias > 0)
            {

                Console.Write("Ingrese el tipo de hospedaje (Individual/Doble/Familiar): ");
                TipoHospedaje = Console.ReadLine();

                            

            switch (TipoHospedaje)
            {
                case "Individual":
                case "individual":
                case "INDIVIDUAL":

                    descuento = 0.05;
                    CobroSinIva = dias * PrecioIndividual;
                    CobroConIva = CobroSinIva * (1 + iva);
                    CobroConDescuento = CobroConIva * (1 - descuento);
                    
                    Console.WriteLine("Cobro sin iva $" + CobroSinIva);
                    Console.WriteLine("Cobro con iva $" + CobroConIva);
                    Console.WriteLine("Cobro con descuento $" + CobroConDescuento);
                        break;

                case "Doble":
                case "doble":
                case "DOBLE":

                    descuento = 0.09;
                    CobroSinIva = dias * PrecioDoble;
                    CobroConIva = CobroSinIva * (1 + iva);
                    CobroConDescuento = CobroConIva * (1 - descuento);

                    Console.WriteLine("Cobro sin iva $" + CobroSinIva);
                    Console.WriteLine("Cobro con iva $" + CobroConIva);
                    Console.WriteLine("Cobro con descuento $" + CobroConDescuento);

                        break;

                case "Familiar":
                case "familiar":
                case "FAMILIAR":

                    descuento = 0.15;
                    CobroSinIva = dias * PrecioFamiliar;
                    CobroConIva = CobroSinIva * (1 + iva);
                    CobroConDescuento = CobroConIva * (1 - descuento);

                    Console.WriteLine("Cobro sin iva $" + CobroSinIva);
                    Console.WriteLine("Cobro con iva $" + CobroConIva);
                    Console.WriteLine("Cobro con descuento $" + CobroConDescuento);
                        break;

                default:
                    Console.WriteLine("Por favor revise la información ingresada. Recuerde el tipo de hospedaje es Individual, Doble o Familiar");
                    break;


            }
                Console.Write("Ingrese la cantidad de días de hospedaje (cero (0) o un número negativo detienen la ejecución): ");
                dias = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
