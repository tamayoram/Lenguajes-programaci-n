using Modelo.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class accesoMetodoCRUDvehiculo
    {
        public int InsertarVehiculo(int id_vehiculo, string marca, string modelo, string matricula,int id_tipo_vehiculo)
        {
            SqlCommand _comandoVehiculo = MetodosCRUDvehiculo.insertarVehiculo();
            _comandoVehiculo.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comandoVehiculo.Parameters.AddWithValue("@marca", marca);
            _comandoVehiculo.Parameters.AddWithValue("@modelo", modelo);
            _comandoVehiculo.Parameters.AddWithValue("@matricula", matricula);
            _comandoVehiculo.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo);

            return MetodosCRUDvehiculo.EjecutarinsertarVehiculo(_comandoVehiculo);
        }

        //Operación para consultar

        public static DataTable consultarVehiculo()
        {

            SqlCommand _comandoVehiculo = MetodosCRUDvehiculo.ConsultarVehiculo();
            _comandoVehiculo.CommandText = "select id_vehiculo,marca,modelo,matricula from vehiculo";
            return MetodosCRUDvehiculo.EjecutarConsultarVehiculo(_comandoVehiculo);
        }

        // Operación para actualizar datos
        public int ActualizarVehiculo(int id_vehiculo, string marca, string modelo, string matricula, int id_tipo_vehiculo)
        {
            SqlCommand _comandoVehiculo = MetodosCRUDvehiculo.ActualizarVehiculo();
            _comandoVehiculo.Parameters.AddWithValue("id_vehiculo", id_vehiculo);
            _comandoVehiculo.Parameters.AddWithValue("@marca", marca);
            _comandoVehiculo.Parameters.AddWithValue("@modelo",modelo);
            _comandoVehiculo.Parameters.AddWithValue("@matricula", matricula);
            _comandoVehiculo.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo);

            return MetodosCRUDvehiculo.EjecutarActualizarVehiculo(_comandoVehiculo);
        }

        // Operación para eliminar datos
        public int EliminarVehiculo(int id_vehiculo)
        {
            SqlCommand _comandoVehiculo = MetodosCRUDvehiculo.EliminarVehiculo();
            _comandoVehiculo.Parameters.AddWithValue("id_vehiculo", id_vehiculo);
            return MetodosCRUDvehiculo.EjecutarEliminarVehiculo(_comandoVehiculo);
        }

        //Cargar el control para listar tipo de vehículos

        public static DataTable obtenerListaTipo_Vehiculo()
        {
            SqlCommand _comando = MetodosCRUDTipoVehiculo.ConsultarTipoVehiculo();
            _comando.CommandText = "select * from tipoVehiculo";
            return MetodosCRUDTipoVehiculo.EjecutarConsultarTipoVehiculo(_comando);

        }
    }
}
