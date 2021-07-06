using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendasDF
{
    public partial class PersonalTienda : System.Web.UI.Page
    {
        RS_WS.CalculosWSSoapClient ws = new RS_WS.CalculosWSSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbSueldo.Text = "";
            lbPersonal.Text = "";

            if (!Page.IsPostBack)
            {
                lbCalculador.Text = "<p>Por favor ingrese el total de horas trabajadas y su valor hora para calcular su sueldo.</p>";                
            }
            else
            {               
                lbCalculador.Text = "Hemos calculado su sueldo con los valores proporcionados" ;
            }
        }
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int horas = Convert.ToInt32(txtHoras.Text);
            int valorHora = Convert.ToInt32(txtValorHora.Text);
            double sueldo = ws.horasExtra(horas, valorHora);
            lbSueldo.Text = "Su sueldo de este mes es: " + sueldo + " pesos($)";         
        }

    }
}