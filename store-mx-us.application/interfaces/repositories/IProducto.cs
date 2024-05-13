using store_ms_ux.domain.entities;
using store_mx_ux.domain.DTOs.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_mx_us.application.interfaces.repositories
{
    public interface IProducto
    {
        Task<List<Producto>> ListaProductos();

        Task<List<Producto>> ProductoByID(Guid id_Categoria);

    }
}
