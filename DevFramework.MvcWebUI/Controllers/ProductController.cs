using DevFramework.Business.Abstract;
using DevFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFramework.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public ActionResult Index()
        {
            var model = new ProductListViewModel()
            {
                Products = _productService.GetProducts()
            };

            return View(model);
        }

        public ActionResult Add()
        {
            var entity = new Product()
            {
                ProductName = "Laptop",
            };


            _productService.Add(entity);

            return Json("Added", JsonRequestBehavior.AllowGet);
        }
    }
}