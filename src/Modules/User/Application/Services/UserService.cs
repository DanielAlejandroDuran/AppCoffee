using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCoffee.src.Modules.User.Application.Interfaces;
using AppCoffee.src.Modules.User.Domain.Entities;

namespace AppCoffee.src.Modules.User.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repo;

    public UserService(IUserRepository repo)
    {
        _repo = repo;
    }

    public Task<IEnumerable<Usuario>> ConsultarUsuariosAsync()
    {
        return _repo.GetAllAsync()!;
    }

    public async Task RegistrarUsuarioConTareaAsync(string name, string email)
    {
        var existentes = await _repo.GetAllAsync();
        if (existentes.Any(u => u?.Email == email))
            throw new Exception("el usuario ya exite.");
        var user = new Usuario
        {
            Name = name,
            Email = email,
        };

        _repo.Add(user);
        _repo.Update(user);
    }
    public async Task ActualizarUsuario(int id, string newname, string newemail)
    {
        var user = await _repo.GetByIdAsync(id);

        if (user == null)
            throw new Exception($"Usuario con ID {id}no encontrado.");
        user.Name = newname;
        user.Email = newemail;

        _repo.Update(user);
        await _repo.SaveAsync();
    }

    public async Task EliminarUsuario(int id)
    {
        var user = await _repo.GetByIdAsync(id);
        if (user == null)
            throw new Exception($"Usuario con ID {id} no encontrado.");
        _repo.Remove(user);
        await _repo.SaveAsync();
    }

    public async Task<Usuario?> ObtenerUsuarioPorIdAsync(int id)
    {
        return await _repo.GetByIdAsync(id);
    }
}
