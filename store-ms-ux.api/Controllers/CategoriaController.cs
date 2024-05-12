using Microsoft.AspNetCore.Mvc;
using store_ms_ux.domain.entities;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain.DTOs.Categoria;
using store_mx_ux.domain.DTOs.Usuario;

namespace store_ms_ux.api.Controllers
{
    public class CategoriaController
    {
        private readonly ICategoria _cateogoriaRepository;

        public CategoriaController(ICategoria categoriaRepository)
        {
            _cateogoriaRepository = categoriaRepository ?? throw new ArgumentNullException(nameof(categoriaRepository));
        }
        [HttpGet]
        [Route("store/Categoria/listaCategorias")]
        public async Task<List<CategoriaDTO>> ListaCategorias()
        {
            try
            {
                var response = await _cateogoriaRepository.ListaCategorias();
                return (response);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
  
    };
}
