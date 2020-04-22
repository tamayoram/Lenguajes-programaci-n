using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
    public class accesoMetodoCRUDContrato
    {

        // Operación para insertar datos
        public int InsertarContrato(int Id, int id_conductor, int id_vehiculo)
        {
            SqlCommand _comandoContrato = MetodosCRUDContrato.InsertarContrato();
            _comandoContrato.Parameters.AddWithValue("@Id", Id);
            _comandoContrato.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comandoContrato.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDContrato.EjecutarInsertarContrato(_comandoContrato);
        }

        //Operación para consultar

        public static DataTable ConsultandoContrato()
        {

            SqlCommand _comandoContrato = MetodosCRUDContrato.ConsultarContrato();
            _comandoContrato.CommandText = "select * from contrato";
            return MetodosCRUDContrato.EjecutarConsultarContrato(_comandoContrato);
        }

        // Operación para actualizar datos
        public int ActualizarContrato(int Id, int id_conductor, int id_vehiculo)
        {
            SqlCommand _comandoContrato = MetodosCRUDContrato.ActualizarContrato();
            _comandoContrato.Parameters.AddWithValue("Id", Id);
            _comandoContrato.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comandoContrato.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            return MetodosCRUDContrato.EjecutarActualizarContrato(_comandoContrato);
        }

        // Operación para eliminar datos
        public int EliminarContrato(int Id)
        {
            SqlCommand _comandoContrato = MetodosCRUDContrato.EliminarContrato();
            _comandoContrato.Parameters.AddWithValue("Id", Id);
            return MetodosCRUDContrato.EjecutarEliminarContrato(_comandoContrato);
        }

        //Cargar el control para listar de vehículos

        public static DataTable obtenerListaVehiculo()
        {
            SqlCommand _comando = MetodosCRUDvehiculo.ConsultarVehiculo();
            _comando.CommandText = "select * from vehiculo";
            return MetodosCRUDvehiculo.EjecutarConsultarVehiculo(_comando);

        }

        //Cargar el control para listar de conductores

        public static DataTable obtenerListaConductor()
        {
            SqlCommand _comando = MetodosCRUDconductor.ConsultarConductor();
            _comando.CommandText = "select * from conductor";
            return MetodosCRUDconductor.EjecutarConsultarConductor(_comando);

        }

    }
}
