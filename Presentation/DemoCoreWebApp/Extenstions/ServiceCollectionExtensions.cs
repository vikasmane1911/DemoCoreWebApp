using Autofac;
using Autofac.Extensions.DependencyInjection;
using DemoCoreWebApp.Core.Interfaces;
using DemoCoreWebApp.Data;
using DemoCoreWebApp.Services;
using DemoCoreWebApp.Web.Factories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoCoreWebApp.Web.Extenstions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceProvider ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            var containerBuilder = new ContainerBuilder();

            //Factories
            containerBuilder.RegisterType<CategoryModelFactory>().As<ICategoryModelFactory>().InstancePerLifetimeScope();

            //Services
            containerBuilder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();

            //repository
            containerBuilder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            //populate Autofac container builder with the set of registered service descriptors
            containerBuilder.Populate(services);

            //create and return service provider
            return new AutofacServiceProvider(containerBuilder.Build());
        }
    }
}
