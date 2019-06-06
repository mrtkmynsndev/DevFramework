using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Entities.Concrete;

namespace DevFramework.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductByID(int id);
        Product Add(Product entity);
    }
}
