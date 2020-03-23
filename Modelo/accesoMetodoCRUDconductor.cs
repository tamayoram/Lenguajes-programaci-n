using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class accesoMetodoCRUDconductor
    {
        public int InsertarConductor(int Id,string nombre,string tipo_licencia,int id_vehiculo,int id_tipo_conductor)
        {
            SqlCommand _comandoConductor = MetodosCRUDconductor.insertarConductor();
            _comandoConductor.Parameters.AddWithValue("@Id", Id);
            _comandoConductor.Parameters.AddWithValue("@nombre",nombre);
            _comandoConductor.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comandoConductor.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comandoConductor.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDconductor.EjecutarinsertarConductor(_comandoConductor);
        }
    }
}
