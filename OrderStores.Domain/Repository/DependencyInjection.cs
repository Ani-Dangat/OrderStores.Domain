using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderStores.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderStores.Domain.Repository;

namespace OrderStores.Domain.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ApplicationDbContext>(opt => opt
                .UseSqlServer("Server=ANIKET\\MSSQLSERVER01; Database=OrderDb;Trusted_Connection=True;"));
            return services;
        }
    }
}