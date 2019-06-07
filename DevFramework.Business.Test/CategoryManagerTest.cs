using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevFramework.Entities.Concrete;
using DevFramework.DataAccess.Abstract;
using DevFramework.Business.Abstract;
using DevFramework.Business.Concrete.Managers;
using FluentValidation;
using Moq;

namespace DevFramework.Business.Test
{
    [TestClass]
    public class CategoryManagerTest
    {
        IMock<ICategoryDal> _mockCategoryDal;
        ICategoryService _categoryService;

        [TestInitialize]
        public void Start()
        {
            _mockCategoryDal = new Mock<ICategoryDal>();

            _categoryService = new CategoryManager(_mockCategoryDal.Object);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Check_category_add_rules()
        {
            _categoryService.Add(new Category());
        }
    }
}
