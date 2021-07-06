using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendasDF
{
    public partial class CalcularTotal : System.Web.UI.Page
    {
        private int contadorClientes = 0;

        RS_WS.CalculosWSSoapClient ws = new RS_WS.CalculosWSSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbResultado.Text = "";

            if (!Page.IsPostBack)
            {
                lbSimulador.Text = "<p>Por favor ingrese el total de la compra y seleccione tipo de cliente.</p>";
                lbContadorClientes.Text = contadorClientes.ToString();
                lbContadorClientes.Visible = false;
            }
            else
            {
                contadorClientes = Convert.ToInt32(lbContadorClientes.Text);
                contadorClientes++;
                lbContadorClientes.Text = contadorClientes.ToString();
                lbSimulador.Text = "Hemos calculado el descuento de " + contadorClientes.ToString()+ " Clientes";

            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtValor.Text);
            double totalVenta = 0.0;

            if (rbBronce.Checked == true)
            {
                totalVenta = ws.clubBronce(valor);
                lbResultado.Text = "El total de su compra es $" + totalVenta.ToString();
            }

            if (rbOro.Checked == true)
            {
                totalVenta = ws.clubOro(valor);
                lbResultado.Text = "El total de su compra es $" + totalVenta.ToString();
            }
            if (rbDiamante.Checked == true)
            {
                totalVenta = ws.clubDiamante(valor);
                lbResultado.Text = "El total de su compra es $" + totalVenta.ToString();
            }

            if (rbPlatino.Checked == true)
            {
                totalVenta = ws.clubPlatino(valor);
                lbResultado.Text = "El total de su compra es $" + totalVenta.ToString();
            }

            if (rbSinConvenio.Checked == true)
            {
                totalVenta = ws.sinConvenio(valor);
                lbResultado.Text = "El total de su compra es $" + totalVenta.ToString();
            }

        }
    }
}
