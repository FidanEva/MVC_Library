using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;
using MVC_Library.Models.Classes;
namespace MVC_Library.Controllers
{
    public class vitrinController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        // GET: vitrin
        [HttpGet]
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Book = db.tbl_book.ToList();
            cs.About = db.tbl_about.ToList();
            //var values = db.tbl_book.ToList();
            return View(cs);
        }
        [HttpPost]
        public ActionResult Index(tbl_contact c)
        {
            db.tbl_contact.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}