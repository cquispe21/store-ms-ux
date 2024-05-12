using System;
using System.Collections.Generic;

namespace store_ms_ux.domain.entities
{
    public partial class UsuarioDBContext
    {
        public Guid IdUsuario { get; set; }
        public string? Username { get; set; }
        public string? Nombres { get; set; }
        public string? Email { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual ICollection<Factura>? Facturas { get; set; }

    }
}
