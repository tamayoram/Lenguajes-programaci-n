using System;

namespace Tarifahotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo_habitacion="Inicio";
            int cant_dias;

            while (tipo_habitacion != "Fin" && tipo_habitacion!="FIN" && tipo_habitacion!="fin") 
            {

                Console.Write("Ingrese la cantidad de días que va a permanecer en el hotel: ");
                cant_dias = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el tipo de habitación que desea (Individual/Doble/Familiar) o (Fin) para cerrar: ");
                tipo_habitacion = Console.ReadLine();
                           

                // Instanciar la clase para recibir los datos y realizar las operaciones. Crear el objeto que recibe las características de la clase

                var CobroHospedaje = new Acomodacion()
                {

                    tipoHabitacion = tipo_habitacion, cantidadDias = cant_dias
                        
                };

                CobroHospedaje.PrecioDescuento(CobroHospedaje.tipoHabitacion);
            }
        }
    }
}
