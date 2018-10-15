using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{
    public class EstadoCliente
    {

        [Required]
        public int peticionesAtaque {get; set;}

        [Required]
        public int peticionesHechas {get; set;}

        [Required]
        public int peticionesRechazadas {get; set;}

        [Required]
        public string estado {get; set;}
    }
}