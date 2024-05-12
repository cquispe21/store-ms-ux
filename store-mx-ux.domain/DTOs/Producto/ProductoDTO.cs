using store_ms_ux.domain.entities;
using store_mx_ux.domain.DTOs.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_mx_ux.domain.DTOs.Producto
{
    public class ProductoDTO
    {
        public Guid Idproducto { get; set; }
        public Guid? Idcategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal? Precio { get; set; }
        public DateOnly Fechacreacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }
        public string Imagen { get; set; } = null!;

        //public virtual Categoria? IdcategoriaNavigation { get; set; }
    }
}
