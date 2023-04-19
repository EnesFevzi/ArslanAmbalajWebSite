using ArslanElArabaları.DataAccessLayer.Abstract;
using ArslanElArabaları.DataAccessLayer.Concrete.EntityFramework;
using ArslanElArabaları.DataAccessLayer.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.DataAccessLayer.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAboutRepository, EfAboutRepository>();
            services.AddScoped<IContactRepository, EfContactRepository>();
            services.AddScoped<IExperienceRepository, EfExperienceRepository>();
            services.AddScoped<IPostRepository, EfPostRepository>();
            services.AddScoped<IProductRepository, EfProductRepository>();
            return services;


        }
    }
}
