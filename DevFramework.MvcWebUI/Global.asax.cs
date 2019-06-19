using DevFramework.Business.DependencyResolver.Ninject;
using DevFramework.MvcWebUI.Utilities.Infrastructure;
using DevFramework.MvcWebUI.Utilities.Provider;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using DevFramework.Business.DependencyResolver.Autofac;
using DevFramework.MvcWebUI.Utilities.DependencyResolver;

namespace DevFramework.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //GlobalContext.Properties["UserName"] = "Mert";

            //ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));
            //ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //builder.RegisterModule(new DevFramework.Business.DependencyResolver.Autofac.BusinessModule());
            //ControllerBuilder.Current.SetControllerFactory(new AutoFacControllerFactory(builder.Build()));

            var controllerFactory = new MvcWebUiControllerFactory();
            ControllerBuilder.Current.SetControllerFactory(
                controllerFactory.CreateControllerFactory(typeof(NinjectControllerFactory)));

            //ControllerBuilder.Current.SetControllerFactory(new AutoFacControllerFactory(
            //    AutofacConfig.AddDependencyResolver(new IModule[]
            //    {
            //        new DevFramework.Business.DependencyResolver.Autofac.BusinessModule(),
            //        new MvcModule(),
            //    })));

        }
    }
}
