using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public ViewResult Index()
        {
            ViewData["Name"] = "Jaskirat";
            ViewData["Products"] = new List<string>()
            {
                "Television",
                "Smart phone"
            };
            return View();
        }
    }
}