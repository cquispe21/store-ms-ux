using System;
using System.Collections.Generic;

namespace store_ms_ux.domain.entities
{
    public partial class Categoria
    {
        public Categoria()
        {
            Productos = new HashSet<Producto>();
        }

        public Guid Idcategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime? Fechacreacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
