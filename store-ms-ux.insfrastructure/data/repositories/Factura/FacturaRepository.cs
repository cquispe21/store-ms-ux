using Microsoft.Extensions.Logging;
using store_ms_ux.domain.entities;
using store_ms_ux.insfrastructure.CarpetaModels;
using store_ms_ux.insfrastructure.data.repositories.Usuario;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain.DTOs.Usuario;
using store_mx_ux.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using store_mx_ux.domain.DTOs.Factura;

namespace store_ms_ux.insfrastructure.data.repositories.Factura
{
    public class FacturaRepository : IFactura
    {
        private readonly StoreDbContext _dataContext;
        private ILogger<UsuarioRepository> _logger;

        public FacturaRepository(ILogger<FacturaRepository> logger, StoreDbContext dataContext)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
       
        public virtual async Task<CrearResponse> CrearFactura(FacturaDTO factura)
        {
            try
            {
             


                _dataContext.Add(factura);
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
