using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{
    public class DatosAtaque
    {
        public int id {get; set;}

        [Required]
        public string urlServidorAtacado {get; set;}

        [Required]
        public int numHilos {get; set;}

        [Required]
        public int numIteraciones {get; set;}

        [Required]
        public bool enParalelo{get; set;}
    }
}