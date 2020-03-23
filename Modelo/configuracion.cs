using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class configuracion
    {
        // la cadena de conexión tiene servidor, base de datos, usuario, password
        static string cadenaConexion = @"Data Source=DESKTOP-97DP648;Initial Catalog=transporte;Trusted_Connection=true";

        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
