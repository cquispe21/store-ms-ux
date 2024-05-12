using store_mx_ux.domain.DTOs.ReporteDownload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_mx_us.application.interfaces.repositories
{
    public interface IReporte
    {
        Task<Stream> ReporteDownload(ReporteDownloadDTO reporteDownloadDTO);
    }
}
