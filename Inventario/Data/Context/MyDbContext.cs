using Inventario.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
namespace Inventario.Data.Context;

public class MyDbContext : DbContext, IMyDbContext
{
    private readonly IConfiguration config;

    public MyDbContext(IConfiguration config)
    {
        this.config = config;
    }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(config.GetConnectionString("MSSQL"));
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

}

public interface IMyDbContext
    {
        DbSet<Producto> Productos { get; set; }
        DbSet<Proveedor> Proveedores { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }