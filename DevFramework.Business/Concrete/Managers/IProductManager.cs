using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Business.Abstract;
using DevFramework.Entities.Concrete;
using DevFramework.DataAccess.Abstract;
using DevFramework.DataAccess.Concrete.EntityFramework;

namespace DevFramework.Business.Concrete.Managers
{
    public class IProductManager : IProductService
    {
        IProductDal _productDal;
        public IProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product entity)
        {
            return _productDal.Add(entity);
        }

        public Product GetProductByID(int id)
        {
            return _productDal.Get(x => x.ProductId == id);
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetList();
        }
    }
}
