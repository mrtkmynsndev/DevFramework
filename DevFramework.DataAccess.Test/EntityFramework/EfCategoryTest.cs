using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevFramework.DataAccess.Concrete.EntityFramework;
using DevFramework.DataAccess.Abstract;

namespace DevFramework.DataAccess.Test.EntityFramework
{
    [TestClass]
    public class EfCategoryTest
    {
        ICategoryDal _efCategoryDal;

        [TestInitialize]
        public void Start()
        {
            _efCategoryDal = new EfCategoryDal();
        }

        [TestMethod]
        public void Get_all_categories()
        {
            //Arrange
            var expectedValue = 8;

            //Actual
            var list = _efCategoryDal.GetList();

            //Asserts
            Assert.AreEqual(expected: expectedValue, list.Count);

        }

        [TestMethod]
        public void Get_start_with_s_character()
        {
            //Arrange
            var expectedValue = 1;
            var sChar = "s";

            //Actual
            var withScharacter = _efCategoryDal.GetList(x => x.CategoryName.ToLower().StartsWith(sChar));

            //Assert
            Assert.AreEqual(expected: expectedValue, withScharacter.Count);
        }
    }
}
