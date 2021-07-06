using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendasDF.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public int codigoBarra { get; set; }
        public int cantidad { get; set; }
        public string unidadCantidad { get; set; }
        public int stock { get; set; }
        public int precio { get; set; }

    }
}