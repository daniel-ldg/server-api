using System;
using System.Globalization;
using System.Numerics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {

        [HttpGet]
         public ActionResult Get() 
         {
             return Ok(Datos.DatosEmail);
         }
         
        [HttpPost]
        public ActionResult Post([FromBody] Email email)
        {
            // si el modelo es inválido o es null, regresa 400
            if (!this.ModelState.IsValid || email == null)
            {
                return BadRequest();
            }
            else
            {
                int nextId = Datos.DatosEmail.Count;
                email.Id = nextId;
                Datos.DatosEmail.Add(nextId, email);

                //TODO calidar aquí
                return Ok(email);
                
            }
        }
    }
}