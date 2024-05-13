using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_mx_ux.domain.DTOs.Usuario
{
    public class CrearUsuarioDTO
    {
        public Guid IdUsuario { get; set; }
        public string? Username { get; set; }
        public string? Clave { get; set; }
        public string? Email { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
