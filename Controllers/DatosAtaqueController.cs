using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class DatosAtaqueController : Controller
    {
        private static int id = 0;

        [HttpGet]
         public ActionResult Get() 
         {
             return Ok(Datos.DatosAtaque.ElementAt(0).Value);
         }
         
        [HttpPost]
        public ActionResult Post([FromBody] DatosAtaque datosAtaque)
        {
            // si el modelo es inválido o es null, regresa 400
            if (!this.ModelState.IsValid || datosAtaque == null)
            {
                return BadRequest();
            }
            else
            {
                Datos.DatosAtaque.Clear();
                int nextId = id++;
                datosAtaque.id = nextId;
                Datos.DatosAtaque.Add(nextId, datosAtaque);

                //TODO calidar aquí
                return Ok(datosAtaque);
                
            }
        }
    }
}