using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCoffee.src.Modules.User.Application.Interfaces;
using AppCoffee.src.Modules.User.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using CoffeeApp.src.Shared.Context;

namespace AppCoffee.src.Modules.User.Infrastructure.Repositories;

/*public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Usuario?> GetByIdAsync(int id)
    {
        return await _context.Users
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<IEnumerable<Usuario?>> GetAllAsync() =>
        await _context.Users.ToListAsync();

    public void Add(Usuario entity) =>
        _context.Users.Add(entity);

    public void Remove(Usuario entity) =>
        _context.Users.Remove(entity);

    public void Update(Usuario entity) =>
        _context.SaveChanges();

    public async Task SaveAsync() =>
    await _context.SaveChangesAsync();
}*/
