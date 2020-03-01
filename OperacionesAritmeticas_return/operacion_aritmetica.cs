using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionesAritmeticas_return
{
    class operacion_aritmetica
    {
        // Definición de los atributos

        public double PrimerNumero { get; set; }
        public double SegundoNumero { get; set; }

        // Definición del método o función
        //public void sumar(double Numero1, double Numero2)
        //{
        //    double resultado_sum = 0;
        //    resultado_sum =Numero1 + Numero2;
        //    Console.WriteLine("El resultado de la suma es: " + resultado_sum);

        //}

        public double sumar(double Numero1, double Numero2)
        {
            double resultado_sum = 0;
            resultado_sum = (double) (Numero1 + Numero2);
            return resultado_sum;
        }

        public void imprimir_sum()
        {
           
            
            Console.WriteLine("El resultado de la suma es: " + sumar(PrimerNumero,SegundoNumero));
        }
       



    }
}
