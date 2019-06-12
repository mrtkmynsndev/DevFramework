using System.Collections.Generic;
using DevFramework.Entities.Concrete;

namespace DevFramework.MvcWebUI
{
    public class ProductListViewModel
    {
        public ProductListViewModel()
        {
            Products = new List<Product>();
        }

        public List<Product> Products { get; set; }
    }
}