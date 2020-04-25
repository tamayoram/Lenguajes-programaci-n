using System;
using Modelo.Ruta;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ruta
{
    public class LogicaNegocioRuta
    {

        //Negociar para insertar
        public int negociarInsertarRuta(int Id, string estacion, int id_vehiculo)
        {
            accesoMetodoCRUDRuta accesoRuta = new accesoMetodoCRUDRuta();
            return accesoRuta.InsertarRuta(Id, estacion, id_vehiculo);
        }

        //Negociar operación para consultar

        public static DataTable NegociarConsultaRuta()
        {
            return accesoMetodoCRUDRuta.ConsultandoRuta();

        }

        //Negociar operación para actualizar
        public int NegociarActualizarRuta(int Id, string estacion, int id_vehiculo)
        {
            accesoMetodoCRUDRuta accesoRuta = new accesoMetodoCRUDRuta();
            return accesoRuta.ActualizarRuta(Id, estacion, id_vehiculo);
        }

        //Negociar operación para eliminar
        public int NegociarEliminarRuta(int Id)
        {
            accesoMetodoCRUDRuta accesoRuta = new accesoMetodoCRUDRuta();
            return accesoRuta.EliminarRuta(Id);
        }

        // cargar la información en el control el vehiculo

        public static DataTable negociarListaVehiculosRuta()
        {
            return accesoMetodoCRUDRuta.obtenerListaVehiculoRuta();
        }

        


    }
}
