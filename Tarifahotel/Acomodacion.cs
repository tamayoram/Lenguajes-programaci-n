using System;
using System.Collections.Generic;
using System.Text;

namespace Tarifahotel
{
    class Acomodacion
    {
        // atributos
        public string tipoHabitacion { get; set; }
        public int cantidadDias { get; set; }

        //función o método

        public void PrecioDescuento(string tipoHabitacion)
        {
            // Se coloca en mayúsculas para significar que son constantes

            double INDIVIDUAL = 2500, DOBLE = 4600, FAMILIAR = 5200, IVA = 0.19,DESCUENTOINDIVIDUAL=0.05,
                DESCUENTODOBLE=0.09,DESCUENTOFAMILIAR=0.15;
            Double PrecioIVA=0, PrecioDescuento=0;

            if (tipoHabitacion == "Fin" || tipoHabitacion == "fin" || tipoHabitacion == "FIN")
            {
                Console.Write("Se ha cerrado el programa");
            }
            else
            {
                            
                switch (tipoHabitacion)
                {
                    case "Individual":
                    case "INDIVIDUAL":
                    case "individual":

                        PrecioIVA = INDIVIDUAL * cantidadDias * (1 + IVA);
                        PrecioDescuento = Math.Ceiling(PrecioIVA * (1 - DESCUENTOINDIVIDUAL));
                        break;

                    case "Doble":
                    case "DOBLE":
                    case "doble":

                        PrecioIVA = DOBLE * cantidadDias * (1 + IVA);
                        PrecioDescuento = Math.Ceiling(PrecioIVA * (1 - DESCUENTODOBLE));
                        break;

                    case "Familiar":
                    case "FAMILIAR":
                    case "familiar":

                        PrecioIVA = FAMILIAR * cantidadDias * (1 + IVA);
                        PrecioDescuento = Math.Ceiling(PrecioIVA * (1 - DESCUENTOFAMILIAR));
                        break;

                    default:
                        Console.WriteLine("Por favor revise la información ingresada");
                        PrecioDescuento = 0;
                        break;

                }
            }

            if (PrecioDescuento != 0) 
            {
                Console.WriteLine("El valor que debe pagar por su estadía es de " + PrecioDescuento);
            }
        }

    }
}
