using store_ms_ux.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_mx_ux.domain.DTOs.Categoria
{
    public class CategoriaDTO
    {
    
        public Guid Idcategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime? Fechacreacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }

    }
}
