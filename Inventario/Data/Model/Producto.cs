

using System.ComponentModel.DataAnnotations.Schema;
using Inventario.Data.Request;
using Inventario.Data.Response;

namespace Inventario.Data.Model;

public class Producto
{
    public int Id { get; set; }
    public int Stock { get; set; }
    public string Descripcion { get; set; } = null!;
    public int ProveedorId { get; set; }
     #region Relaciones
    [ForeignKey(nameof(ProveedorId))]
    public virtual Proveedor Proveedor { get; set; }
    #endregion
    public double CostoUnidad { get; set; }
    public double Importe { get; set; }

    public static Producto Crear(ProductoRequest item)
    => new()
    {
        Stock = item.Stock,
        Descripcion = item.Descripcion,
        ProveedorId = item.ProveedorId,
        CostoUnidad = item.CostoUnidad,
        Importe = item.Importe
    };

    public bool Mofidicar(ProductoRequest item)
        {
            var cambio = false;
            if(Stock != item.Stock)
            {
                Stock = item.Stock;
                cambio = true;
            }
            if (Descripcion != item.Descripcion)
            {
                Descripcion = item.Descripcion;
                cambio = true;
            }
            if(ProveedorId != item.ProveedorId)
            {
                ProveedorId = item.ProveedorId;
                cambio = true;
            }
            if(CostoUnidad != item.CostoUnidad)
            {
                CostoUnidad = item.CostoUnidad;
                cambio = true;
            }
            
            if(Importe != item.Importe)
            {
                Importe = item.Importe;
                cambio = true;
            }
            return cambio;
        }

        public ProductoResponse ToResponse()
        => new()
        {
            Id = Id,
            Stock = Stock,
            Descripcion = Descripcion,
            ProveedorId = ProveedorId,
            Proveedor = Proveedor != null? Proveedor!.ToResponse():null,
            CostoUnidad = CostoUnidad,
            Importe = Importe
        };
}