using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_mx_ux.domain.DTOs.Usuario
{
    public class CredencialesUsuarioDTO
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Nombres { get; set; }
  
    }
}
