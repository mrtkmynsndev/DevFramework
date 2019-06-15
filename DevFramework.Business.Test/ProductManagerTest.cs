using System;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentValidation;
using DevFramework.DataAccess.Abstract;
using DevFramework.Business.Abstract;
using DevFramework.Business.Concrete.Managers;
using DevFramework.Entities.Concrete;
using Autofac.Extras.FakeItEasy;
using DevFramework.Business.DependencyResolver.Autofac;

namespace DevFramework.Business.Test
{
    [TestClass]
    public class ProductManagerTest
    {
        private IContainer _container;
        [TestInitialize]
        public void SetUp()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new BusinessModule());
            _container = containerBuilder.Build();
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            IProductService productService = new ProductManager(mock.Object);
            productService.Add(new Product());
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check_with_Autofac()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            IProductService service2 = _container.Resolve<IProductService>();
            IProductService productService = new ProductManager(mock.Object);
            service2.Add(new Product());
            productService.Add(new Product());

        }
    }
}
