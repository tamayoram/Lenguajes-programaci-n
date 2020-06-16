using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace neighborhoodStore.Models
{
    public class Product
    {
        //Propiedades o atributos de la clase
        public int ProductID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public string Presentation { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public virtual ICollection<Sale> Sales { get; set; } // Conexión con la tabla Sales.
    }
}