using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevFramework.DataAccess.Concrete.NHibernate;
using DevFramework.DataAccess.Concrete.NHibernate.Provider;
using DevFramework.DataAccess.Abstract;

namespace DevFramework.DataAccess.Test.NHibernate
{
    [TestClass]
    public class NhProductDalTest
    {
        [TestMethod]
        public void Get_all_products()
        {
            //Arrange
            var expectedValue = 77;
            IProductDal nhProductDal = new NhProductDal(new SqlServerProvider());

            //Actual
            var result = nhProductDal.GetList();

            //Asserts
            Assert.AreEqual(expected: expectedValue, result.Count);
        }

        [TestMethod]
        public void Get_all_product_details()
        {
            //Arrange
            var expectedValue = 77;
            IProductDal nhProductDal = new NhProductDal(new SqlServerProvider());

            //Actual
            var result = nhProductDal.GetProductDetails();

            //Asserts
            Assert.AreEqual(expected: expectedValue, result.Count);
        }
    }
}
