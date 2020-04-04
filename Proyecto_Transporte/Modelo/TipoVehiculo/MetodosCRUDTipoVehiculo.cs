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

        //Ejecución del método que se creó para insertar
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

        //método para consultar datos

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

        //ejecución del método que se creó para consultar

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

        //método para actualizar datos utilizando procedimientos almacenados
        public static SqlCommand ActualizarTipoVehiculo()
        {
            string _cadenaConexionTipoVehiculo = configuracion.CadenaConexion;
            SqlConnection _conexionTipoVehiculo = new SqlConnection(_cadenaConexionTipoVehiculo);
            SqlCommand _comandoTipoVehiculo = new SqlCommand("actualizarTipoVehiculo", _conexionTipoVehiculo);
            _comandoTipoVehiculo.CommandType = CommandType.StoredProcedure;
            return _comandoTipoVehiculo;

        }

        //Ejecución del método que se creó para actualizar
        public static int EjecutarActualizarTipoVehiculo(SqlCommand comandoTipoVehiculo)
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

        //método para eliminar datos utilizando procedimientos almacenados
        public static SqlCommand EliminarTipoVehiculo()
        {
            string _cadenaConexionTipoVehiculo = configuracion.CadenaConexion;
            SqlConnection _conexionTipoVehiculo = new SqlConnection(_cadenaConexionTipoVehiculo);
            SqlCommand _comandoTipoVehiculo = new SqlCommand("eliminarTipoVehiculo", _conexionTipoVehiculo);
            _comandoTipoVehiculo.CommandType = CommandType.StoredProcedure;
            return _comandoTipoVehiculo;

        }

        //Ejecución del método que se creó para actualizar
        public static int EjecutarEliminarTipoVehiculo(SqlCommand comandoTipoVehiculo)
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




    }
}
