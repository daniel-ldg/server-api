using System.Collections.Generic;

namespace WebServer.Models
{
    public class Datos
    {

        /*
         IDictionary Representa una colección genérica de pares clave-valor.
         En este caso se crea un IDictionary de claves de tipo int, y valor de tipo Usuario
         */
        public static IDictionary<int, Usuario> Usuarios { get; private set; }

        /*
        Creamos un IDictionary para los datos de Folios
         */
        public static IDictionary<int, Folio> Folios { get; set; }

        /*
        Creamos un IDictionary para almacenar los datos del smartwatch
         */
        public static IDictionary<int, SmartWatch> DatosSmartWatch { get; set;}

        public static IDictionary<int, Email> DatosEmail {get; set;}

        // Constructor de la clase
        static Datos()
        {

            DatosEmail = new Dictionary<int, Email>();
            DatosEmail.Add(0, new Email {Id = 0, Remitente = "test", Destinatario = "test", Subject = "test", Body = "test"});

            DatosSmartWatch = new Dictionary<int, SmartWatch>();
            DatosSmartWatch.Add(0, new SmartWatch {tiempo = 3600, promedioHR = 170, fecha = "21-09-2018"});

            /*
            Se agregan tres entradas de clave-valor a nuestro IDictionary
             */
            //TODO: Agregar más datos de prueba
            Usuarios = new Dictionary<int, Usuario>();
            Usuarios.Add(0, new Usuario { ID = 0, Nombre = "Vlad", Apellidos = "Drăculea", Email = "alucard@gmail.com", Password = "123456" });
            Usuarios.Add(1, new Usuario { ID = 1, Nombre = "Dorian", Apellidos = "Gray", Email = "eternalLife@gmail.com", Password = "23435643" });
            Usuarios.Add(2, new Usuario { ID = 2, Nombre = "Jeanne", Apellidos = "d'Arc", Email = "DoncelladeOrleans@gmail.com", Password = "asdf445asd" });
            Usuarios.Add(3, new Usuario { ID = 3, Nombre = "Homer", Apellidos = "Simpson", Email = "homer_j_simpson@gmail.com", Password = "qwerty" });
            Usuarios.Add(4, new Usuario { ID = 4, Nombre = "Geralt", Apellidos = "de Rivia", Email = "gwynbleidd@gmail.com", Password = "kaedwen" });
            Usuarios.Add(5, new Usuario { ID = 5, Nombre = "Daniel", Apellidos = "Ladrón de Guevara", Email = "daniel.ldg@icloud.com", Password = "aaa" });
            Usuarios.Add(6, new Usuario { ID = 6, Nombre = "Trevor", Apellidos = "Philips", Email = "trevor_ph@gmail.com", Password = "273-555-0136" });
            Usuarios.Add(7, new Usuario { ID = 7, Nombre = "Agent 47", Apellidos = "[none]", Email = "47@ica.com", Password = "silverballer" });



            Folios = new Dictionary<int, Folio>();
            Folios.Add(0, new Folio { NumFolio = 100, Monto = (decimal)345 });
            Folios.Add(1, new Folio { NumFolio = 200, Monto = (decimal)345.32 });
            Folios.Add(2, new Folio { NumFolio = 300, Monto = (decimal)345.67 });

        }
    }
}