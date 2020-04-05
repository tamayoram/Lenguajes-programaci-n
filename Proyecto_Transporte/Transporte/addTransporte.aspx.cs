using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Transporte
{
    public partial class addTransporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                listarConductor_Click(sender, e);
                
            }

        }

        protected void enviarcond_Click(object sender, EventArgs e)
        {
            
            int id_conductor = Int32.Parse(idConductor.Value);
            string nombre_conductor = nombre.Value;
            string tipo_licencia = licencia.Value;
            int id_vehiculo = Int32.Parse(idVehiculoConductor.Value);
            int id_tipo_conductor = Int32.Parse(tipo.Value);

            logicaNegocioConductor negocioConductor = new logicaNegocioConductor();
            int resultadoConductor= negocioConductor.negociarInsertarConductor(id_conductor, nombre_conductor, tipo_licencia, id_vehiculo, id_tipo_conductor);
           
            if (resultadoConductor > 0)

                lblMensajeConductor.Text = "Registro agregado";
            else
                lblMensajeConductor.Text = "No hay registro";

            negocioConductor = null;

        }

        protected void enviarVehiculo_Click(object sender, EventArgs e)
        {
                     
            int id_vehiculo = Int32.Parse(idVehiculo.Value);
            string marca_vehiculo = marca.Value;
            string modelo_vehiculo = modelo.Value;
            string matricula_vehiculo = matricula.Value;
            
            LogicaNegocioVehiculo negocioVehiculo = new LogicaNegocioVehiculo();
            int resultadoVehiculo=negocioVehiculo.negociarInsertarVehiculo(id_vehiculo, marca_vehiculo, modelo_vehiculo, matricula_vehiculo);

            if (resultadoVehiculo > 0)

                lblMensajeVehiculo.Text = "Registro agregado";
            else
                lblMensajeVehiculo.Text = "No hay registro";

            negocioVehiculo = null;
        }

        protected void listarConductor_Click(object sender, EventArgs e)
        {
            GridViewConductor.DataSource = logicaNegocioConductor.NegociarConsultaConductor();
            GridViewConductor.DataBind();
            idConductor.Value = nombre.Value = licencia.Value="";
        }

        protected void actualizarConductor_Click(object sender, EventArgs e)
        {
            int id_Conductor = Int32.Parse(idConductor.Value);
            string nombre_Conductor = nombre.Value;
            string licencia_Conductor = licencia.Value;

            logicaNegocioConductor negocioConductor = new logicaNegocioConductor();
            int resultadoConductor = negocioConductor.NegociarActualizarConductor(id_Conductor, nombre_Conductor,licencia_Conductor);

            if (resultadoConductor > 0)

                lblMensajeConductor.Text = "Registro actualizado";
            else
                lblMensajeConductor.Text = "No se realizó la actualización";

            negocioConductor = null;
        }

        protected void eliminarConductor_Click(object sender, EventArgs e)
        {
            int id_Conductor = Int32.Parse(idConductor.Value);


            logicaNegocioConductor negocioConductor = new logicaNegocioConductor();
            int resultadoConductor = negocioConductor.NegociarEliminarConductor(id_Conductor);

            if (resultadoConductor > 0)

                lblMensajeConductor.Text = "Registro eliminado";
            else
                lblMensajeConductor.Text = "No se eliminó el registro";

            negocioConductor = null;
        }
    }
}