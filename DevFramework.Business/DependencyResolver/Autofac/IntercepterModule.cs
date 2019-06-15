using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using DevFramework.Core.Utilities.Intercepters;
using Module = Autofac.Module;

namespace DevFramework.Business.DependencyResolver.Autofac
{
    public class IntercepterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectIntercepterSelector()
                }).SingleInstance();

        }
    }
}
