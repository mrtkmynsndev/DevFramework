using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevFramework.DataAccess.Concrete.EntityFramework;
using DevFramework.DataAccess.Abstract;
using DevFramework.Entities.Concrete;
using Moq;
using System.Linq.Expressions;

namespace DevFramework.DataAccess.Test.EntityFramework
{
    [TestClass]
    public class EfProductDalTest
    {
        IProductDal _productDal;
        Mock<IProductDal> mockProductDal;
        List<Product> _product;

        [TestInitialize]
        public void Start()
        {
            _productDal = new EfProductDal();
            mockProductDal = new Mock<IProductDal>();
            _product = new List<Product>()
            {
                new Product()
                {
                    ProductId = 1,
                    CategoryId = 2,
                    Discontinued = true,
                    ProductName = "Computer",
                    QuantityPerUnit = "5",
                    ReorderLevel = 1,
                    SupplierId = 25,
                    UnitPrice = 10.50m,
                    UnitsInStock = 10,
                    UnitsOnOrder = 1
                },
                new Product()
                {
                    ProductId = 2,
                    CategoryId = 2,
                    Discontinued = true,
                    ProductName = "Laptop",
                    QuantityPerUnit = "5",
                    ReorderLevel = 1,
                    SupplierId = 25,
                    UnitPrice = 10.50m,
                    UnitsInStock = 10,
                    UnitsOnOrder = 1
                },
                new Product()
                {
                    ProductId = 3,
                    CategoryId = 2,
                    Discontinued = true,
                    ProductName = "Mouse",
                    QuantityPerUnit = "5",
                    ReorderLevel = 1,
                    SupplierId = 25,
                    UnitPrice = 10.50m,
                    UnitsInStock = 10,
                    UnitsOnOrder = 1
                }
            };

            mockProductDal.Setup(m => m.Add(It.IsAny<Product>())).Returns(It.IsAny<Product>());
            mockProductDal.Setup(m => m.GetList(null)).Returns(_product);

        }

        [TestMethod]
        public void Get_all_products()
        {
            //Arrange
            var expectedValue = 77;
            var expectedMockValue = 3;

            //Act
            var products = _productDal.GetList();
            //mockProductDal.Object.Add(It.IsAny<Product>());
            var mockProducts = mockProductDal.Object.GetList(null);
            //Asserts
            Assert.AreEqual(expectedValue, products.Count);
            Assert.AreEqual(expectedMockValue, mockProducts.Count);
        }

        public void Add_product()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}


/*
 * Arrange -> Requirement for Test
 * Act -> Get Action for Test
 * Assert -> 
 */
