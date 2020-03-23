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

        //Ejecución del comando que se creó en el método
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


    }
}
