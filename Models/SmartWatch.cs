using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{
    public class SmartWatch
    {
        public int id;

        [Required]
        public long tiempo { get; set;}

        [Required]
        public int promedioHR { get; set;}

        [Required]
        public string fecha { get; set;}

        [Required]
        public double promedioVel { get; set;}

        [Required]
        public double distancia { get; set;}

    }

}