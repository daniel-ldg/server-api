using System.Numerics;
using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{
    public class RespuestaFibonacci
    {
        [Required]
        public BigInteger[] valores { get; set; }

        
    }
}