using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Business.ValidationRules.FluentValidation;
using DevFramework.Entities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace DevFramework.Business.DependencyResolver.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
    }
}
