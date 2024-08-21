using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2APLICACIONESWEB
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ListItem memoriaUno = new ListItem();
                memoriaUno.Text = "2 GB";
                memoriaUno.Value = "200";
                ListItem memoriaDos = new ListItem();
                memoriaDos.Text = "4GB";
                memoriaDos.Value = "375";
                ListItem memoriaTres = new ListItem();
                memoriaTres.Text = "6GB";
                memoriaTres.Value = "500";
                ddlMemoria.Items.Add(memoriaUno);
                ddlMemoria.Items.Add(memoriaDos);
                ddlMemoria.Items.Add(memoriaTres);
            }
        }

        protected void btnPrecio_Click(object sender, EventArgs e)
        {
            // Recuperar el valor seleccionado en el DropDownList
            int precioBase = int.Parse(ddlMemoria.SelectedValue);

            // Recorrer la CheckBoxList y sumar los valores seleccionados
            float precioExtras = 0;
            foreach (ListItem item in cblAccesorios.Items)
            {
                if (item.Selected)
                {
                    precioExtras += float.Parse(item.Value);
                }
            }

            // Calcular el precio final
            float precioFinal = precioBase + precioExtras;

            // Mostrar el precio final en el Label
            lblMensaje.Text = "<strong>El precio final es de: $</strong>" + precioFinal;
        }
    }
}