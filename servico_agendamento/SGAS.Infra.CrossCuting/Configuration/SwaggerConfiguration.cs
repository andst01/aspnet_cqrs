using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAS.Infra.CrossCuting.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));


            services.AddSwaggerGen
           (
               s =>
               {
                   s.SwaggerDoc
                   (
                       "v1"
                       , new OpenApiInfo
                       {
                           Version = "v1",
                           Title = "Api Agendamento",
                           Description = "Api Agendamento Swagger",
                           Contact = new OpenApiContact
                           {
                               // Name = "TransPetro",
                               Email = string.Empty
                           }
                       }

                   );





                   //s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                   //{
                   //    Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer 12345abcdef')",
                   //    Name = "Authorization",
                   //    In = ParameterLocation.Header,
                   //    Type = SecuritySchemeType.ApiKey,
                   //    Scheme = "Bearer"
                   //});

                   //s.AddSecurityRequirement(new OpenApiSecurityRequirement
                   // {
                   //     {
                   //         new OpenApiSecurityScheme
                   //         {
                   //             Reference = new OpenApiReference
                   //             {
                   //                 Type = ReferenceType.SecurityScheme,
                   //                 Id = "Bearer"
                   //             }
                   //         },Array.Empty<string>()
                   // }});
                   //});

                   s.CustomSchemaIds(x => x.FullName);
                   s.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
               }
           );
        }
    }
}
