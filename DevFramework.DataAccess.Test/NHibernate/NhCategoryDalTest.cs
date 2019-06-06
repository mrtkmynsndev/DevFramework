using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevFramework.DataAccess.Concrete.NHibernate;
using DevFramework.DataAccess.Concrete.NHibernate.Provider;

namespace DevFramework.DataAccess.Test.NHibernate
{
    [TestClass]
    public class NhCategoryDalTest
    {
        NhCategoryDal _nhCategoryDal;

        [TestInitialize]
        public void Start()
        {
            _nhCategoryDal = new NhCategoryDal(new SqlServerProvider());
        }

        [TestMethod]
        public void Get_all_category()
        {
            //Arrange
            var expectedValue = 8;
            //Actual
            var allCategory = _nhCategoryDal.GetList();

            //Assert
            Assert.AreEqual(expected: expectedValue, allCategory.Count);
        }

        [TestMethod]
        public void Get_start_with_s_character()
        {
            //Arrange
            var expectedValue = 1;
            var startWithByLower = "s";
            //Actual
            var startWithCategory = _nhCategoryDal.GetList(x => x.CategoryName.ToLower().StartsWith(startWithByLower));
            //Assert
            Assert.AreEqual(expectedValue, startWithCategory.Count);
        }
    }
}
