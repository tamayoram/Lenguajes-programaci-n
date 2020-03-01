using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionesAritmeticas_return
{
    class projects
    {
        // atributos
        public string projectType { get; set; }

        // Método o función
        //public void PriceProject(string TypeProject)
        //{
        //    short price = 0;

        //    if (TypeProject=="a" || TypeProject=="A")
        //    {
        //        price = 10000;
        //    }
        //    else
        //    {
        //        if (TypeProject == "b" || TypeProject == "B")
        //        {
        //            price = 20000;
        //        }
        //        else
        //        {
        //            price = 5000;
        //        }
        //    }
        //    Console.Write("El precio es: " + price);
        //}

        public short typeProject(string TypeProject)
        {
            short price = 0;

            if (TypeProject == "a" || TypeProject == "A")
            {
                price = 10000;
            }
            else
            {
                if (TypeProject == "b" || TypeProject == "B")
                {
                    price = 20000;
                }
                else
                {
                    price = 5000;
                }
            }

            return price;

            
            
        }
        public void imprimir()
        {
            short PriceNotIVA = 0;
            double PriceWithIVA = 0;
            
            PriceNotIVA = typeProject(projectType);
            PriceWithIVA = PriceNotIVA * (1.19);
            Console.Write("El precio con IVA es: " + PriceWithIVA);
        }
    }
}
