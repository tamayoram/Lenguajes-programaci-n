
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class logicaNegocioConductor
    {
        //Negociar para insertar
        public int negociarInsertarConductor(int Id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            accesoMetodoCRUDconductor accesoConductor = new accesoMetodoCRUDconductor();
            return accesoConductor.InsertarConductor(Id, nombre, tipo_licencia, id_vehiculo, id_tipo_conductor);
        }

        //Negociar operación para consultar

        public static DataTable NegociarConsultaConductor()
        {
            return accesoMetodoCRUDconductor.consultandoConductor();

        }

        //Negociar operación para actualizar
        public int NegociarActualizarConductor(int Id, string nombre,string tipo_licencia)
        {
            accesoMetodoCRUDconductor accesoConductor = new accesoMetodoCRUDconductor();
            return accesoConductor.ActualizarConductor(Id, nombre,tipo_licencia);
        }

        //Negociar operación para eliminar
        public int NegociarEliminarConductor(int Id)
        {
            accesoMetodoCRUDconductor accesoConductor = new accesoMetodoCRUDconductor();
            return accesoConductor.EliminarTipoConductor(Id);
        }

        // cargar la información en el control de tipo de vehiculo

        public static DataTable negociarListaVehiculos()
        {
            return accesoMetodoCRUDconductor.obtenerListaTipoVehiculo();
        }

        // cargar la información en el control de tipo de conductor

        public static DataTable negociarListaTipoConductor()
        {
            return accesoMetodoCRUDconductor.obtenerListaTipoConductor();
        }
    }
}
