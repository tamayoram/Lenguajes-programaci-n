using Modelo.TipoConductor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   
    //Operación para insertar
    public class accesoMetodoCRUDconductor
    {
        public int InsertarConductor(int Id,string nombre,string tipo_licencia,int id_vehiculo,int id_tipo_conductor)
        {
            SqlCommand _comandoConductor = MetodosCRUDconductor.insertarConductor();
            _comandoConductor.Parameters.AddWithValue("@Id", Id);
            _comandoConductor.Parameters.AddWithValue("@nombre",nombre);
            _comandoConductor.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comandoConductor.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comandoConductor.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDconductor.EjecutarinsertarConductor(_comandoConductor);
        }
    

        //Operación para consultar

        public static DataTable consultandoConductor()
        {

            SqlCommand _comandoConductor = MetodosCRUDconductor.ConsultarConductor();
            _comandoConductor.CommandText = "select Id,nombre,tipo_licencia from conductor";
            return MetodosCRUDconductor.EjecutarConsultarConductor(_comandoConductor);
        }

        // Operación para actualizar datos
        public int ActualizarConductor(int Id, string nombre,string tipo_licencia)
        {
            SqlCommand _comandoConductor = MetodosCRUDconductor.ActualizarConductor();
            _comandoConductor.Parameters.AddWithValue("Id", Id);
            _comandoConductor.Parameters.AddWithValue("@nombre", nombre);
            _comandoConductor.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);

            return MetodosCRUDconductor.EjecutarActualizarConductor(_comandoConductor);
        }

        // Operación para eliminar datos
        public int EliminarTipoConductor(int Id)
        {
            SqlCommand _comandoConductor = MetodosCRUDconductor.EliminarConductor();
            _comandoConductor.Parameters.AddWithValue("Id", Id);
            return MetodosCRUDconductor.EjecutarEliminarConductor(_comandoConductor);
        }

        //Cargar el control para listar tipo de vehículos

        public static DataTable obtenerListaTipoVehiculo()
        {
            SqlCommand _comando = MetodosCRUDvehiculo.ConsultarVehiculo();
            _comando.CommandText = "select * from vehiculo";
            return MetodosCRUDvehiculo.EjecutarConsultarVehiculo(_comando);

        }

        //Cargar el control para listar tipo de conductor

        public static DataTable obtenerListaTipoConductor()
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.ConsultarTipoConductor();
            _comando.CommandText = "select * from tipoConductor";
            return MetodosCRUDTipoConductor.EjecutarConsultarTipoConductor(_comando);

        }


    }


}
