
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class logicaNegocioConductor
    {
        public int negociarInsertarConductor(int Id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            accesoMetodoCRUDconductor accesoConductor = new accesoMetodoCRUDconductor();
            return accesoConductor.InsertarConductor(Id, nombre, tipo_licencia, id_vehiculo, id_tipo_conductor);
        }
    }
}
