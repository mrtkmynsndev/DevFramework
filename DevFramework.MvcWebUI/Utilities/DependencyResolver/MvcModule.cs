using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;

namespace DevFramework.MvcWebUI.Utilities.DependencyResolver
{
    public class MvcModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var mvcAssembly = typeof(MvcApplication).Assembly;
            builder.RegisterControllers(mvcAssembly);
        }
    }
}