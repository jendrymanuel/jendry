namespace Inventario.Data.Request;

public class ProductoRequest
{
    public int Id { get; set; }
    public int Stock { get; set; }
    public string Descripcion { get; set; } = null!;
    public int ProveedorId { get; set; }
    public double CostoUnidad { get; set; }
    public double Importe { get; set; }
    
}