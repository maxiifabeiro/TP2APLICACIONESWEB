using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2APLICACIONESWEB
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lnkColor1_Click(object sender, EventArgs e)
        {
            txtColor.ForeColor = System.Drawing.Color.Red;
            txtColor.Text = "Texto coloreado";
        }

        protected void lnkColor2_Click(object sender, EventArgs e)
        {
            txtColor.ForeColor = System.Drawing.Color.Blue;
            txtColor.Text = "Texto coloreado";
        }

        protected void lnkColor3_Click(object sender, EventArgs e)
        {
            txtColor.ForeColor = System.Drawing.Color.Green;
            txtColor.Text = "Texto coloreado";
        }
    }
}