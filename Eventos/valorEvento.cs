using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos
{
    class valorEvento
    {
        //atributos
        public string tipoEvento { get; set; }
        public int cantidadEmpleados { get; set; }

        public int precioEvento(string tipoEvento)
        {
            int EMPRESARIAL = 200, EXHIBICION = 500, CONGRESO = 400;
            int precio = 0;

            switch (tipoEvento)
            {

                case "empresarial":
                case "EMPRESARIAL":
                case "Empresarial":

                    precio = EMPRESARIAL;
                    break;
                    

                case "exhibicion":
                case "EXHIBICION":
                case "Exhibicion":

                    precio = EXHIBICION;
                    break;

                case "congreso":
                case "CONGRESO":
                case "Congreso":

                    precio = CONGRESO;
                    break;

                default:
                    Console.WriteLine("Por favor revise la información ingresada");
                    break;

            }
            
            return precio;

        }

        public void descuento(int numEmpleados)
        {
            double empresaPequena = 0.2, empresaMediana = 0.15, empresaGrande = 0.1;
            double precioDescuento = 0;

            if (numEmpleados<50)
            {

                precioDescuento = precioEvento(tipoEvento) * (1 - empresaPequena);
                Console.WriteLine("El valor con descuento de su evento es de " + precioDescuento);

            }
            else
            {
                if (numEmpleados < 200)
                {
                    precioDescuento = precioEvento(tipoEvento) * (1 - empresaMediana);
                    Console.WriteLine("El valor con descuento de su evento es de " + precioDescuento);

                }
                else
                {
                    precioDescuento = precioEvento(tipoEvento) * (1 - empresaGrande);
                    Console.WriteLine("El valor con descuento de su evento es de " + precioDescuento);
                }
            }


        }
    }
}
