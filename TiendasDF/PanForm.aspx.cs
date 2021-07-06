using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendasDF
{
    public partial class PanForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                tablaResult.Visible = false;
                
            }

            else 
            {
                tablaResult.Visible = true;

            }
        }
    }
}