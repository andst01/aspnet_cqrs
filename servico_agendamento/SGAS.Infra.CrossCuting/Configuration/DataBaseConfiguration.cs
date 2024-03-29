using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGAS.Infra.Context;
using System;

namespace SGAS.Infra.CrossCuting.Configuration
{
    public static class DataBaseConfiguration
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<SGASContext>(x =>
               x.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));

           // services.AddDbContext<EventStoreSqlContext>(options =>
           //     options.UseSqlServer(configuration.GetConnectionString("DefaulConnectionString")));
        
        }
    }
}
