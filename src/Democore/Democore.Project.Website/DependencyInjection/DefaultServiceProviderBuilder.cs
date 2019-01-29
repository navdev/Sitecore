using LightInject;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LightInject.Microsoft.DependencyInjection;
using Sitecore.Abstractions;

namespace Democore.Project.Website.DependencyInjection
{
    public class DefaultServiceProviderBuilder : BaseServiceProviderBuilder
    {
        protected override IServiceProvider BuildServiceProvider(IServiceCollection serviceCollection)
        {
            System.Diagnostics.Debugger.Launch();
            var container = new ServiceContainer() { PropertyDependencySelector = new PropertyInjectionDisabler() };
            var lightInjectProvider = container.CreateServiceProvider(serviceCollection);
            var microsoftProvider = serviceCollection.BuildServiceProvider();
            var t = lightInjectProvider.GetService<BaseCorePipelineManager>();
            var t1 = microsoftProvider.GetService<BaseCorePipelineManager>();
            return lightInjectProvider;
        }
    }
}