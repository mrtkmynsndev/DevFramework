using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Business.Abstract;
using DevFramework.Business.Concrete.Managers;
using DevFramework.DataAccess.Abstract;
using DevFramework.DataAccess.Concrete.EntityFramework;
using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using Ninject.Modules;
using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.DataAccess.Concrete.NHibernate.Provider;

namespace DevFramework.Business.DependencyResolver.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHibernateProvider>().To<SqlServerProvider>();
        }
    }
}
