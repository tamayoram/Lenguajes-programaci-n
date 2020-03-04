using System;
using System.Collections.Generic;
using System.Text;

namespace ejemploDomestico
{
    
    // se debe colocar abstract la clase para poder utilizar funciones o atributos de forma particular
    abstract class animalDomestico
    {
        // para colocar las propiedades se da prop y tabulador 2 veces
        public string nombre { get; set; }
        public string raza { get; set; }
        public char genero { get; set; }

        // metodos

        public void correr()
        {
            Console.Write("esta corriendo....");

        }

        public abstract string sonar();

        
    }
}
