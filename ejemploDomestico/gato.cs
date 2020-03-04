using System;
using System.Collections.Generic;
using System.Text;

namespace ejemploDomestico
{
    // se colocan dos puntos y el nombre de la clase de la que se desea heredar
    class gato:animalDomestico
    {
        //public void sonido()
        //{
        //    Console.Write("miau!!");
        //}

        public override string sonar()
        {
            return "Miau!!";
        }


    }


}
