using System;

namespace ejemploDomestico
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo= "inicio";
            
            while (tipo != "*")
            {
            Console.WriteLine("");
            Console.Write("Perro o Gato (escriba * para salir)?");
            tipo = Console.ReadLine();
                           

            if (tipo == "*")
            {
                Console.Write("Chao");
                Environment.Exit(1);
            }
            else
            {
                           
            Console.WriteLine();
            Console.Write("Nombre: ");
            string Nombre = Console.ReadLine();

            Console.Write("Raza: ");
            string Raza = Console.ReadLine();

            Console.Write("Género: ");
            char Genero = char.Parse(Console.ReadLine());

            switch (tipo) {

                case "Gato":
                case "gato":
            //Instanciar la clase

            // gato y perro están heredando propiedades de animalDomestico
            var miGato = new gato()
            {
                nombre = Nombre,
                raza = Raza,
                genero = Genero

            };

            // Mostrar datos del gato

            // Para concatenar la función se debe poner por fuera

            //Console.Write("Mi gato" + " "+ miGato.nombre+" "); miGato.correr();
            //Console.WriteLine(" ");
            //Console.Write("Mi gato hace "); miGato.sonar();

            Console.Write("Mi gato " + " " + miGato.nombre + " ");miGato.correr();
            Console.WriteLine(" ");
            Console.Write("Mi gato hace " + miGato.sonar());
                    break;

                case "perro":
                case "Perro":

            var miPerro = new perro()
            {
                nombre = Nombre,
                raza = Raza,
                genero = Genero
                
            };
            ////Console.WriteLine(" ");
            ////Console.Write("El perro "); miPerro.correr();
            ////Console.WriteLine(" ");
            ////Console.Write("El perro hace "); miPerro.sonar();

            Console.WriteLine(" ");
            Console.Write("Mi perro "+miPerro.nombre+" "); miPerro.correr();
            Console.WriteLine(" ");
            Console.Write("Mi perro "+miPerro.raza+" hace "+miPerro.sonar());
                    break;

                default:
                    Console.Write("La mascota debe ser perro o gato");
                    break;
            }
            }
            }

        }
    }
}
