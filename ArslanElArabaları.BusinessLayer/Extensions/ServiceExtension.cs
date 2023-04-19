using ArslanElArabaları.BusinessLayer.Abstract;
using ArslanElArabaları.BusinessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArslanElArabaları.BusinessLayer.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IPostService, PostManager>();
            services.AddScoped<IProductService, ProductManager>();
            return services;


        }
    }
}
