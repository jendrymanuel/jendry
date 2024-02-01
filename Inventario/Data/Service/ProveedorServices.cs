using Inventario.Data.Context;
using Inventario.Data.Model;
using Inventario.Data.Response;
using Inventario.Data.Request;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Data.Services;

public class ProveedorServices : IProveedorServices
{
    private readonly IMyDbContext dbContext;

    public ProveedorServices(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<Result<List<ProveedorResponse>>> Consultar(string filtro)
    {
        try
        {
            var contactos = await dbContext.Proveedores
                .Where(c =>
                    (c.FullName)
                    .ToLower()
                    .Contains(filtro.ToLower()
                    )
                )
                .Select(c => c.ToResponse())
                .ToListAsync();
            return new Result<List<ProveedorResponse>>()
            {
                Mensaje = "Ok",
                Exitoso = true,
                Datos = contactos
            };
        }
        catch (Exception E)
        {
            return new Result<List<ProveedorResponse>>
            {
                Mensaje = E.Message,
                Exitoso = false
            };
        }
    }

    public async Task<Result> Crear(ProveedorRequest request)
    {
        try
        {
            var contacto = Proveedor.Crear(request);
            dbContext.Proveedores.Add(contacto);
            await dbContext.SaveChangesAsync();
            return new Result() { Mensaje = "Ok", Exitoso = true };
        }
        catch (Exception E)
        {

            return new Result() { Mensaje = E.Message, Exitoso = false };
        }
    }
    public async Task<Result> Modificar(ProveedorRequest request)
    {
        try
        {
            var contacto = await dbContext.Proveedores
                .FirstOrDefaultAsync(c => c.Id == request.Id);
            if (contacto == null)
                return new Result() { Mensaje = "No se encontro el proveedor", Exitoso = false };

            if (contacto.Mofidicar(request))
                await dbContext.SaveChangesAsync();

            return new Result() { Mensaje = "Ok", Exitoso = true };
        }
        catch (Exception E)
        {

            return new Result() { Mensaje = E.Message, Exitoso = false };
        }
    }

    public async Task<Result> Eliminar(ProveedorRequest request)
    {
        try
        {
            var contacto = await dbContext.Proveedores
                .FirstOrDefaultAsync(c => c.Id == request.Id);
            if (contacto == null)
                return new Result() { Mensaje = "No se encontro el Proveedor", Exitoso = false };

            dbContext.Proveedores.Remove(contacto);
            await dbContext.SaveChangesAsync();
            return new Result() { Mensaje = "Ok", Exitoso = true };
        }
        catch (Exception E)
        {

            return new Result() { Mensaje = E.Message, Exitoso = false };
        }
    }
}

public interface IProveedorServices
{
    Task<Result<List<ProveedorResponse>>> Consultar(string filtro);
    Task<Result> Crear(ProveedorRequest request);
    Task<Result> Modificar(ProveedorRequest request);
    Task<Result> Eliminar(ProveedorRequest request);
}