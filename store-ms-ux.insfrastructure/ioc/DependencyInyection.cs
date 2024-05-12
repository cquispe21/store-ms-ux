using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using store_ms_ux.insfrastructure.CarpetaModels;
using store_ms_ux.insfrastructure.data.repositories;
using store_ms_ux.insfrastructure.data.repositories.Categorias;
using store_ms_ux.insfrastructure.data.repositories.Factura;
using store_ms_ux.insfrastructure.data.repositories.Productos;
using store_ms_ux.insfrastructure.data.repositories.Usuario;
using store_mx_us.application.interfaces.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_ms_ux.insfrastructure.ioc
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddInfractructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUsuario, UsuarioRepository>();
            services.AddScoped<ICategoria, CategoriaRepository>();
            services.AddScoped<IProducto, ProductoRepository>();
            services.AddScoped<IFactura, FacturaRepository>();

            var builderConnection = new NpgsqlConnectionStringBuilder(configuration.GetConnectionString("defaultConnection"));

            services.AddDbContext<StoreDbContext>(options =>
            {
                options.UseNpgsql(builderConnection.ConnectionString);
            }, ServiceLifetime.Transient
            );

            return services;
        }
    }
}
