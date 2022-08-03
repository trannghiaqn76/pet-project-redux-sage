using name_api.Services.Interface;
using name_api.Services.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace name_api.Services.Collection
{
    public static class ServiceCollection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IDapper, DapperRepository>();
            return services;
        }
    }
}
