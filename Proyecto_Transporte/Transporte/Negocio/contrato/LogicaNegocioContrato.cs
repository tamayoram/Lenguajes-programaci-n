using System;
using Modelo.Contrato;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.contrato
{
   public class LogicaNegocioContrato
    {

            //Negociar para insertar
            public int negociarInsertarContrato(int Id, int id_conductor, int id_vehiculo)
            {
                accesoMetodoCRUDContrato accesoContrato = new accesoMetodoCRUDContrato();
                return accesoContrato.InsertarContrato(Id, id_conductor, id_vehiculo);
            }

            //Negociar operación para consultar

            public static DataTable NegociarConsultaContrato()
            {
                return accesoMetodoCRUDContrato.ConsultandoContrato();

            }

            //Negociar operación para actualizar
            public int NegociarActualizarContrato(int Id, int id_conductor, int id_vehiculo)
            {
                accesoMetodoCRUDContrato accesoContrato = new accesoMetodoCRUDContrato();
                return accesoContrato.ActualizarContrato(Id, id_conductor, id_vehiculo);
            }

            //Negociar operación para eliminar
            public int NegociarEliminarContrato(int Id)
            {
                accesoMetodoCRUDContrato accesoContrato = new accesoMetodoCRUDContrato();
                return accesoContrato.EliminarContrato(Id);
            }

            // cargar la información en el control el vehiculo

            public static DataTable negociarListaContratoVehiculos()
            {
                return accesoMetodoCRUDContrato.obtenerListaVehiculo();
            }

            // cargar la información en el control el conductor

            public static DataTable negociarListaContratoConductor()
            {
                return accesoMetodoCRUDContrato.obtenerListaConductor();
            }


    }
}
