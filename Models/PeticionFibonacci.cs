using System.Numerics;
using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{
    public class PeticionFibonacci
    {
        [Required]
        public int iteraciones { get; set; }

        [Required]
        public BigInteger ultimoValor { get; set; }

        [Required]
        public BigInteger penultimoValor { get; set; }
    }
}