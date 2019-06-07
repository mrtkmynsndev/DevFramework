using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Entities.Concrete;

namespace DevFramework.Business.Abstract
{
    public interface ICategoryService
    {
        Category Add(Category enttiy);
        Category Update(Category entity);
        Category Get(Expression<Func<Category, bool>> filter);
    }
}
