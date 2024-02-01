using Inventario.Data.Request;

namespace Inventario.Data.Response;

public class ProveedorResponse
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;
    
    public ProveedorRequest ToRequest() 
    {
        return new ProveedorRequest
        {
            Id = Id,
            FullName = FullName,
            PhoneNumber = PhoneNumber,
            Address = Address
        };
    }

}