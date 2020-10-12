using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelViewsDemo.Models;

namespace ModelViewsDemo.Controllers
{
    public class ProductsController : Controller
    {
        ProductData obj = new ProductData();
        public ViewResult ProductList()
        {
            return View(obj.ProductList.ToList());
        }

        public ViewResult Details(int ID)
        {
            Product product = obj.ProductList.Single(x => x.ProductID == ID);
            return View(product);
        }
    }
}