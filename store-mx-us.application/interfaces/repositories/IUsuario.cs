using store_ms_ux.domain.entities;
using store_mx_ux.domain;
using store_mx_ux.domain.DTOs.Usuario;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_mx_us.application.interfaces.repositories
{
    public interface IUsuario
    {
       Task<List<UsuarioDBContext>> ListaUsuario();
        Task<CrearResponse> CrearUsuario(CrearUsuarioDTO  usuario);
    }
}
