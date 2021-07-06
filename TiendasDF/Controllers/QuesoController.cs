using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TiendasDF.Models;

namespace TiendasDF.Controllers
{
    public class QuesoController : ApiController
    {
        Queso[] quesos = new Queso[]
        {
            new Queso {id=1 ,nombre="Chanco" ,marca="Parcelas" ,codigoBarra=69166457 ,cantidad=500 ,unidadCantidad="gr" ,stock=30 ,precio=3000 ,tipo="entero",tipoLeche="vaca"},
            new Queso {id=2 ,nombre="Mantecoso" ,marca="Soprole" ,codigoBarra=68437989 ,cantidad=1 ,unidadCantidad="kg" ,stock=45 ,precio=3500 ,tipo="laminado",tipoLeche="vaca"},
            new Queso {id=3 ,nombre="Cheddar" ,marca="Colun" ,codigoBarra=02624070 ,cantidad=700 ,unidadCantidad="gr" ,stock=50 ,precio=4200 ,tipo="regular",tipoLeche="cabra"},
            new Queso {id=4 ,nombre="Gouda" ,marca="Quiyayes" ,codigoBarra=27958014 ,cantidad=800 ,unidadCantidad="gr" ,stock=49 ,precio=4100 ,tipo="sin lactosa",tipoLeche="vaca"},
            new Queso {id=5 ,nombre="Fresco" ,marca="Alerces" ,codigoBarra=01806740 ,cantidad=700 ,unidadCantidad="gr" ,stock=55 ,precio=3900 ,tipo="light",tipoLeche="vaca"},
            new Queso {id=6 ,nombre="Parmesano" ,marca="Soprole" ,codigoBarra=46755957 ,cantidad=1 ,unidadCantidad="kg" ,stock=44 ,precio=3750 ,tipo="entero",tipoLeche="vaca"},
            new Queso {id=7 ,nombre="Reggianito" ,marca="Colun" ,codigoBarra=78888568 ,cantidad=700 ,unidadCantidad="gr" ,stock=29 ,precio=3200 ,tipo="rallado",tipoLeche="vaca"},
            new Queso {id=8 ,nombre="Chanco" ,marca="Colun" ,codigoBarra=48418605 ,cantidad=500 ,unidadCantidad="gr" ,stock=46 ,precio=2900 ,tipo="laminado",tipoLeche="cabra"},
            new Queso {id=9 ,nombre="Untable" ,marca="Quiyayes" ,codigoBarra=10524106 ,cantidad=500 ,unidadCantidad="gr" ,stock=92 ,precio=5000 ,tipo="light",tipoLeche="vaca"},
            new Queso {id=10 ,nombre="Blanco" ,marca="Soprole" ,codigoBarra=13085727 ,cantidad=500 ,unidadCantidad="gr" ,stock=46 ,precio=4500 ,tipo="regular",tipoLeche="cabra"}
        };
        // GET: api/Queso
        public IEnumerable<Queso> GetAll()
        {
            return quesos;
        }

        public IHttpActionResult GetQueso(int id)
        {
            var filtroQueso = quesos.FirstOrDefault((a) => a.id == id);

            if (filtroQueso != null)
            {
                return Ok(filtroQueso);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
