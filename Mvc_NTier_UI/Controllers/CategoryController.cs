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
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        public ActionResult Index()
        {
            var values = categoryManager.TGetList();
            return View(values);
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            categoryManager.TInsert(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = categoryManager.TGetByID(id);
            categoryManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var values = categoryManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            categoryManager.TUpdate(p);
            return RedirectToAction("Index");
        }
      
    }
}