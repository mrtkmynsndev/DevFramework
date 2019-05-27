using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.DataAccess.Abstract;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Entities.Concrete;

namespace DevFramework.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
