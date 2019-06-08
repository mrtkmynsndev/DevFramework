using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DevFramework.Business.Abstract;
using DevFramework.Business.Concrete.Managers;
using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.DataAccess.Abstract;
using DevFramework.DataAccess.Concrete.EntityFramework;
using DevFramework.DataAccess.Concrete.NHibernate.Provider;
using Module = Autofac.Module;

namespace DevFramework.Business.DependencyResolver.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //base.Load(builder);

            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();

            builder.RegisterType<DbContext>().As<NorthwindContext>();
            builder.RegisterType<NHibernateProvider>().As<SqlServerProvider>();
            builder.RegisterType(typeof(EfQueryableRepository<>)).As(typeof(IQueryableRepository<>));

        }
    }
}
