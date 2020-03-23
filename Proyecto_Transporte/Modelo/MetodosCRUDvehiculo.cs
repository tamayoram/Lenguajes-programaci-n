using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class MetodosCRUDvehiculo
    {
        //método para insertar datos utilizando procedimientos almacenados
        public static SqlCommand insertarVehiculo()
        {
            string _cadenaConexionVehiculo = configuracion.CadenaConexion;
            SqlConnection _conexionVehiculo = new SqlConnection(_cadenaConexionVehiculo);
            SqlCommand _comandoVehiculo = new SqlCommand("registrarVehiculo", _conexionVehiculo);
            _comandoVehiculo.CommandType = CommandType.StoredProcedure;
            return _comandoVehiculo;

        }

        //Ejecución del comando que se creó en el método
        public static int EjecutarinsertarVehiculo(SqlCommand comandoVehiculo)
        {
            try
            {
                comandoVehiculo.Connection.Open();
                return comandoVehiculo.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoVehiculo.Connection.Dispose();
                comandoVehiculo.Connection.Close();
            }
        }

    }
}
