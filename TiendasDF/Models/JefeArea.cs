using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendasDF.Models
{
    public class JefeArea : Personal
    {
        public string area { get; set; }
        public int tamanioEquipo { get; set; }
    }
}