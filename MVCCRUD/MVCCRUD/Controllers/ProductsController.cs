using MVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCRUD.Models;
using System.Net;

namespace MVCCRUD.Controllers
{
    public class ProductsController : Controller
    {
        ProductsContext obj = new ProductsContext();
        public ViewResult Index()
        {
            return View(obj.ProductsTable.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "ID not defined: Bad Request");
            }
            Product product = obj.ProductsTable.Find(id);
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Invalid ID: Not Found");
            }
            return View(product);
        }
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection frmColn)
        {
            Product product = new Product();
            product.Name = frmColn["Name"];
            product.Price = Convert.ToDecimal(frmColn["Price"]);

            obj.ProductsTable.Add(product);
            obj.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Id is Required");
            }
            Product product = obj.ProductsTable.Find(id);
            if(product==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Product not found");
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Id is Required");
            }
            Product product = obj.ProductsTable.Find(id);
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Product not found");
            }
            UpdateModel(product);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Id is required");
            }
            Product product = obj.ProductsTable.Find(id);
            if(product==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Product not found");
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Product product = obj.ProductsTable.Find(id);
            obj.ProductsTable.Remove(product);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}