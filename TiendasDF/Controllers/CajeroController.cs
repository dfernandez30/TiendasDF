using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TiendasDF.Models;

namespace TiendasDF.Controllers
{
    public class CajeroController : ApiController
    {
        Cajero[] cajeros = new Cajero[]
        {
            new Cajero {id=1 ,nombre="Luis" ,apellidoPaterno="Aguayo" ,apellidoMaterno="Gonzalez" ,rut=123045649 ,horasTrabajadas=50 ,mesesAntiguedad=30 ,bono=true , numeroCaja=2 ,turno="mañana"},
            new Cajero {id=2 ,nombre="Juan" ,apellidoPaterno="Herrera" ,apellidoMaterno="Cortes" ,rut=215293072 ,horasTrabajadas=30 ,mesesAntiguedad=20 ,bono=true , numeroCaja=5 ,turno="tarde"},
            new Cajero {id=3 ,nombre="Pedro" ,apellidoPaterno="Estrada" ,apellidoMaterno="Campos" ,rut=245821648 ,horasTrabajadas=40 ,mesesAntiguedad=15 ,bono=false , numeroCaja=9 ,turno="tarde"},
            new Cajero {id=4 ,nombre="Paty" ,apellidoPaterno="Farias" ,apellidoMaterno="Muñoz" ,rut=144590748 ,horasTrabajadas=35 ,mesesAntiguedad=9 ,bono=true , numeroCaja=4 ,turno="mañana"},
        };
        public IEnumerable<Cajero> GetAll()
        {
            return cajeros;
        }

        public IHttpActionResult GetCajero(int id)
        {
            var filtroCajero = cajeros.FirstOrDefault((a) => a.rut == id);

            if (filtroCajero != null)
            {
                return Ok(filtroCajero);
            }
            else
            {
                return NotFound();
            }

        }
    } 
}
