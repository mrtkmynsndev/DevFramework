using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Business.Abstract;
using DevFramework.Entities.Concrete;
using DevFramework.DataAccess.Abstract;
using DevFramework.Core.CrossCuttingConcerns.FluentValidation;
using DevFramework.Business.ValidationRules.FluentValidation;
using DevFramework.Core.Aspects.Postsharp;

namespace DevFramework.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidator), AspectPriority =1)]
        public Product Add(Product entity)
        {
            //ValidatorTool.FluentValidate(new ProductValidator(), entity: entity);

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
