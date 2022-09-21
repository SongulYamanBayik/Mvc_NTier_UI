using BusinessLayer.Concrete;
using DAL.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_NTier_UI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager( new EFProductDal());
        // GET: Product
        public ActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            productManager.TInsert(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int id)
        {
            var value = productManager.TGetByID(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            var value = productManager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditProduct(Product p)
        {
            productManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}