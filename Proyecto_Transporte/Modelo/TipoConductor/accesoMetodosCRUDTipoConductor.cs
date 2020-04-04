using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class accesoMetodosCRUDTipoConductor
    {
        // Operación para insertar datos
        public int InsertarTipoConductor(int Id, string nombre)
        {
            SqlCommand _comandoTipoConductor = MetodosCRUDTipoConductor.InsertarTipoConductor();
            _comandoTipoConductor.Parameters.AddWithValue("@Id", Id);
            _comandoTipoConductor.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDTipoConductor.EjecutarInsertarTipoConductor(_comandoTipoConductor);
        }

        //Operación para consultar

        public static DataTable ConsultandoTipoConductor()
        {

            SqlCommand _comandoTipoConductor = MetodosCRUDTipoConductor.ConsultarTipoConductor();
            _comandoTipoConductor.CommandText = "select * from tipoConductor";
            return MetodosCRUDTipoConductor.EjecutarConsultarTipoConductor(_comandoTipoConductor);
        }

        // Operación para actualizar datos
        public int ActualizarTipoConductor(int Id, string nombre)
        {
            SqlCommand _comandoTipoConductor = MetodosCRUDTipoConductor.ActualizarTipoConductor();
            _comandoTipoConductor.Parameters.AddWithValue("Id", Id);
            _comandoTipoConductor.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDTipoConductor.EjecutarActualizarTipoConductor(_comandoTipoConductor);
        }

        // Operación para eliminar datos
        public int EliminarTipoConductor(int Id)
        {
            SqlCommand _comandoTipoConductor = MetodosCRUDTipoConductor.EliminarTipoConductor();
            _comandoTipoConductor.Parameters.AddWithValue("Id", Id);
            return MetodosCRUDTipoConductor.EjecutarEliminarTipoConductor(_comandoTipoConductor);
        }

    }
}
