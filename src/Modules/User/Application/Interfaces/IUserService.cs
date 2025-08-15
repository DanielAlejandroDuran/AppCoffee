using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCoffee.src.Modules.User.Domain.Entities;

namespace AppCoffee.src.Modules.User.Application.Interfaces
{
    public interface IUserService
    {
        Task RegistrarUsuarioConTareaAsync(string name, string email);
        Task ActualizarUsuario(int id, string name, string email);
        Task EliminarUsuario(int id);
        Task<Usuario?> ObtenerUsuarioPorIdAsync(int id);
        Task<IEnumerable<Usuario>> ConsultarUsuariosAsync();
    }
}