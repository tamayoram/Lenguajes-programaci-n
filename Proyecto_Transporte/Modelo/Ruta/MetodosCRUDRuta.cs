using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class MetodosCRUDRuta
    {
        
            //método para insertar datos utilizando procedimientos almacenados
            public static SqlCommand InsertarRuta()
            {
                string _cadenaConexionRuta = configuracion.CadenaConexion;
                SqlConnection _conexionRuta = new SqlConnection(_cadenaConexionRuta);
                SqlCommand _comandoRuta = new SqlCommand("registrarRuta", _conexionRuta);
                _comandoRuta.CommandType = CommandType.StoredProcedure;
                return _comandoRuta;

            }

            //ejecución método que se creó para insertar
            public static int EjecutarInsertarRuta(SqlCommand comandoRuta)
            {
                try
                {
                    comandoRuta.Connection.Open();
                    return comandoRuta.ExecuteNonQuery();
                }
                catch { throw; }
                finally
                {
                    comandoRuta.Connection.Dispose();
                    comandoRuta.Connection.Close();
                }
            }

            //método para consultar datos

            public static SqlCommand ConsultarRuta()
            {
                // usar la conexión
                string _cadenaConexionRuta = configuracion.CadenaConexion;
                SqlConnection _conexionRuta = new SqlConnection();
                _conexionRuta.ConnectionString = _cadenaConexionRuta;

                // crear la instrucción para consulta
                SqlCommand _comandoRuta = new SqlCommand();
                _comandoRuta = _conexionRuta.CreateCommand();
                _comandoRuta.CommandType = CommandType.Text;
                return _comandoRuta;

            }

            //ejecución método que se creó para consultar

            public static DataTable EjecutarConsultarRuta(SqlCommand comandoRuta)
            {
                DataTable _tablaRuta = new DataTable();

                try
                {
                    comandoRuta.Connection.Open();
                    SqlDataAdapter adaptadorRuta = new SqlDataAdapter();
                    adaptadorRuta.SelectCommand = comandoRuta;
                    adaptadorRuta.Fill(_tablaRuta);

                }
                catch (Exception Ex) { throw Ex; }

                finally
                {
                    comandoRuta.Connection.Close();

                }

                return _tablaRuta;


            }

            //método para actualizar datos utilizando procedimientos almacenados

            public static SqlCommand ActualizarRuta()
            {
                string _cadenaConexionRuta = configuracion.CadenaConexion;
                SqlConnection _conexionRuta = new SqlConnection(_cadenaConexionRuta);
                SqlCommand _comandoRuta = new SqlCommand("actualizarRuta", _conexionRuta);
                _comandoRuta.CommandType = CommandType.StoredProcedure;
                return _comandoRuta;

            }

            //ejecución método que se creó para actualizar
            public static int EjecutarActualizarRuta(SqlCommand comandoRuta)
            {
                try
                {
                    comandoRuta.Connection.Open();
                    return comandoRuta.ExecuteNonQuery();
                }
                catch { throw; }
                finally
                {
                    comandoRuta.Connection.Dispose();
                    comandoRuta.Connection.Close();
                }
            }

            //método para eliminar datos utilizando procedimientos almacenados

            public static SqlCommand EliminarRuta()
            {
                string _cadenaConexionRuta = configuracion.CadenaConexion;
                SqlConnection _conexionRuta = new SqlConnection(_cadenaConexionRuta);
                SqlCommand _comandoRuta = new SqlCommand("eliminarRuta", _conexionRuta);
                _comandoRuta.CommandType = CommandType.StoredProcedure;
                return _comandoRuta;

            }

            //ejecución método que se creó para eliminar
            public static int EjecutarEliminarRuta(SqlCommand comandoRuta)
            {
                try
                {
                    comandoRuta.Connection.Open();
                    return comandoRuta.ExecuteNonQuery();
                }
                catch { throw; }
                finally
                {
                    comandoRuta.Connection.Dispose();
                    comandoRuta.Connection.Close();
                }
            }
        
    }
}
