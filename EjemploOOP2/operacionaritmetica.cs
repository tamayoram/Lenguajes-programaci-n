using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploOOP2
{
    class operacionaritmetica
    {

        //atributos
        public short nUno { get; set; }

        public short nDos { get; set; }


        //funciones
        public void suma(short numeroU, short numeroD)
        {
            short resulSuma = 0;
            resulSuma = (short) (numeroU + numeroD);
            Console.Write("La suma es: " + resulSuma);
        }
    }
}
