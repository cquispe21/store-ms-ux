using System;
using System.Collections.Generic;

namespace store_ms_ux.domain.entities
{
    public partial class Producto
    {
        public Guid Idproducto { get; set; }
        public Guid? Idcategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal? Precio { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }
        public string Imagen { get; set; } = null!;

        public virtual Categoria? IdcategoriaNavigation { get; set; }
    }
}
