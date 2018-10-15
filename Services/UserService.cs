using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using WebServer.Models;

namespace WebServer.Services
{
    public interface IUserService
    {
        Task<Usuario> Authenticate(string username, string password);
    }

    public class UserService : IUserService
    {
        public async Task<Usuario> Authenticate(string email, string password)
        {
            var user = await Task.Run(() => Datos.Usuarios.SingleOrDefault(x => x.Value.Email == email && x.Value.Password == password));

            if (user.Value == null)
            {
                return null;
            }

            return user.Value;
        }
    }
}