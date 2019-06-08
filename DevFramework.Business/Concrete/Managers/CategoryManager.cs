using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Business.Abstract;
using DevFramework.Entities.Concrete;
using DevFramework.DataAccess.Abstract;
using DevFramework.Core.Aspects.Postsharp;
using DevFramework.Business.ValidationRules.FluentValidation;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;

namespace DevFramework.Business.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }

        [FluentValidationAspect(typeof(CategoryValidator), AspectPriority =1)]
        public Category Add(Category enttiy)
        {
            return _categoryDal.Add(enttiy);
        }

        public Category Update(Category entity)
        {
            return _categoryDal.Update(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.Get(filter);
        }
    }
}
