using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_mx_ux.domain.DTOs.Factura
{
    public class FacturaDTO
    {
        public Guid IdFactura { get; set; }
        public Guid IdUsuario { get; set; }
        public string? IdentificacionCliente { get; set; }
        public string? RazonSocial { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }
        public DateTime? FechaEmision { get; set; }
        public decimal? TotalImporte { get; set; }

        public DetalleFacturaNewDTO[]? DetalleFactura {  get; set; }
    }

    public class DetalleFacturaNewDTO
    {
        public Guid IdDetalleFactura { get; set; }
        public Guid? IdFactura { get; set; }
        public string? NombreProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
    }
}
