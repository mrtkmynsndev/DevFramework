using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Entities.Concrete;
using DevFramework.Core.DataAccess;

namespace DevFramework.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
