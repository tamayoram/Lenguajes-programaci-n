using System;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cordial saludo");

            Console.Write("Ingrese el tipo de evento que desea cotizar (empresarial, exhibicion o congreso): ");
            string tipo_evento = Console.ReadLine();

            Console.Write("Ingrese el número de empleados de su empresa (la cantidad de empleados determina el descuento): ");
            int empleados = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la ubicación del evento (nacional/internacional): ");
            string ubicacionEvento = Console.ReadLine();

            //instanciar la clase

            var pagoEvento = new valorEvento()
            {

                tipoEvento = tipo_evento,
                cantidadEmpleados = empleados
            };

            Console.WriteLine("El valor sin descuento de su evento es de " + pagoEvento.precioEvento(pagoEvento.tipoEvento));
            pagoEvento.descuento(pagoEvento.cantidadEmpleados);

            if (tipo_evento == "empresarial"||tipo_evento=="Empresarial"||tipo_evento=="EMPRESARIAL") { 
            
            var categoriaEmpresarial = new empresarial()
            {
                ubicacion = ubicacionEvento
            };

            Console.Write("El evento " + tipo_evento + " " + categoriaEmpresarial.ubicacion);categoriaEmpresarial.reconocer();
            Console.WriteLine(" ");
                Console.Write(categoriaEmpresarial.categorizar());

            
            }

            if (tipo_evento == "exhibicion" || tipo_evento == "Exhibicion" || tipo_evento == "EXHIBICION")
            {

                var categoriaExhibicion = new exhibicion()
                {
                    ubicacion = ubicacionEvento
                };

                Console.Write("El evento " + tipo_evento + " " + categoriaExhibicion.ubicacion); categoriaExhibicion.reconocer();
                Console.WriteLine(" ");
                Console.Write(categoriaExhibicion.categorizar());


            }

            if (tipo_evento == "Congreso" || tipo_evento == "congreso" || tipo_evento == "CONGRESO")
            {

                var categoriaCongreso = new congreso()
                {
                    ubicacion = ubicacionEvento
                };

                Console.Write("El evento " + tipo_evento + " " + categoriaCongreso.ubicacion); categoriaCongreso.reconocer();
                Console.WriteLine(" ");
                Console.Write(categoriaCongreso.categorizar());


            }
        }
    }
}
