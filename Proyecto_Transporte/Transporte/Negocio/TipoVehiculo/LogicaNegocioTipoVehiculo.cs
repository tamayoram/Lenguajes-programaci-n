using Modelo.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.TipoVehiculo
{
    public class LogicaNegocioTipoVehiculo
    {
        //Negociar operación para insertar
        public int negociarInsertarTipoVehiculo(int id_vehiculo, string nombre)
        {
            accesoMetodosCRUDTipoVehiculo accesoTipoVehiculo = new accesoMetodosCRUDTipoVehiculo();
            return accesoTipoVehiculo.InsertarTipoVehiculo(id_vehiculo, nombre);
        }

        //Negociar operación para consultar

        public static DataTable NegociarConsultaTipoVehiculo()
        {
            return accesoMetodosCRUDTipoVehiculo.ConsultandoTipoVehiculo();

        }


    }


}
