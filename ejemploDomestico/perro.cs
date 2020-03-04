using System;
using System.Collections.Generic;
using System.Text;

namespace ejemploDomestico
{
   
    // se colocan dos puntos y el nombre de la clase de la cual queremos hacer herencia
    class perro :animalDomestico
    {
        //public void sonido()
        //{
        //    Console.Write("guau!!");
        //}

        // implementar las clases abstractas
        public override string sonar()
        {
            return "guau!!";
        }
        

    }

   
}
