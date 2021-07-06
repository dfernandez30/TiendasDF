using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendasDF.Models
{
    public class Personal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public int rut { get; set; }
        public int horasTrabajadas { get; set; }
        public int mesesAntiguedad { get; set; }
        public bool bono { get; set; }


    }
}