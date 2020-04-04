using Modelo.TipoConductor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.TipoConductor
{
    public class LogicaNegocioTipoConductor
    {
        //Negociar operación para insertar
        public int NegociarInsertarTipoConductor(int Id, string nombre)
        {
            accesoMetodosCRUDTipoConductor accesoTipoConductor = new accesoMetodosCRUDTipoConductor();
            return accesoTipoConductor.InsertarTipoConductor(Id, nombre);
        }

        //Negociar operación para consultar

        public static DataTable NegociarConsultaTipoConductor()
        {
            return accesoMetodosCRUDTipoConductor.ConsultandoTipoConductor();

        }

        //Negociar operación para actualizar
        public int NegociarActualizarTipoConductor(int Id, string nombre)
        {
            accesoMetodosCRUDTipoConductor accesoTipoConductor = new accesoMetodosCRUDTipoConductor();
            return accesoTipoConductor.ActualizarTipoConductor(Id, nombre);
        }

        //Negociar operación para eliminar
        public int NegociarEliminarTipoConductor(int Id)
        {
            accesoMetodosCRUDTipoConductor accesoTipoConductor = new accesoMetodosCRUDTipoConductor();
            return accesoTipoConductor.EliminarTipoConductor(Id);
        }
    }
}
