using System;

namespace OperacionesAritmeticas_return
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Ingrese el primer número:");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Ingrese el segundo número:");
            //double num2 = double.Parse(Console.ReadLine());

            ////Creación del objeto que hereda las propiedades de la clase

            //var operacion = new operacion_aritmetica()
            //{

            //    PrimerNumero=num1,SegundoNumero=num2

            //};
            ////operacion.sumar(operacion.PrimerNumero, operacion.SegundoNumero);

            //operacion.imprimir_sum();

            //----------------------------------------------------------------------------------------

            Console.Write("Tipos de proyectos: ");
            string projectType = Console.ReadLine();

            var ProjectPrice = new projects()
            {
                projectType = projectType
            
            };

            //ProjectPrice.PriceProject(ProjectPrice.projectType);

            ProjectPrice.imprimir();


        }
    }
}
