using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;

namespace DevFramework.MvcWebUI.Utilities.Infrastructure
{
    public class AutoFacControllerFactory : DefaultControllerFactory
    {
        readonly IContainer _container;

        public AutoFacControllerFactory(IContainer container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_container.Resolve(controllerType);
        }
    }
}