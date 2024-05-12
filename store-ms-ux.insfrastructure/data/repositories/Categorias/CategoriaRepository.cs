using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using store_ms_ux.domain.entities;
using store_ms_ux.insfrastructure.CarpetaModels;
using store_ms_ux.insfrastructure.data.repositories.Usuario;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain.DTOs.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_ms_ux.insfrastructure.data.repositories.Categorias
{
    public class CategoriaRepository : ICategoria
    {
        private readonly StoreDbContext _dbContext;
        private ILogger<CategoriaRepository> _logger;

        public CategoriaRepository(ILogger<CategoriaRepository> logger, StoreDbContext dataContext)
        {
            _dbContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<CategoriaDTO>> ListaCategorias()
        {
            try
            {
                var listUsuarios = await _dbContext.Categorias.Select(u => new CategoriaDTO
                {
                    Descripcion = u.Descripcion,
                    Idcategoria = u.Idcategoria,
                    Nombre = u.Nombre,
                    Fechacreacion = u.Fechacreacion,
                   
                  
                }
                ).ToListAsync();

                return listUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

   
}
