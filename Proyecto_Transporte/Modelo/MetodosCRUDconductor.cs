using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class MetodosCRUDconductor
    {
        //método para insertar datos utilizando procedimientos almacenados
        public static SqlCommand insertarConductor()
        {
            string _cadenaConexionConductor = configuracion.CadenaConexion;
            SqlConnection _conexionConductor = new SqlConnection(_cadenaConexionConductor);
            SqlCommand _comandoConductor = new SqlCommand("registrarConductor", _conexionConductor);
            _comandoConductor.CommandType = CommandType.StoredProcedure;
            return _comandoConductor;

        }

        //Ejecución del método que se creó para insertar
        public static int EjecutarinsertarConductor(SqlCommand comandoConductor)
        {
            try
            {
                comandoConductor.Connection.Open();
                return comandoConductor.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoConductor.Connection.Dispose();
                comandoConductor.Connection.Close();
            }
        }

        //método para consultar datos

        public static SqlCommand ConsultarConductor()
        {
            // usar la conexión
            string _cadenaConexionConductor = configuracion.CadenaConexion;
            SqlConnection _conexionConductor = new SqlConnection();
            _conexionConductor.ConnectionString = _cadenaConexionConductor;

            // crear la instrucción para consulta
            SqlCommand _comandoConductor = new SqlCommand();
            _comandoConductor = _conexionConductor.CreateCommand();
            _comandoConductor.CommandType = CommandType.Text;
            return _comandoConductor;

        }

        //ejecución método que se creó para consultar

        public static DataTable EjecutarConsultarConductor(SqlCommand comandoConductor)
        {
            DataTable _tablaConductor = new DataTable();

            try
            {
                comandoConductor.Connection.Open();
                SqlDataAdapter adaptadorConductor = new SqlDataAdapter();
                adaptadorConductor.SelectCommand = comandoConductor;
                adaptadorConductor.Fill(_tablaConductor);

            }
            catch (Exception Ex) { throw Ex; }

            finally
            {
                comandoConductor.Connection.Close();

            }

            return _tablaConductor;


        }

        //método para actualizar datos utilizando procedimientos almacenados

        public static SqlCommand ActualizarConductor()
        {
            string _cadenaConexionConductor = configuracion.CadenaConexion;
            SqlConnection _conexionConductor = new SqlConnection(_cadenaConexionConductor);
            SqlCommand _comandoConductor = new SqlCommand("actualizarConductor", _conexionConductor);
            _comandoConductor.CommandType = CommandType.StoredProcedure;
            return _comandoConductor;

        }

        //ejecución método que se creó para actualizar
        public static int EjecutarActualizarConductor(SqlCommand comandoConductor)
        {
            try
            {
                comandoConductor.Connection.Open();
                return comandoConductor.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoConductor.Connection.Dispose();
                comandoConductor.Connection.Close();
            }
        }

        //método para eliminar datos utilizando procedimientos almacenados

        public static SqlCommand EliminarConductor()
        {
            string _cadenaConexionConductor = configuracion.CadenaConexion;
            SqlConnection _conexionConductor = new SqlConnection(_cadenaConexionConductor);
            SqlCommand _comandoConductor = new SqlCommand("eliminarConductor", _conexionConductor);
            _comandoConductor.CommandType = CommandType.StoredProcedure;
            return _comandoConductor;

        }

        //ejecución método que se creó para eliminar
        public static int EjecutarEliminarConductor(SqlCommand comandoConductor)
        {
            try
            {
                comandoConductor.Connection.Open();
                return comandoConductor.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoConductor.Connection.Dispose();
                comandoConductor.Connection.Close();
            }
        }

    }
}
