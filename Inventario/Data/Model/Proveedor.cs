

using Inventario.Data.Request;
using Inventario.Data.Response;

namespace Inventario.Data.Model;

public class Proveedor
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;

    public ProveedorResponse? ToResponse()=>new() 
        { 
            Id = Id, 
            FullName = FullName,
            PhoneNumber = PhoneNumber,
            Address = Address
        };
    
    public static Proveedor Crear(ProveedorRequest item)
    => new()
    {
        FullName = item.FullName,
        PhoneNumber = item.PhoneNumber,
        Address = item.Address
    };

    public bool Mofidicar(ProveedorRequest item)
        {
            var cambio = false;
            if(FullName != item.FullName)
            {
                FullName = item.FullName;
                cambio = true;
            }
            if (PhoneNumber != item.PhoneNumber)
            {
                PhoneNumber = item.PhoneNumber;
                cambio = true;
            }
            if(Address != item.Address)
            {
                Address = item.Address;
                cambio = true;
            }
            return cambio;
        }
}