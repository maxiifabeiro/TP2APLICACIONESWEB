using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2APLICACIONESWEB
{
    public partial class Ejercicio4a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            // Valores de usuario y clave 
            string usuarioValido = "claudio";
            string claveValida = "12345";

            if (usuario == usuarioValido && clave == claveValida)
            {
                // Redirigir a la pagina de bienvenida con el nombre del usuario
                Response.Redirect("Ejercicio4b.aspx?usu=" + usuario);
            }
            else
            {
                // Redirigir a la pagina de error
                Response.Redirect("Ejercicio4c.aspx");
            }
        }

    }
}