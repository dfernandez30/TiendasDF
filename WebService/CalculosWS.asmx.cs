using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Descripción breve de CalculosWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculosWS : System.Web.Services.WebService
    {
        // Tipos de descuentos
        [WebMethod]
        public double clubBronce(int precio)
        {
            return precio * .95;
        }

        [WebMethod]
        public double clubOro(int precio)
        {
            return precio * .92;
        }

        [WebMethod]
        public double clubDiamante(int precio)
        {
            return precio * .90;
        }

        [WebMethod]
        public double clubPlatino(int precio)
        {
            return precio * .85;
        }

        [WebMethod]
        public double sinConvenio(int precio)
        {
            return precio * 1;
        }

        [WebMethod]
        public double horasExtra(int horasTrabajadas, int valorHora)
        {
            return horasTrabajadas * valorHora;
        }
    }
}
