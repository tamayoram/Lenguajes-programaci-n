using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
   public class MetodosCRUDTipoVehiculo
    {
        //método para insertar datos utilizando procedimientos almacenados
        public static SqlCommand InsertarTipoVehiculo()
        {
            string _cadenaConexionTipoVehiculo = configuracion.CadenaConexion;
            SqlConnection _conexionTipoVehiculo = new SqlConnection(_cadenaConexionTipoVehiculo);
            SqlCommand _comandoTipoVehiculo = new SqlCommand("registrarTipoVehiculo", _conexionTipoVehiculo);
            _comandoTipoVehiculo.CommandType = CommandType.StoredProcedure;
            return _comandoTipoVehiculo;

        }

        //Ejecución del comando que se creó en el método
        public static int EjecutarinsertarTipoVehiculo(SqlCommand comandoTipoVehiculo)
        {
            try
            {
                comandoTipoVehiculo.Connection.Open();
                return comandoTipoVehiculo.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoTipoVehiculo.Connection.Dispose();
                comandoTipoVehiculo.Connection.Close();
            }
        }

        //Crear tipo comando forma consultar

        public static SqlCommand ConsultarTipoVehiculo()
        {
            // usar la conexión
            string _cadenaConexionTipoVehiculo = configuracion.CadenaConexion;
            SqlConnection _conexionTipoVehiculo = new SqlConnection();
            _conexionTipoVehiculo.ConnectionString = _cadenaConexionTipoVehiculo;

            // crear la instrucción para consulta
            SqlCommand _comandTipoVehiculo = new SqlCommand();
            _comandTipoVehiculo = _conexionTipoVehiculo.CreateCommand();
            _comandTipoVehiculo.CommandType = CommandType.Text;
            return _comandTipoVehiculo;

        }

        // ejecutar tipo de comando consulta

        public static DataTable EjecutarConsultarTipoVehiculo(SqlCommand comandoTipoVehiculo)
        {
            DataTable _tablaTipoVehiculo = new DataTable();

            try
            {
                comandoTipoVehiculo.Connection.Open();
                SqlDataAdapter adaptadorTipoVehiculo = new SqlDataAdapter();
                adaptadorTipoVehiculo.SelectCommand = comandoTipoVehiculo;
                adaptadorTipoVehiculo.Fill(_tablaTipoVehiculo);

            }
            catch (Exception Ex) { throw Ex; }

            finally
            {
                comandoTipoVehiculo.Connection.Close();

            }

            return _tablaTipoVehiculo;


        }



    }
}
