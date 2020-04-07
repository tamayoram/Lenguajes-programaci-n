﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LogicaNegocioVehiculo
    {
        public int negociarInsertarVehiculo(int id_vehiculo, string marca, string modelo, string matricula)
        {
            accesoMetodoCRUDvehiculo accesoVehiculo = new accesoMetodoCRUDvehiculo();
            return accesoVehiculo.InsertarVehiculo(id_vehiculo,marca,modelo,matricula);
        }

        //Negociar operación para consultar

        public static DataTable NegociarConsultaVehiculo()
        {
            return accesoMetodoCRUDvehiculo.consultarVehiculo();

        }

        //Negociar operación para actualizar
        public int NegociarActualizarVehiculo(int id_vehiculo, string marca, string modelo, string matricula)
        {
            accesoMetodoCRUDvehiculo accesoVehiculo = new accesoMetodoCRUDvehiculo();
            return accesoVehiculo.ActualizarVehiculo(id_vehiculo,marca,modelo,matricula);
        }

        //Negociar operación para eliminar
        public int NegociarEliminarVehiculo(int id_vehiculo)
        {
            accesoMetodoCRUDvehiculo accesoVehiculo = new accesoMetodoCRUDvehiculo ();
            return accesoVehiculo.EliminarVehiculo(id_vehiculo);
        }
    }
}
