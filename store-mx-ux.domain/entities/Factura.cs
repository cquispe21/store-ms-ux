using System;
using System.Collections.Generic;

namespace store_ms_ux.domain.entities
{
    public partial class Factura
    {
        public Factura()
        {
            Detallefacturas = new HashSet<Detallefactura>();
        }

        public Guid Idfactura { get; set; }
        public Guid Idusuario { get; set; }
        public string? Identificacioncliente { get; set; }
        public string Razonsocial { get; set; } = null!;
        public string Direcion { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public DateTime? Fechaemision { get; set; }
        public decimal? Totalimporte { get; set; }

        public virtual UsuarioDBContext IdusuarioNavigation { get; set; } = null!;
        public virtual ICollection<Detallefactura> Detallefacturas { get; set; }
    }
}
