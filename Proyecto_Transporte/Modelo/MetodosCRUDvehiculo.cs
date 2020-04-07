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

        //método para consultar datos

        public static SqlCommand ConsultarVehiculo()
        {
            // usar la conexión
            string _cadenaConexionVehiculo = configuracion.CadenaConexion;
            SqlConnection _conexionVehiculo = new SqlConnection();
            _conexionVehiculo.ConnectionString = _cadenaConexionVehiculo;

            // crear la instrucción para consulta
            SqlCommand _comandoVehiculo = new SqlCommand();
            _comandoVehiculo = _conexionVehiculo.CreateCommand();
            _comandoVehiculo.CommandType = CommandType.Text;
            return _comandoVehiculo;

        }

        //ejecución método que se creó para consultar

        public static DataTable EjecutarConsultarVehiculo(SqlCommand comandoVehiculo)
        {
            DataTable _tablaVehiculo = new DataTable();

            try
            {
                comandoVehiculo.Connection.Open();
                SqlDataAdapter adaptadorVehiculo = new SqlDataAdapter();
                adaptadorVehiculo.SelectCommand = comandoVehiculo;
                adaptadorVehiculo.Fill(_tablaVehiculo);

            }
            catch (Exception Ex) { throw Ex; }

            finally
            {
                comandoVehiculo.Connection.Close();

            }

            return _tablaVehiculo;


        }

        //método para actualizar datos utilizando procedimientos almacenados

        public static SqlCommand ActualizarVehiculo()
        {
            string _cadenaConexionVehiculo = configuracion.CadenaConexion;
            SqlConnection _conexionVehiculo = new SqlConnection(_cadenaConexionVehiculo);
            SqlCommand _comandoVehiculo = new SqlCommand("actualizarVehiculo", _conexionVehiculo);
            _comandoVehiculo.CommandType = CommandType.StoredProcedure;
            return _comandoVehiculo;

        }

        //ejecución método que se creó para actualizar
        public static int EjecutarActualizarVehiculo(SqlCommand comandoVehiculo)
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

        //método para eliminar datos utilizando procedimientos almacenados

        public static SqlCommand EliminarVehiculo()
        {
            string _cadenaConexionVehiculo = configuracion.CadenaConexion;
            SqlConnection _conexionVehiculo = new SqlConnection(_cadenaConexionVehiculo);
            SqlCommand _comandoVehiculo = new SqlCommand("eliminarVehiculo", _conexionVehiculo);
            _comandoVehiculo.CommandType = CommandType.StoredProcedure;
            return _comandoVehiculo;

        }

        //ejecución método que se creó para eliminar
        public static int EjecutarEliminarVehiculo(SqlCommand comandoVehiculo)
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
