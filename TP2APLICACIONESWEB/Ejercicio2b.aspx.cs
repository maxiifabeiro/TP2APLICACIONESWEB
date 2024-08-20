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
                //Muestro Nombre y Apellido
                String Nombre;
                String Apellido;

                Nombre = Request["txtNombre"].ToString();
                Apellido = ((TextBox)PreviousPage.FindControl("txtApellido")).Text;

                lblMensaje.Text = "Nombre: " + Nombre + "<br/><br/>" +
                                  "Apellido: " + Apellido + "<br/><br/>";

                //Muestro la zona
                DropDownList ciudades = (DropDownList)PreviousPage.FindControl("ddlCiudades");
                string zona = "Zona: " + ciudades.SelectedValue + "<br/><br/>";

                lblMensaje.Text += zona;

                //Muestro temas
                CheckBoxList cblTemas = (CheckBoxList)PreviousPage.FindControl("cblTemas");
                string temas = "Los temas elegidos son: <br/><br/>";

                foreach (ListItem item in cblTemas.Items)
                {
                    if (item.Selected)
                    {
                        temas += item.Text + "<br/>";
                    }
                }

                lblMensaje.Text += temas;
            }
        }
    }
}