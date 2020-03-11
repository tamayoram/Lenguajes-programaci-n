using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos
{
   abstract class categoria
    {
        public string ubicacion { get; set; }
       public void reconocer()
        {

            Console.Write(" tiene una categoría que lo reconoce:");
        }

        public abstract string categorizar();

    }

    
    
    
}
