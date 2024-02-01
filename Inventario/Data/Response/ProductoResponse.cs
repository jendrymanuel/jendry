using Inventario.Data.Request;

namespace Inventario.Data.Response;

public class ProductoResponse
{
    public int Id { get; set; }
    public int Stock { get; set; }
    public string Descripcion { get; set; } = null!;
    public int ProveedorId { get; set; }
    public ProveedorResponse? Proveedor { get; set; }
    public double CostoUnidad { get; set; }
    public double Importe { get; set; }

        public ProductoRequest ToRequest() {
            return new ProductoRequest
            {
                Id = Id,
                Stock = Stock,
                Descripcion = Descripcion,
                ProveedorId = ProveedorId,
                CostoUnidad = CostoUnidad,
                Importe = Importe
                
            };
        }
}