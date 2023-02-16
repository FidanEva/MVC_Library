using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;
namespace MVC_Library.Controllers
{
    public class CategoryController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            var columns = db.tbl_category.ToList();
            return View(columns);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(tbl_category p)
        {
            db.tbl_category.Add(p);
            db.SaveChanges();
            return View();
        }

      
        public ActionResult DelCategory(int id)
        {
            var category = db.tbl_category.Find(id);
            db.tbl_category.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult BringCategory(int id) //id ye gore datani getirirsen
        {
            var ctg = db.tbl_category.Find(id);
            return View("BringCategory", ctg);
        }

        [HttpPost]
        public ActionResult UpdateCategory(tbl_category p) //datani bura post eliyirsen formdan
        {
            var ctg = db.tbl_category.Find(p.id);
            ctg.name = p.name;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}