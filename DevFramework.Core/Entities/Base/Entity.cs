using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Entities.Base
{
    public abstract class Entity<T> : ISpecificationEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
