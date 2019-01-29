using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Democore.Project.Website.DependencyInjection
{
    public class PropertyInjectionDisabler : IPropertyDependencySelector
    {
        public IEnumerable<PropertyDependency> Execute(Type type)
        {
            return new PropertyDependency[0];
        }
    }
}