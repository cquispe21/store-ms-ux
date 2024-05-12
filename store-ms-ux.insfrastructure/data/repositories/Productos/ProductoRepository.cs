﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using store_ms_ux.domain.entities;
using store_ms_ux.insfrastructure.CarpetaModels;
using store_ms_ux.insfrastructure.data.repositories.Categorias;
using store_mx_us.application.interfaces.repositories;
using store_mx_ux.domain.DTOs.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_ms_ux.insfrastructure.data.repositories.Productos
{
    public class ProductoRepository : IProducto
    {
        private readonly StoreDbContext _dbContext;
        private ILogger<ProductoRepository> _logger;

        public ProductoRepository(ILogger<ProductoRepository> logger, StoreDbContext dataContext)
        {
            _dbContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<Producto>> ListaProductos()
        {
            try
            {
                var listUsuarios = await _dbContext.Productos.Select(u => new Producto
                {
                    Descripcion = u.Descripcion,
                    Fechacreacion = u.Fechacreacion,
                    Imagen = u.Imagen,
                    Nombre = u.Nombre,
                    Precio = u.Precio,
                    Idcategoria = u.Idcategoria,
                    IdcategoriaNavigation = u.IdcategoriaNavigation

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
