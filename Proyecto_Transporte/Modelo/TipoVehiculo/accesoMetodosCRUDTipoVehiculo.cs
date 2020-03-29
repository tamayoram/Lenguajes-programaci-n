using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class accesoMetodosCRUDTipoVehiculo
    {
        public int InsertarTipoVehiculo(int id_vehiculo, string nombre)
        {
            SqlCommand _comandoTipoVehiculo = MetodosCRUDTipoVehiculo.InsertarTipoVehiculo();
            _comandoTipoVehiculo.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comandoTipoVehiculo.Parameters.AddWithValue("@nombre", nombre);


            return MetodosCRUDTipoVehiculo.EjecutarinsertarTipoVehiculo(_comandoTipoVehiculo);
        }

        //Operación para consultar

        public static DataTable ConsultandoTipoVehiculo()
        {

            SqlCommand _comandoTipoVehiculo = MetodosCRUDTipoVehiculo.ConsultarTipoVehiculo();
            _comandoTipoVehiculo.CommandText = "select * from tipoVehiculo";
            return MetodosCRUDTipoVehiculo.EjecutarConsultarTipoVehiculo(_comandoTipoVehiculo);
        }



    }
}
