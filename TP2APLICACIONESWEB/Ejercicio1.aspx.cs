using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2APLICACIONESWEB
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTabla_Click(object sender, EventArgs e)
        {
            string prodUno = txtProducto1.Text;
            string prodDos = txtProducto2.Text;
            int numeroUno = int.Parse(txtCantidad1.Text);
            int numeroDos = int.Parse(txtCantidad2.Text);

            string tabla = "<table border='1'>";

            // Encabezado de la tabla
            tabla += "<tr style=' font-weight: bold; color: black;'>";
            tabla += "<td>Producto</td>";
            tabla += "<td>Cantidad</td>";
            tabla += "</tr>";

            // Fila para el primer producto
            tabla += "<tr>";
            tabla += "<td>" + prodUno.ToString() + "</td>";
            tabla += "<td>" + numeroUno + "</td>";
            tabla += "</tr>";

            // Fila para el segundo producto
            tabla += "<tr>";
            tabla += "<td>" + prodDos.ToString() + "</td>";
            tabla += "<td>" + numeroDos + "</td>";
            tabla += "</tr>";

            // Fila para el total
            tabla += "<tr>";
            tabla += "<td>TOTAL</td>";
            tabla += "<td>" + (numeroUno + numeroDos) + "</td>";
            tabla += "</tr>";

            tabla += "</table>";
            lblTabla.Text = tabla;
        }


    }
}