using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentValidation;
using DevFramework.DataAccess.Abstract;
using DevFramework.Business.Abstract;
using DevFramework.Business.Concrete.Managers;
using DevFramework.Entities.Concrete;

namespace DevFramework.Business.Test
{
    [TestClass]
    public class ProductManagerTest
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            IProductService productService = new ProductManager(mock.Object);
            productService.Add(new Product());
        }
    }
}
