using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Feature.SimpleComponent.Controllers;
using Sitecore.Feature.SimpleComponent.Repositories;

namespace Sitecore.Feature.SimpleComponent.Pipelines
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISimpleComponentRepository, SimpleComponentRepository>();
            serviceCollection.AddTransient<ISimpleVariantComponentRepository, SimpleVariantComponentRepository>();

            serviceCollection.AddTransient<SimpleComponentController>();
            serviceCollection.AddTransient<SimpleVariantComponentController>();

        }
    }
}