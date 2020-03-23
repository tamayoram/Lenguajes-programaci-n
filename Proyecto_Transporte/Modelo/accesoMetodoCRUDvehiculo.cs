using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class accesoMetodoCRUDvehiculo
    {
        public int InsertarVehiculo(int id_vehiculo, string marca, string modelo, string matricula)
        {
            SqlCommand _comandoVehiculo = MetodosCRUDvehiculo.insertarVehiculo();
            _comandoVehiculo.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comandoVehiculo.Parameters.AddWithValue("@marca", marca);
            _comandoVehiculo.Parameters.AddWithValue("@modelo", modelo);
            _comandoVehiculo.Parameters.AddWithValue("@matricula", matricula);
            
           return MetodosCRUDvehiculo.EjecutarinsertarVehiculo(_comandoVehiculo);
        }
    }
}
