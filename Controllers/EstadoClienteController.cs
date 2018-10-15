using System;
using System.Globalization;
using System.Numerics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class EstadoClienteController : Controller
    {

        [HttpGet]
         public ActionResult Get() 
         {
            return Ok(Datos.datosEstadoCliente);
         }
         
        [HttpPost]
        public ActionResult Post([FromBody] EstadoCliente estadoCliente)
        {
            // si el modelo es inválido o es null, regresa 400
            if (!this.ModelState.IsValid || estadoCliente == null)
            {
                return BadRequest();
            }
            else
            {
                Datos.datosEstadoCliente = estadoCliente;

                //TODO calidar aquí
                return Ok(Datos.datosEstadoCliente);
                
            }
        }
    }
}