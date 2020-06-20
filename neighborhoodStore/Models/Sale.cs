using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace neighborhoodStore.Models

{
   public enum TypeSale
    {
        Oro,Plata,Bronce
    }
    
    public class Sale

    {
        //propiedades o atributos de la clase
        public int SaleID { get; set; }
        public int CostumerID { get; set; }
        public int ProductID { get; set; }
        public TypeSale? TypeSale { get; set; }
        public int Amount { get; set; }

        public virtual Product Product { get; set; } // Conexión con la tabla Product.
        public virtual Costumer Costumer { get; set; } // Conexión con la tabla Costumers.
    }
}