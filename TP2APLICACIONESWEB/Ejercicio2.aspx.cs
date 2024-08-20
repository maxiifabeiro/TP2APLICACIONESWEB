using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2APLICACIONESWEB
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ListItem ciudadUno = new ListItem();
                ciudadUno.Text = "Gral. Pacheco";
                ciudadUno.Value = "Zona norte";
                ListItem ciudadDos = new ListItem();
                ciudadDos.Text = "San Miguel";
                ciudadDos.Value = "Zona Oeste";
                ListItem ciudadTres = new ListItem();
                ciudadTres.Text = "Boedo";
                ciudadTres.Value = "Zona Sur";
                ddlCiudades.Items.Add(ciudadUno);
                ddlCiudades.Items.Add(ciudadDos);
                ddlCiudades.Items.Add(ciudadTres);
            }
        }

        

        protected void btnResumen_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio2b.aspx");
        }

        
    }
}