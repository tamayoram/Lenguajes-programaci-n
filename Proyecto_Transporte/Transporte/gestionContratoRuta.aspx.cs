using System;
using Negocio.contrato;
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

        }

        protected void insertarContrato_Click(object sender, EventArgs e)
        {
            int id_contrato = Int32.Parse(idContrato.Value);
            int id_conductor = Int32.Parse(vehiculoContrato.Text);
            int id_vehiculo = Int32.Parse(conductorContrato.Text);

            LogicaNegocioContrato negocioContrato = new LogicaNegocioContrato();
            int resultadoContrato = negocioContrato.negociarInsertarContrato(id_contrato,id_conductor,id_vehiculo);

            if (resultadoContrato > 0)

                lblMensajeContrato.Text = "Registro agregado";
            else
                lblMensajeContrato.Text = "No hay registro";

            negocioContrato = null;
        }
    }
}