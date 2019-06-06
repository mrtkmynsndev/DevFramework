using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities.Base;

namespace DevFramework.Entities.Concrete
{
    public class Category : ISpecificationEntity<int>
    {
        public virtual int Id { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string Description { get; set; }
        public virtual byte[] Picture { get; set; }
    }
}
