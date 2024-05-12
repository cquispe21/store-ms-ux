using store_mx_ux.domain.DTOs.Usuario;
using store_mx_ux.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using store_mx_ux.domain.DTOs.Factura;

namespace store_mx_us.application.interfaces.repositories
{
    public interface IFactura
    {
        Task<CrearResponse> CrearFactura(FacturaDTO factura);
    }
}
