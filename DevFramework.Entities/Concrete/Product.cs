using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace DevFramework.Entities.Concrete
{
    public class Product : IEntity
    {
        public virtual int ProductId { get; set; } // ProductID (Primary key)
        public virtual string ProductName { get; set; } // ProductName (length: 40)
        public virtual int? SupplierId { get; set; } // SupplierID
        public virtual int? CategoryId { get; set; } // CategoryID
        public virtual string QuantityPerUnit { get; set; } // QuantityPerUnit (length: 20)
        public virtual decimal? UnitPrice { get; set; } // UnitPrice
        public virtual short? UnitsInStock { get; set; } // UnitsInStock
        public virtual short? UnitsOnOrder { get; set; } // UnitsOnOrder
        public virtual short? ReorderLevel { get; set; } // ReorderLevel
        public virtual bool Discontinued { get; set; } // Discontinued
    }
}
