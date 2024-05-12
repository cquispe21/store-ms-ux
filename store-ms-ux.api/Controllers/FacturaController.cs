using Microsoft.AspNetCore.Mvc;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain.DTOs.Categoria;
using store_mx_ux.domain.DTOs.Factura;

namespace store_ms_ux.api.Controllers
{
    public class FacturaController : ControllerBase
    {
        private readonly IFactura _facturaRepository;

        public FacturaController(IFactura facturaRepository)
        {
            _facturaRepository = facturaRepository ?? throw new ArgumentNullException(nameof(facturaRepository));
        }
        [HttpPost]
        [Route("store/Factura/CrearFactura")]
        public async Task<ActionResult> CrearFactura(FacturaDTO factura)
        {
            try
            {
                var response = await _facturaRepository.CrearFactura(factura);
                //return (response);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
