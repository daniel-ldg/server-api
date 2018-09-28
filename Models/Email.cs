using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required]
        public string Remitente { get; set;}

        [Required]
        public string Destinatario { get; set; }
        
        [Required]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set;}
    }
}