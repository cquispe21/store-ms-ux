using Microsoft.AspNetCore.Mvc;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain.DTOs.ReporteDownload;

namespace store_ms_ux.api.Controllers
{
    public class ReporteDownloadController : ControllerBase
    {
        private readonly IReporte _reporteRepository;

        public ReporteDownloadController(IReporte reporteRepository)
        {
            _reporteRepository = reporteRepository ?? throw new ArgumentNullException(nameof(reporteRepository));
        }

        [HttpGet]
        [Route("store/ReporteDownload/DescargarPDF")]
        public async Task<ActionResult> ReporteDownload(ReporteDownloadDTO reporteDownloadDTO)
        {
            try
            {
                var response = await _reporteRepository.ReporteDownload(reporteDownloadDTO);
                  return File(response, "application/pdf", "nombre_del_archivo.pdf"); ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
