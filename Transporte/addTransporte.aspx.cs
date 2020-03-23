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

        }

        protected void enviarcond_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            int id_conductor = Int32.Parse(idConductor.Value);
            string nombre_conductor = nombre.Value;
            string tipo_licencia = licencia.Value;
            int id_vehiculo = Int32.Parse(idVehiculoConductor.Value);
            int id_tipo_conductor = Int32.Parse(tipo.Value);

            logicaNegocioConductor negocioConductor = new logicaNegocioConductor();
            negocioConductor.negociarInsertarConductor(id_conductor, nombre_conductor, tipo_licencia, id_vehiculo, id_tipo_conductor);
        }
    }
}