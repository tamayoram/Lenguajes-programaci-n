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
                listarVehiculo_Click(sender, e);
                idVehiculoConducto_SelectedIndexChanged(sender, e);
                tipoConductor_SelectedIndexChanged(sender, e);
                tipoVehiculo_SelectedIndexChanged(sender, e);
            }

        }

        protected void enviarcond_Click(object sender, EventArgs e)
        {
            
            int id_conductor = Int32.Parse(idConductor.Value);
            string nombre_conductor = nombre.Value;
            string tipo_licencia = licencia.Value;
            int id_vehiculo = Int32.Parse(idVehiculoConducto.Text);
            int id_tipo_conductor = Int32.Parse(tipoConductor.Text);

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
            int id_tipo_vehiculo = Int32.Parse(tipoVehiculo.Text);



            LogicaNegocioVehiculo negocioVehiculo = new LogicaNegocioVehiculo();
            int resultadoVehiculo=negocioVehiculo.negociarInsertarVehiculo(id_vehiculo, marca_vehiculo, modelo_vehiculo, matricula_vehiculo, id_tipo_vehiculo);

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
            int id_vehiculo = Int32.Parse(idVehiculoConducto.Text);
            int id_tipo_conductor = Int32.Parse(tipoConductor.Text);

            logicaNegocioConductor negocioConductor = new logicaNegocioConductor();
            int resultadoConductor = negocioConductor.NegociarActualizarConductor(id_Conductor, nombre_Conductor,licencia_Conductor,id_vehiculo,id_tipo_conductor);

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

        protected void listarVehiculo_Click(object sender, EventArgs e)
        {
            GridViewVehiculo.DataSource = LogicaNegocioVehiculo.NegociarConsultaVehiculo();
            GridViewVehiculo.DataBind();
            idVehiculo.Value = marca.Value = modelo.Value = matricula.Value="";
        }

        protected void actualizarVehiculo_Click(object sender, EventArgs e)
        {
            int id_Vehiculo = Int32.Parse(idVehiculo.Value);
            string marca_Vehiculo = marca.Value;
            string modelo_vehiculo = modelo.Value;
            string matricula_vehiculo = matricula.Value;
            int id_tipo_vehiculo = Int32.Parse(tipoVehiculo.Text);

            LogicaNegocioVehiculo negocioVehiculo = new LogicaNegocioVehiculo();
            int resultadoVehiculo = negocioVehiculo.NegociarActualizarVehiculo(id_Vehiculo,marca_Vehiculo,modelo_vehiculo,matricula_vehiculo,id_tipo_vehiculo);

            if (resultadoVehiculo > 0)

                lblMensajeVehiculo.Text = "Registro actualizado";
            else
                lblMensajeVehiculo.Text = "No se realizó la actualización";

            negocioVehiculo = null;

        }

        protected void eliminarVehiculo_Click(object sender, EventArgs e)
        {
            int id_Vehiculo = Int32.Parse(idVehiculo.Value);


            LogicaNegocioVehiculo negocioVehiculo = new LogicaNegocioVehiculo();
            int resultadoVehiculo = negocioVehiculo.NegociarEliminarVehiculo(id_Vehiculo);

            if (resultadoVehiculo > 0)

                lblMensajeVehiculo.Text = "Registro eliminado";
            else
                lblMensajeVehiculo.Text = "No se eliminó el registro";

            negocioVehiculo = null;

        }

        protected void idVehiculoConducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            idVehiculoConducto.DataSource = logicaNegocioConductor.negociarListaVehiculos();
            idVehiculoConducto.DataTextField = "matricula";
            idVehiculoConducto.DataValueField = "id_vehiculo";

            idVehiculoConducto.DataBind(); 
        }

        protected void tipoConductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoConductor.DataSource = logicaNegocioConductor.negociarListaTipoConductor();
            tipoConductor.DataTextField = "nombre";
            tipoConductor.DataValueField = "Id";

            tipoConductor.DataBind();

        }

        protected void tipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoVehiculo.DataSource = LogicaNegocioVehiculo.negociarListaTipo_Vehiculos();
            tipoVehiculo.DataTextField = "nombre";
            tipoVehiculo.DataValueField = "id_vehiculo";

            tipoVehiculo.DataBind();

        }
    }
}