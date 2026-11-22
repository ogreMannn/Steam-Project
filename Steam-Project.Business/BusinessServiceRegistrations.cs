using Microsoft.Extensions.DependencyInjection;
using Steam_Project.Business.Services.Implementations;
using Steam_Project.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Business
{
    public static class BusinessServiceRegistrations
    {
        public static void AddBusinessService(this IServiceCollection services)
        {
            services.AddAutoMapper(
            cfg => { },
            typeof(BusinessServiceRegistrations).Assembly
            );

            services.AddScoped<ICategoryService, CategoryService>();
        }
        
    }
}
