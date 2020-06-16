using neighborhoodStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace neighborhoodStore.DAL
{
    public class neighborhoodStoreContext:DbContext       // los dos puntos permiten heredar de la librería Data.Entity la posibilidad de estructurar la base de datos
    {
        public neighborhoodStoreContext(): base("neighborhoodStoreContext")        // constructor para genera la base datos cada vez que se utiliza la aplicación
        {

        }
        
        public DbSet<Product> Products { get; set; } //instrucciones para crear la tabla. Se va a llamar Products a partir del modelo Product
        // se debe conectar con la carpeta modelos
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // se crea una convención para usar siempre nombres en plural. Se debe agregar una librería .Convention.
            //garantiza que los nombres siempre están plurales.
        }

    }
}