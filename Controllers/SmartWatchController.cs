using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class SmartWatchController : Controller
    {

        /*
        Obtiene el listado de datossmartwatch
         */
         [HttpGet]
         public ActionResult Get() 
         {
            return Ok(Datos.DatosSmartWatch);
         }

         /*
         
          */
        [HttpPost]
        public ActionResult Post([FromBody] SmartWatch smartWatch)
        {
            // si el modelo es inválido o es null, regresa 400
            if (!this.ModelState.IsValid || smartWatch == null)
            {
                return BadRequest();
            }
            else
            {
                //TODO hacer tal cosa
                int nextId = Datos.DatosSmartWatch.Count;
                smartWatch.id = nextId;
                Datos.DatosSmartWatch.Add(nextId, smartWatch);

                //TODO calidar aquí
                return Ok(smartWatch);
            }
        }

        /*
        http://localhost:5000/api/usuarios/:id
        Obtiene la información del Usuario dado a un Id especificado 
         */
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            // Verifica si existe el id especificado
            if (Datos.Usuarios.ContainsKey(id))
            {
                // Si el id es encontrado regresa el elemento de nuestro IDictionary en la posición especificada
                return Ok(Datos.Usuarios[id]);
            }
            else
            {
                // Si el id no es encontrado, regresa un 404
                return NotFound();
            }
        }
    }
}