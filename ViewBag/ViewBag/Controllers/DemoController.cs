using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag.Controllers
{
    public class DemoController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Name = "Ashish";
            ViewBag.products = new List<string>()
            {
                "Television",
                "Smart Phone",
                "Camera"
            };
            return View();
        }
    }
}