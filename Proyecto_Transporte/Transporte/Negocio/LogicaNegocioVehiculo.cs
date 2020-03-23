using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LogicaNegocioVehiculo
    {
        public int negociarInsertarVehiculo(int id_vehiculo, string marca, string modelo, string matricula)
        {
            accesoMetodoCRUDvehiculo accesoVehiculo = new accesoMetodoCRUDvehiculo();
            return accesoVehiculo.InsertarVehiculo(id_vehiculo,marca,modelo,matricula);
        }
    }
}
