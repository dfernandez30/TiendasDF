using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TiendasDF.Models;

namespace TiendasDF.Controllers
{
    public class CarneController : ApiController
    {
        Carne[] carnes = new Carne[]
        {
            new Carne {id=1 ,nombre="Abastero" ,marca="Buen Corte" ,codigoBarra=16920632 ,cantidad=2 ,unidadCantidad="kg" ,stock=30 ,precio=7500 ,fechaEnvasado="17-07-2021",animal="vacuno"},
            new Carne {id=2 ,nombre="Posta" ,marca="Buen Corte" ,codigoBarra=34984036 ,cantidad=1 ,unidadCantidad="kg" ,stock=45 ,precio=500 ,fechaEnvasado="19-07-2021",animal="vacuno"},
            new Carne {id=3 ,nombre="Chuleta" ,marca="Buen Corte" ,codigoBarra=47740120 ,cantidad=3 ,unidadCantidad="kg" ,stock=50 ,precio=6800 ,fechaEnvasado="11-07-2021",animal="vacuno"},
            new Carne {id=4 ,nombre="Chuleta" ,marca="Super Cerdo" ,codigoBarra=49186234 ,cantidad=1 ,unidadCantidad="kg" ,stock=49 ,precio=5500 ,fechaEnvasado="12-07-2021",animal="cerdo"},
            new Carne {id=5 ,nombre="Tuto" ,marca="Sopraval" ,codigoBarra=54001011 ,cantidad=1 ,unidadCantidad="kg" ,stock=55 ,precio=4500 ,fechaEnvasado="09-07-2021",animal="pollo"},
            new Carne {id=6 ,nombre="Pechuga" ,marca="Sopraval" ,codigoBarra=56549045 ,cantidad=1 ,unidadCantidad="kg" ,stock=44 ,precio=4300 ,fechaEnvasado="01-07-2021",animal="pollo"},
            new Carne {id=7 ,nombre="Tuto" ,marca="Sopraval" ,codigoBarra=83492865 ,cantidad=2 ,unidadCantidad="kg" ,stock=29 ,precio=5000 ,fechaEnvasado="13-07-2021",animal="pavo"},
            new Carne {id=8 ,nombre="Pechuga" ,marca="Sopraval" ,codigoBarra=38612971 ,cantidad=3 ,unidadCantidad="kg" ,stock=46 ,precio=5500 ,fechaEnvasado="20-07-2021",animal="pavo"},
            new Carne {id=9 ,nombre="Salchicha" ,marca="Til" ,codigoBarra=50984542 ,cantidad=500 ,unidadCantidad="gr" ,stock=92 ,precio=3900 ,fechaEnvasado="16-07-2021",animal="cerdo"},
            new Carne {id=10 ,nombre="Longaniza" ,marca="PF" ,codigoBarra=67310831 ,cantidad=900 ,unidadCantidad="gr" ,stock=46 ,precio=4100 ,fechaEnvasado="17-07-2021",animal="cerdo"}
        };
        // GET: api/Carne
        public IEnumerable<Carne> GetAll()
        {
            return carnes;
        }

        public IHttpActionResult GetCarne(int id)
        {
            var filtroCarne = carnes.FirstOrDefault((a) => a.id == id);

            if (filtroCarne != null)
            {
                return Ok(filtroCarne);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
