using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace WebServer {
    public class Program {
        public static void Main(string[] args) {

            string port;
            if (args.Length == 0) 
            {
                port = "5000";
            }
            else
            {
                port = args[0];
            }

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:" + port)
                .Build();

            host.Run();
        }
    }
}
