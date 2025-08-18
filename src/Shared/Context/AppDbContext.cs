using AppCoffee.src.Modules.User.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeApp.src.Shared.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Usuario> usuarios => Set<Usuario>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}