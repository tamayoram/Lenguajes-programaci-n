using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class MetodosCRUDTipoConductor
    {
        //método para insertar datos utilizando procedimientos almacenados
        public static SqlCommand InsertarTipoConductor()
        {
            string _cadenaConexionTipoConductor = configuracion.CadenaConexion;
            SqlConnection _conexionTipoConductor = new SqlConnection(_cadenaConexionTipoConductor);
            SqlCommand _comandoTipoConductor = new SqlCommand("registrarTipoConductor", _conexionTipoConductor);
            _comandoTipoConductor.CommandType = CommandType.StoredProcedure;
            return _comandoTipoConductor;

        }

        //ejecución método que se creó para insertar
        public static int EjecutarInsertarTipoConductor(SqlCommand comandoTipoConductor)
        {
            try
            {
                comandoTipoConductor.Connection.Open();
                return comandoTipoConductor.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoTipoConductor.Connection.Dispose();
                comandoTipoConductor.Connection.Close();
            }
        }
       
        //método para consultar datos

        public static SqlCommand ConsultarTipoConductor()
        {
            // usar la conexión
            string _cadenaConexionTipoConductor = configuracion.CadenaConexion;
            SqlConnection _conexionTipoConductor = new SqlConnection();
            _conexionTipoConductor.ConnectionString = _cadenaConexionTipoConductor;

            // crear la instrucción para consulta
            SqlCommand _comandTipoConductor = new SqlCommand();
            _comandTipoConductor = _conexionTipoConductor.CreateCommand();
            _comandTipoConductor.CommandType = CommandType.Text;
            return _comandTipoConductor;
            
        }

        //ejecución método que se creó para consultar

        public static DataTable EjecutarConsultarTipoConductor(SqlCommand comandoTipoConductor)
        {
            DataTable _tablaTipoConductor = new DataTable();

            try
            {
                comandoTipoConductor.Connection.Open();
                SqlDataAdapter adaptadorTipoConductor = new SqlDataAdapter();
                adaptadorTipoConductor.SelectCommand = comandoTipoConductor;
                adaptadorTipoConductor.Fill(_tablaTipoConductor);

            }
            catch (Exception Ex) { throw Ex; }
            
            finally
            {
                comandoTipoConductor.Connection.Close();

            }

            return _tablaTipoConductor;


        }

        //método para actualizar datos utilizando procedimientos almacenados

        public static SqlCommand ActualizarTipoConductor()
        {
            string _cadenaConexionTipoConductor = configuracion.CadenaConexion;
            SqlConnection _conexionTipoConductor = new SqlConnection(_cadenaConexionTipoConductor);
            SqlCommand _comandoTipoConductor = new SqlCommand("actualizarTipoConductor", _conexionTipoConductor);
            _comandoTipoConductor.CommandType = CommandType.StoredProcedure;
            return _comandoTipoConductor;

        }

        //ejecución método que se creó para actualizar
        public static int EjecutarActualizarTipoConductor(SqlCommand comandoTipoConductor)
        {
            try
            {
                comandoTipoConductor.Connection.Open();
                return comandoTipoConductor.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoTipoConductor.Connection.Dispose();
                comandoTipoConductor.Connection.Close();
            }
        }

        //método para eliminar datos utilizando procedimientos almacenados

        public static SqlCommand EliminarTipoConductor()
        {
            string _cadenaConexionTipoConductor = configuracion.CadenaConexion;
            SqlConnection _conexionTipoConductor = new SqlConnection(_cadenaConexionTipoConductor);
            SqlCommand _comandoTipoConductor = new SqlCommand("eliminarTipoConductor", _conexionTipoConductor);
            _comandoTipoConductor.CommandType = CommandType.StoredProcedure;
            return _comandoTipoConductor;

        }

        //ejecución método que se creó para eliminar
        public static int EjecutarEliminarTipoConductor(SqlCommand comandoTipoConductor)
        {
            try
            {
                comandoTipoConductor.Connection.Open();
                return comandoTipoConductor.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoTipoConductor.Connection.Dispose();
                comandoTipoConductor.Connection.Close();
            }
        }



    }
}
