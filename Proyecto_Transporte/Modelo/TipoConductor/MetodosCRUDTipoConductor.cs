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

        //Ejecución del comando que se creó en el método
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
       
        //Crear tipo comando forma consultar

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

        // ejecutar tipo de comando consulta

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

    }
}
