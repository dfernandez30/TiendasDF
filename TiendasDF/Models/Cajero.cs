using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendasDF.Models
{
    public class Cajero : Personal
    {
        public int numeroCaja { get; set; }
        public string turno { get; set; }
    }
}