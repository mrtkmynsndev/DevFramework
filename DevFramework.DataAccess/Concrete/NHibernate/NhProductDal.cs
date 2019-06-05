using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Entities.Concrete;
using DevFramework.DataAccess.Abstract;

namespace DevFramework.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        public NhProductDal(NHibernateProvider nHibernateProvider) : base(nHibernateProvider)
        {
        }
    }
}
