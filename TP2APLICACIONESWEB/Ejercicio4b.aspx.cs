using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2APLICACIONESWEB
{
    public partial class Ejercicio4b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string usuario = Request.QueryString["usu"];
                if (!string.IsNullOrEmpty(usuario))
                {
                    lblMensaje.Text = "<h2><strong>Bienvenido a mi página Sr./a " + usuario + "</h2></strong>";
                }
            }
        }
    }
}