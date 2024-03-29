using Microsoft.Extensions.DependencyInjection;
using SGAS.Infra.CrossCuting.AutoMapper;
using System;

namespace SGAS.Infra.CrossCuting.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), 
                                   typeof(DomainToEventMappingProfile),
                                   typeof(ViewModelToCommandMappingProfile), 
                                   typeof(EventToViewModelMappingProfile),
                                   typeof(CommandToDomainMappingProfile),
                                   typeof(CommandToEventMappingProfile));
        }
    }
}
