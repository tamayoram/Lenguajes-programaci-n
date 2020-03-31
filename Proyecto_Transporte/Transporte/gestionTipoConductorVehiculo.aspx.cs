using Negocio.TipoConductor;
using Negocio.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Transporte
{
    public partial class gestionTipoConductorVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                ListarTipoVehiculo_Click(sender, e);
                ListarTipoConductor_Click(sender, e);
            }
        }

        protected void InsertarTipoConductor_Click(object sender, EventArgs e)
        {
           
            int id_TipoConductor = Int32.Parse(idTipoConductor.Value);
            string nombre_TipoConductor = nombreTipoConductor.Value;
            
            LogicaNegocioTipoConductor negocioTipoConductor = new LogicaNegocioTipoConductor();
            int resultadoTipoConductor= negocioTipoConductor.NegociarInsertarTipoConductor(id_TipoConductor, nombre_TipoConductor);

            if (resultadoTipoConductor > 0)

                lblMensajeTipoConductor.Text = "Registro agregado";
            else
                lblMensajeTipoConductor.Text = "No hay registro";

            negocioTipoConductor = null;

        }

        protected void InsertarTipoVehiculo_Click(object sender, EventArgs e)
        {
           
            int id_TipoVehiculo = Int32.Parse(idTipoVehiculo.Value);
            string nombre_TipoVehiculo = nombreTipoVehiculo.Value;

            LogicaNegocioTipoVehiculo negocioTipoVehiculo = new LogicaNegocioTipoVehiculo();
            int resultadoTipoVehiculo= negocioTipoVehiculo.negociarInsertarTipoVehiculo(id_TipoVehiculo,nombre_TipoVehiculo);

            if (resultadoTipoVehiculo > 0)

                lblMensajeTipoVehiculo.Text = "Registro agregado";
            else
                lblMensajeTipoVehiculo.Text = "No hay registro";

            negocioTipoVehiculo = null;


        }

        protected void ListarTipoVehiculo_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = LogicaNegocioTipoVehiculo.NegociarConsultaTipoVehiculo();
            GridView1.DataBind();
            idTipoVehiculo.Value = nombreTipoVehiculo.Value = "";
        }

        protected void ListarTipoConductor_Click(object sender, EventArgs e)
        {
            GridView.DataSource = LogicaNegocioTipoConductor.NegociarConsultaTipoConductor();
            GridView.DataBind();
            idTipoConductor.Value = nombreTipoConductor.Value = "";
        }
    }
}