using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class accesoMetodoCRUDRuta
    {
        // Operación para insertar datos
        public int InsertarRuta(int Id, string estacion, int id_vehiculo)
        {
            SqlCommand _comandoRuta = MetodosCRUDRuta.InsertarRuta();
            _comandoRuta.Parameters.AddWithValue("@Id", Id);
            _comandoRuta.Parameters.AddWithValue("@estacion", estacion);
            _comandoRuta.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDRuta.EjecutarInsertarRuta(_comandoRuta);
        }

        //Operación para consultar

        public static DataTable ConsultandoRuta()
        {

            SqlCommand _comandoRuta= MetodosCRUDRuta.ConsultarRuta();
            _comandoRuta.CommandText = "select * from ruta";
            return MetodosCRUDRuta.EjecutarConsultarRuta(_comandoRuta);
        }

        // Operación para actualizar datos
        public int ActualizarRuta(int Id, string estacion, int id_vehiculo)
        {
            SqlCommand _comandoRuta = MetodosCRUDRuta.ActualizarRuta();
            _comandoRuta.Parameters.AddWithValue("Id", Id);
            _comandoRuta.Parameters.AddWithValue("@estacion", estacion);
            _comandoRuta.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDRuta.EjecutarActualizarRuta(_comandoRuta);
        }

        // Operación para eliminar datos
        public int EliminarRuta(int Id)
        {
            SqlCommand _comandoRuta = MetodosCRUDRuta.EliminarRuta();
            _comandoRuta.Parameters.AddWithValue("Id", Id);
            return MetodosCRUDRuta.EjecutarEliminarRuta(_comandoRuta);
        }

        //Cargar el control para listar de vehículos

        public static DataTable obtenerListaVehiculoRuta()
        {
            SqlCommand _comandoRuta = MetodosCRUDvehiculo.ConsultarVehiculo();
            _comandoRuta.CommandText = "select * from vehiculo";
            return MetodosCRUDvehiculo.EjecutarConsultarVehiculo(_comandoRuta);

        }

    }
}
