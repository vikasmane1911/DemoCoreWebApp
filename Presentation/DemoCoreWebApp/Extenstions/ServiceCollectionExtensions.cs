using Autofac;
using Autofac.Extensions.DependencyInjection;
using DemoCoreWebApp.Core.Interfaces;
using DemoCoreWebApp.Data.Repositories;
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

            containerBuilder.RegisterType<PatientModelFactory>().As<IPatientModelFactory>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<PatientRepository>().As<IPatientRepository>().InstancePerLifetimeScope();

            //populate Autofac container builder with the set of registered service descriptors
            containerBuilder.Populate(services);

            //create and return service provider
            return new AutofacServiceProvider(containerBuilder.Build());
        }
    }
}
