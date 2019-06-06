using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.DataAccess.Abstract;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Entities.Concrete;
using DevFramework.Entities.ComplexTypes;

namespace DevFramework.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (var context = new NorthwindContext())
            {
                var result = from x in context.Products
                             join c in context.Categories on x.CategoryId equals c.Id
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
