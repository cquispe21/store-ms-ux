using Microsoft.AspNetCore.Mvc;
using store_ms_ux.domain.entities;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain.DTOs.Categoria;

namespace store_ms_ux.api.Controllers
{
    public class ProductoController
    {
        private readonly IProducto _productoRepository;

        public ProductoController(IProducto productoRepository)
        {
            _productoRepository = productoRepository ?? throw new ArgumentNullException(nameof(productoRepository));
        }
        [HttpGet]
        [Route("store/Producto/listaProductos")]
        public async Task<List<Producto>> ListaProductos()
        {
            try
            {
                var response = await _productoRepository.ListaProductos();
                return (response);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("store/Producto/idProducto")]
        public async Task<List<Producto>> ProductoByID(Guid id_Categoria)
        {
            try
            {
                var response = await _productoRepository.ProductoByID(id_Categoria);
                return (response);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
