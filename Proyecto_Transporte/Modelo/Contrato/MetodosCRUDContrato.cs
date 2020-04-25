using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
    public class MetodosCRUDContrato
    {

        //método para insertar datos utilizando procedimientos almacenados
        public static SqlCommand InsertarContrato()
        {
            string _cadenaConexionContrato = configuracion.CadenaConexion;
            SqlConnection _conexionContrato = new SqlConnection(_cadenaConexionContrato);
            SqlCommand _comandoContrato = new SqlCommand("registrarContrato", _conexionContrato);
            _comandoContrato.CommandType = CommandType.StoredProcedure;
            return _comandoContrato;

        }

        //ejecución método que se creó para insertar
        public static int EjecutarInsertarContrato(SqlCommand comandoContrato)
        {
            try
            {
                comandoContrato.Connection.Open();
                return comandoContrato.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoContrato.Connection.Dispose();
                comandoContrato.Connection.Close();
            }
        }

        //método para consultar datos

        public static SqlCommand ConsultarContrato()
        {
            // usar la conexión
            string _cadenaConexionContrato = configuracion.CadenaConexion;
            SqlConnection _conexionContrato = new SqlConnection();
            _conexionContrato.ConnectionString = _cadenaConexionContrato;

            // crear la instrucción para consulta
            SqlCommand _comandoContrato = new SqlCommand();
            _comandoContrato = _conexionContrato.CreateCommand();
            _comandoContrato.CommandType = CommandType.Text;
            return _comandoContrato;

        }

        //ejecución método que se creó para consultar

        public static DataTable EjecutarConsultarContrato(SqlCommand comandoContrato)
        {
            DataTable _tablaContrato = new DataTable();

            try
            {
                comandoContrato.Connection.Open();
                SqlDataAdapter adaptadorContrato = new SqlDataAdapter();
                adaptadorContrato.SelectCommand = comandoContrato;
                adaptadorContrato.Fill(_tablaContrato);

            }
            catch (Exception Ex) { throw Ex; }

            finally
            {
                comandoContrato.Connection.Close();

            }

            return _tablaContrato;


        }

        //método para actualizar datos utilizando procedimientos almacenados

        public static SqlCommand ActualizarContrato()
        {
            string _cadenaConexionContrato = configuracion.CadenaConexion;
            SqlConnection _conexionContrato = new SqlConnection(_cadenaConexionContrato);
            SqlCommand _comandoContrato = new SqlCommand("actualizarContrato", _conexionContrato);
            _comandoContrato.CommandType = CommandType.StoredProcedure;
            return _comandoContrato;

        }

        //ejecución método que se creó para actualizar
        public static int EjecutarActualizarContrato(SqlCommand comandoContrato)
        {
            try
            {
                comandoContrato.Connection.Open();
                return comandoContrato.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoContrato.Connection.Dispose();
                comandoContrato.Connection.Close();
            }
        }

        //método para eliminar datos utilizando procedimientos almacenados

        public static SqlCommand EliminarContrato()
        {
            string _cadenaConexionContrato = configuracion.CadenaConexion;
            SqlConnection _conexionContrato = new SqlConnection(_cadenaConexionContrato);
            SqlCommand _comandoContrato = new SqlCommand("eliminarContrato", _conexionContrato);
            _comandoContrato.CommandType = CommandType.StoredProcedure;
            return _comandoContrato;

        }

        //ejecución método que se creó para eliminar
        public static int EjecutarEliminarContrato(SqlCommand comandoContrato)
        {
            try
            {
                comandoContrato.Connection.Open();
                return comandoContrato.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoContrato.Connection.Dispose();
                comandoContrato.Connection.Close();
            }
        }


    }
}
