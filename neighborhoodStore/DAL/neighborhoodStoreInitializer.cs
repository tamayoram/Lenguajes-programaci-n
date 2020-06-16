using neighborhoodStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace neighborhoodStore.DAL
{
    public class neighborhoodStoreInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<neighborhoodStoreContext>  //Esta clase se crea para permitir la inicialización de la tablas en la BD. Hereda propiedades de System.Data.Entity.DropCreateIfModelChange
    {
        protected override void Seed(neighborhoodStoreContext context)
        {
            var products = new List<Product> // se crea el vector que inicializa la tabla. Recordar conectar con la carpeta donde están los modelos.
            {
                new Product{Code=1, Brand="Coke", Description="Coca Cola Light", Presentation="350 ml", Price=1500},
                new Product{Code=2, Brand="Pepsi", Description="Pepsi Light", Presentation="350 ml", Price=1800},
                new Product{Code=3, Brand="Coke", Description="7UP", Presentation="350 ml", Price=2000},
                new Product{Code=4, Brand="Coke", Description="Del Valle", Presentation="350 ml", Price=1500},
                new Product{Code=5, Brand="Postobon", Description="Manzana", Presentation="350 ml", Price=1400}
            };

            products.ForEach(p => context.Products.Add(p)); // la tabla se llama Products y se definió en la clase Context
            context.SaveChanges();

            var costumers = new List<Costumer> // se crea el vector que inicializa la tabla. Recordar conectar con la carpeta donde están los modelos.
            {
                new Costumer{CostumerID=1211,FirstName="Juan", LastName="Tamayo", Address="Transv 5 20-44", Phone=3005962432},// el costumer de esta línea es el del carpeta modelo
                new Costumer{CostumerID=3211,FirstName="Daniel", LastName="Perez", Address="Transv 3 10-44", Phone=3005962788},
                new Costumer{CostumerID=4200,FirstName="Antonio", LastName="Ramirez", Address="Calle 25 20-23", Phone=3105962781},
                new Costumer{CostumerID=3221,FirstName="Claudia", LastName="Castaño", Address="Circular 15 10-14", Phone=3201232785},
                new Costumer{CostumerID=0210,FirstName="Juana", LastName="Lopera", Address="Transv 5 20-44", Phone=3011234568}
            };

            costumers.ForEach(c => context.Costumers.Add(c)); // la tabla se llama Products y se definió en la clase Context
            context.SaveChanges();

            var sales = new List<Sale> // se crea el vector que inicializa la tabla. Recordar conectar con la carpeta donde están los modelos.
            {
                new Sale{ProductID=1,CostumerID=1211, Amount=10, TypeSale=TypeSale.Oro},// el costumer de esta línea es el del carpeta modelo
                new Sale{ProductID=2,CostumerID=3211, Amount=5, TypeSale=TypeSale.Oro},
                new Sale{ProductID=3,CostumerID=4200, Amount=4, TypeSale=TypeSale.Plata},
                new Sale{ProductID=4,CostumerID=3221, Amount=1, TypeSale=TypeSale.Bronce},
                new Sale{ProductID=4,CostumerID=1211, Amount=22, TypeSale=TypeSale.Oro}
            };
            sales.ForEach(s => context.Sales.Add(s)); // la tabla se llama Products y se definió en la clase Context
            context.SaveChanges();
        }
    }
}