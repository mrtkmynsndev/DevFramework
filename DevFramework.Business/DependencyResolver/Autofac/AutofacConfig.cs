using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Business.DependencyResolver.Autofac
{
    public class AutofacConfig
    {
        public static IContainer ConfigureAutofac()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new BusinessModule());
            return containerBuilder.Build();
        }
    }
}
