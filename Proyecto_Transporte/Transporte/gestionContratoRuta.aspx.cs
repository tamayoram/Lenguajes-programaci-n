using System;
using Negocio.contrato;
using Negocio.ruta;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Transporte
{
    public partial class gestionContratoRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
            
            vehiculoContrato_SelectedIndexChanged(sender, e);                                
            vehiculoRuta_SelectedIndexChanged(sender, e);                                      
            conductorContrato_SelectedIndexChanged(sender, e);
            listarContrato_Click(sender, e);
            listarRuta_Click(sender, e);

            }


        }

        protected void insertarContrato_Click(object sender, EventArgs e)
        {
            int id_contrato = Int32.Parse(idContrato.Value);
            int id_conductor = Int32.Parse(conductorContrato.Text);
            int id_vehiculo = Int32.Parse(vehiculoContrato.Text);
            

            LogicaNegocioContrato negocioContrato = new LogicaNegocioContrato();
            int resultadoContrato = negocioContrato.negociarInsertarContrato(id_contrato,id_conductor,id_vehiculo);

            if (resultadoContrato > 0)

                lblMensajeContrato.Text = "Registro agregado";
            else
                lblMensajeContrato.Text = "No hay registro";

            negocioContrato = null;
        }

                 
          

        protected void listarContrato_Click(object sender, EventArgs e)
        {
                GridViewContrato.DataSource = LogicaNegocioContrato.NegociarConsultaContrato();
                GridViewContrato.DataBind();
                       
        }

        protected void actualizarContrato_Click(object sender, EventArgs e)
        {

            int id_contrato = Int32.Parse(idContrato.Value);
            int id_conductor = Int32.Parse(conductorContrato.Text);
            int id_vehiculo = Int32.Parse(vehiculoContrato.Text);


            LogicaNegocioContrato negocioContrato = new LogicaNegocioContrato();
            int resultadoContrato = negocioContrato.NegociarActualizarContrato(id_contrato, id_conductor, id_vehiculo);

            if (resultadoContrato > 0)

                lblMensajeContrato.Text = "Registro actualizado";
            else
                lblMensajeContrato.Text = "No se realizó la actualización";

            negocioContrato = null;

        }

        protected void eliminarContrato_Click(object sender, EventArgs e)
        {
            int id_contrato = Int32.Parse(idContrato.Value);


            LogicaNegocioContrato negocioContrato = new LogicaNegocioContrato();
            int resultadoContrato = negocioContrato.NegociarEliminarContrato(id_contrato);

            if (resultadoContrato > 0)

                lblMensajeContrato.Text = "Registro eliminado";
            else
                lblMensajeContrato.Text = "No se eliminó el registro";

            negocioContrato = null;

        }

       
        protected void vehiculoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehiculoContrato.DataSource = LogicaNegocioContrato.negociarListaContratoVehiculos();
            vehiculoContrato.DataTextField = "matricula";
            vehiculoContrato.DataValueField = "id_vehiculo";

            vehiculoContrato.DataBind();

        }

        protected void conductorContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            conductorContrato.DataSource = LogicaNegocioContrato.negociarListaContratoConductor();
            conductorContrato.DataTextField = "nombre";
            conductorContrato.DataValueField = "Id";

            conductorContrato.DataBind();

        }


        protected void insertarRuta_Click(object sender, EventArgs e)
        {
            int id_ruta = Int32.Parse(idRuta.Value);
            string descrip_estacion = estacion.Value;
            int id_vehiculo = int.Parse(vehiculoRuta.Text);


            LogicaNegocioRuta negocioRuta = new LogicaNegocioRuta();
            int resultadoRuta = negocioRuta.negociarInsertarRuta(id_ruta, descrip_estacion, id_vehiculo);

            if (resultadoRuta > 0)

                lblMensajeRuta.Text = "Registro agregado";
            else
                lblMensajeRuta.Text = "No hay registro";

            negocioRuta = null;

        }

        protected void actualizarRuta_Click(object sender, EventArgs e)
        {
            int id_ruta = Int32.Parse(idRuta.Value);
            string descrip_estacion = estacion.Value;
            int id_vehiculo = Int32.Parse(vehiculoRuta.Text);
            

            LogicaNegocioRuta negocioRuta = new LogicaNegocioRuta();
            int resultadoRuta = negocioRuta.NegociarActualizarRuta(id_ruta, descrip_estacion, id_vehiculo);

            if (resultadoRuta > 0)

                lblMensajeRuta.Text = "Registro actualizado";
            else
                lblMensajeRuta.Text = "No se realizó la actualización";

            negocioRuta = null;

        }

        protected void listarRuta_Click(object sender, EventArgs e)
        {
            GridViewRuta.DataSource = LogicaNegocioRuta.NegociarConsultaRuta();
            GridViewRuta.DataBind();
        }

        protected void eliminarRuta_Click(object sender, EventArgs e)
        {
            int id_ruta = Int32.Parse(idRuta.Value);


            LogicaNegocioRuta negocioRuta = new LogicaNegocioRuta();
            int resultadoRuta = negocioRuta.NegociarEliminarRuta(id_ruta);

            if (resultadoRuta > 0)

                lblMensajeRuta.Text = "Registro eliminado";
            else
                lblMensajeRuta.Text = "No se eliminó el registro";

            negocioRuta = null;

        }

        protected void vehiculoRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehiculoRuta.DataSource = LogicaNegocioRuta.negociarListaVehiculosRuta();
            vehiculoRuta.DataTextField = "id_vehiculo";
            vehiculoRuta.DataValueField = "id_vehiculo";

            vehiculoRuta.DataBind();

        }
    }
}