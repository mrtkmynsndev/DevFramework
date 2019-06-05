using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevFramework.DataAccess.Concrete.NHibernate;
using DevFramework.DataAccess.Concrete.NHibernate.Provider;

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
            NhProductDal nhProductDal = new NhProductDal(new SqlServerProvider());

            //Actual
            var result = nhProductDal.GetList();

            //Asserts
            Assert.AreEqual(expected: expectedValue, result.Count);
        }
    }
}
