using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Entities.Base
{
    public interface ISpecificationEntity<T> : IEntity
    {
        T Id { get; set; }
    }
}
