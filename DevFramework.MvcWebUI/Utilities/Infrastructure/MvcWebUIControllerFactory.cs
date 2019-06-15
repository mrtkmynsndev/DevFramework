using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Core;
using DevFramework.Business.DependencyResolver.Autofac;
using DevFramework.MvcWebUI.Utilities.DependencyResolver;
using Ninject;
using Ninject.Modules;

namespace DevFramework.MvcWebUI.Utilities.Infrastructure
{
    public class MvcWebUiControllerFactory : IMvcWebUiControllerFactory
    {
        public IControllerFactory CreateControllerFactory(Type type)
        {
            IControllerFactory controllerFactory = null;

            if (type == typeof(AutoFacControllerFactory))
            {
                var container = this.CreateContainer();
                controllerFactory = new AutoFacControllerFactory(container);
            }
            if (type == typeof(NinjectControllerFactory))
            {
                var module = this.CreateNinjectModule();
                controllerFactory = new NinjectControllerFactory(module);
            }

            return controllerFactory;
        }

        public IContainer CreateContainer()
        {
            return AutofacConfig.AddDependencyResolver(new IModule[]
            {
                new DevFramework.Business.DependencyResolver.Autofac.BusinessModule(),
                new MvcModule()
            });
        }

        public INinjectModule[] CreateNinjectModule()
        {
            return new INinjectModule[]
            {
                new DevFramework.Business.DependencyResolver.Ninject.BusinessModule()
            };
        }
    }

    public interface IMvcWebUiControllerFactory
    {
        IControllerFactory CreateControllerFactory(Type type);
        IContainer CreateContainer();
        INinjectModule[] CreateNinjectModule();
    }

}