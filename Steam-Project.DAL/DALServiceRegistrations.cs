using Microsoft.Extensions.DependencyInjection;
using Steam_Project.DAL.Repositories.Implementations;
using Steam_Project.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.DAL
{
    public static  class DALServiceRegistrations
    {
        public static void AddDALService(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
