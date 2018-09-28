using System;
using System.Globalization;
using System.Numerics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
         
        [HttpPost]
        public ActionResult Post([FromBody] PeticionFibonacci peticionFibonacci)
        {
            // si el modelo es inválido o es null, regresa 400
            if (!this.ModelState.IsValid || peticionFibonacci == null)
            {
                return BadRequest();
            }
            else
            {
                BigInteger[] valores = new BigInteger[peticionFibonacci.iteraciones];
                if (peticionFibonacci.ultimoValor == 0)
                {
                    valores[0] = 1;
                    valores[1] = 1;
                } else {
                    valores[0] = peticionFibonacci.penultimoValor + peticionFibonacci.ultimoValor;
                    valores[1] = peticionFibonacci.ultimoValor + valores[0];
                }

                for (int i = 2; i < peticionFibonacci.iteraciones; i++)
                {
                    valores[i] = valores[i - 1] + valores[i - 2];

                }
                
                return Ok(new RespuestaFibonacci { valores = valores});
            }
        }
    }
}