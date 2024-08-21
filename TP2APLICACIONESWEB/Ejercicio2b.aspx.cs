using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2APLICACIONESWEB
{
    public partial class Ejercicio2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMensaje.Text = "<h2>Resumen</h2>";

                //Muestro Nombre y Apellido
                String Nombre;
                String Apellido;

                Nombre = Request["txtNombre"].ToString();
                Apellido = ((TextBox)PreviousPage.FindControl("txtApellido")).Text;

                lblMensaje.Text += "<p><strong>Nombre:</strong> " + Nombre + "</p>";
                lblMensaje.Text += "<p><strong>Apellido:</strong> " + Apellido + "</p>";

                //Muestro la zona
                DropDownList ciudades = (DropDownList)PreviousPage.FindControl("ddlCiudades");
                string zona = "<p><strong>Zona:</strong> " + ciudades.SelectedValue + "</p>";

                lblMensaje.Text += zona;

                //Muestro temas
                CheckBoxList cblTemas = (CheckBoxList)PreviousPage.FindControl("cblTemas");
                string temas = "<br><p>Los temas elegidos son: </p>";

                foreach (ListItem item in cblTemas.Items)
                {
                    if (item.Selected)
                    {
                        temas += "<strong>" + item.Text + "</br></strong>"; ;
                    }
                }

                lblMensaje.Text += temas;
            }
        }
    }
}