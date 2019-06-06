using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Entities.Concrete;
using DevFramework.DataAccess.Abstract;
using DevFramework.Entities.ComplexTypes;

namespace DevFramework.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        NHibernateProvider _nHibernateProvider;
        public NhProductDal(NHibernateProvider nHibernateProvider) : base(nHibernateProvider)
        {
            _nHibernateProvider = nHibernateProvider;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using(var session = _nHibernateProvider.OpenSession())
            {
                var result = from x in session.Query<Product>()
                             join c in session.Query<Category>() on x.CategoryId equals c.Id
                             select new ProductDetail()
                             {
                                 ProductId = x.ProductId,
                                 ProductName = x.ProductName,
                                 CategoryName = c.CategoryName
                             };

                return result.ToList();
            }
        }
    }
}
