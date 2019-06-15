using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Core;

namespace DevFramework.Business.DependencyResolver.Autofac
{
    public class AutofacConfig
    {
        private static IContainer _container;
        public static IContainer ConfigureAutofac()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new BusinessModule());
            return containerBuilder.Build();
        }

        public static IContainer AddDependencyResolver(IModule[] modules)
        {
            var builder = new ContainerBuilder();

            foreach (var module in modules)
            {
                builder.RegisterModule(module);
            }

            return _container = builder.Build();
        }
    }
}
