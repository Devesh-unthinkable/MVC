using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public PartialViewResult Login()
        {
            return PartialView();
        }
    }
}