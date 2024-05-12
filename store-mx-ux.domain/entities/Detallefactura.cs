using System;
using System.Collections.Generic;

namespace store_ms_ux.domain.entities
{
    public partial class Detallefactura
    {
        public Guid Iddetallefactura { get; set; }
        public Guid? Idfactura { get; set; }
        public string? Nombreproducto { get; set; }
        public string? Descripcionproducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Preciounitario { get; set; }

        public virtual FacturaDbContext? IdfacturaNavigation { get; set; }
    }
}
