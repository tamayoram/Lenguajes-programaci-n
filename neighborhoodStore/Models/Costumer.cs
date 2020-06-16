using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace neighborhoodStore.Models
{
    public class Costumer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Impide que se genere el ID de forma automatica. Para utilizarla se debe importar la librería Schema que se ve en la parte de arriba.
        public int CostumerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double Phone { get; set; }

        public virtual ICollection<Sale> Sales { get; set; } // Conexión con la tabla Sales.
    }
}