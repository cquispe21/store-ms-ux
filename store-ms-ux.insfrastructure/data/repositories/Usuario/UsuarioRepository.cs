using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using store_ms_ux.domain.entities;
using store_ms_ux.insfrastructure.CarpetaModels;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain;
using store_mx_ux.domain.DTOs.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_ms_ux.insfrastructure.data.repositories.Usuario
{
    public class UsuarioRepository : IUsuario
    {
        private readonly StoreDbContext _dataContext;
        private ILogger<UsuarioRepository> _logger;

        public UsuarioRepository(ILogger<UsuarioRepository> logger, StoreDbContext dataContext)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<List<UsuarioDBContext>> ListaUsuario()
        {
            try
            {
                var listUsuarios = await _dataContext.Usuarios.Select(u => new UsuarioDBContext
                {
                    IdUsuario = u.IdUsuario,
                    Email = u.Email,
                    FechaCreacion = u.FechaCreacion,
                    Clave = u.Clave,
                    Username = u.Username,
                }
                ).ToListAsync();

                return listUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual async Task<CrearResponse> CrearUsuario(CrearUsuarioDTO usuario)
        {
            try
            {
                var nuevoUsuario = new UsuarioDBContext
                {
                    Email = usuario.Email,
                    FechaCreacion = DateTime.Now,
                    IdUsuario = usuario.IdUsuario,
                    Clave = usuario.Clave,
                    Username = usuario.Username,

                };


                _dataContext.Add(nuevoUsuario);
                await _dataContext.SaveChangesAsync();
                return new CrearResponse();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
