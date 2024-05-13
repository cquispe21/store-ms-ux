using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using store_ms_ux.insfrastructure.CarpetaModels;
using store_ms_ux.insfrastructure.data.repositories.Productos;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain.DTOs.Factura;
using store_mx_ux.domain.DTOs.ReporteDownload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace store_ms_ux.insfrastructure.data.repositories.ReporteDownload
{
    public class ReporteDownloadRepository : IReporte
    {
        private readonly StoreDbContext _dbContext;

        private ILogger<ReporteDownloadRepository> _logger;

        private readonly IConfiguration _configuracion;


        public ReporteDownloadRepository(ILogger<ReporteDownloadRepository> logger, StoreDbContext dataContext, IConfiguration configuracion)
        {
            _dbContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuracion = configuracion ?? throw new ArgumentNullException(nameof(configuracion));

        }

        public async Task<string> ReporteDownload(NuevaFacturaDTO reporteDownloadDTO)
        {
            var urlride = _configuracion.GetConnectionString("GenerarPDF");
            using HttpClient Cliente = new();
            var json = JsonConvert.SerializeObject(reporteDownloadDTO);
            var contentJSON = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

            var Request = new HttpRequestMessage
            {
                RequestUri = new Uri(urlride),
                Content = contentJSON,
                Method = HttpMethod.Post

            };
            var Response = await Cliente.SendAsync(Request);
            string base64String = await Response.Content.ReadAsStringAsync();

         
            return base64String;

        }
    }

  
}
