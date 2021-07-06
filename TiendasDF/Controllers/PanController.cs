using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TiendasDF.Models;


namespace TiendasDF.Controllers
{
    public class PanController : ApiController
    {
        Pan[] panes = new Pan[]
        {
            new Pan {id=1 ,nombre="Pan de Molde" ,marca="Cena" ,codigoBarra=12345678 ,cantidad=500 ,unidadCantidad="gr" ,stock=30 ,precio=1500 ,tipoPan="blanco"},
            new Pan {id=2 ,nombre="Pan Baguette" ,marca="Fuchs" ,codigoBarra=37660385 ,cantidad=1 ,unidadCantidad="kg" ,stock=45 ,precio=2000 ,tipoPan="integral"},
            new Pan {id=3 ,nombre="Pan Precocido" ,marca="Ideal" ,codigoBarra=94265323 ,cantidad=700 ,unidadCantidad="gr" ,stock=50 ,precio=1800 ,tipoPan="blanco"},
            new Pan {id=4 ,nombre="Pan Hallulla" ,marca="Castaño" ,codigoBarra=80573222 ,cantidad=800 ,unidadCantidad="gr" ,stock=49 ,precio=1550 ,tipoPan="mixto"},
            new Pan {id=5 ,nombre="Pan Marraqueta" ,marca="Cena" ,codigoBarra=06556517 ,cantidad=950 ,unidadCantidad="gr" ,stock=55 ,precio=1650 ,tipoPan="integral"},
            new Pan {id=6 ,nombre="Pan Amasado" ,marca="Ideal" ,codigoBarra=35254138 ,cantidad=1 ,unidadCantidad="kg" ,stock=44 ,precio=1720 ,tipoPan="blanco"},
            new Pan {id=7 ,nombre="Pan de Molde" ,marca="Cena" ,codigoBarra=50483193 ,cantidad=750 ,unidadCantidad="gr" ,stock=29 ,precio=1850 ,tipoPan="mixto"},
            new Pan {id=8 ,nombre="Pan Hallulla" ,marca="Fuchs" ,codigoBarra=57939386 ,cantidad=750 ,unidadCantidad="gr" ,stock=46 ,precio=1100 ,tipoPan="integral"},
            new Pan {id=9 ,nombre="Pan Precocido" ,marca="Castaño" ,codigoBarra=84320102 ,cantidad=800 ,unidadCantidad="gr" ,stock=92 ,precio=1250 ,tipoPan="blanco"},
            new Pan {id=10 ,nombre="Pan de Molde" ,marca="Ideal" ,codigoBarra=73424464 ,cantidad=900 ,unidadCantidad="gr" ,stock=46 ,precio=1730 ,tipoPan="mixto"}
        };
        // GET: api/Pan
        public IEnumerable<Pan> GetAll()
        {
            return panes;
        }

        public IHttpActionResult GetPan(int id)
        {
            var filtroPan = panes.FirstOrDefault((a) => a.id == id);

            if (filtroPan != null)
            {
                return Ok(filtroPan);
            }
            else
            {
                return NotFound();
            }

        }
    }
}