using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TiendasDF.Models;

namespace TiendasDF.Controllers
{
    public class GuardiaController : ApiController
    {
        Guardia[] guardias = new Guardia[]
        {
            new Guardia {id=1 ,nombre="Daniel" ,apellidoPaterno="Rodrigues" ,apellidoMaterno="Montejo" ,rut=175854237 ,horasTrabajadas=46 ,mesesAntiguedad=9 ,bono=false , articulosRecuperados=2 ,area="Licores"},
            new Guardia {id=2 ,nombre="Gabriel" ,apellidoPaterno="Polo" ,apellidoMaterno="Nieto" ,rut=593616620 ,horasTrabajadas=12 ,mesesAntiguedad=12 ,bono=true , articulosRecuperados=5 ,area="Carnes"},
            new Guardia {id=3 ,nombre="Carlos" ,apellidoPaterno="Guzman" ,apellidoMaterno="Castellanos" ,rut=567304573 ,horasTrabajadas=55 ,mesesAntiguedad=4 ,bono=false , articulosRecuperados=9 ,area="Panadería"},
            new Guardia {id=4 ,nombre="Camilo" ,apellidoPaterno="Quezada" ,apellidoMaterno="Mendoza" ,rut=980657263 ,horasTrabajadas=29 ,mesesAntiguedad=25 ,bono=true , articulosRecuperados=4 ,area="Quesos"},
        };
        public IEnumerable<Guardia> GetAll()
        {
            return guardias;
        }

        public IHttpActionResult GetGuardia(int id)
        {
            var filtroGuardia = guardias.FirstOrDefault((a) => a.rut == id);

            if (filtroGuardia != null)
            {
                return Ok(filtroGuardia);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
