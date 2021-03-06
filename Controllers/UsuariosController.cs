using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : Controller
    {

        /*
        Obtiene el listado de usuarios
         */
         [HttpGet]
         public ActionResult Get() 
         {
             return Ok(Datos.Usuarios);
         }

         /*
         
          */
        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            // si el modelo (login) es inválido o es null, regresa 400
            if (!this.ModelState.IsValid || usuario == null)
            {
                return BadRequest();
            }
            else
            {
                //TODO hacer tal cosa
                int nextId = Datos.Usuarios.Count;
                usuario.ID = nextId;
                Datos.Usuarios.Add(nextId, usuario);

                //TODO calidar aquí
                return Ok(usuario);
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