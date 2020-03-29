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

    }
}
