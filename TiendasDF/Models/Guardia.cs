using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendasDF.Models
{
    public class Guardia : Personal
    {
        public string area { get; set; }
        public int articulosRecuperados { get; set; }

    }
}