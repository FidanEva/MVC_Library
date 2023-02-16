using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;
namespace MVC_Library.Controllers
{
    public class WriterController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        // GET: Writer
        public ActionResult Index()
        {
            var values = db.tbl_writer.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(tbl_writer p)
        {
            db.tbl_writer.Add(p);
            db.SaveChanges();
            return RedirectToAction("AddWriter");
        }
        public ActionResult DelWriter(int id)
        {
            var w = db.tbl_writer.Find(id);
            db.tbl_writer.Remove(w);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BringWriter(int id)
        {
            var column = db.tbl_writer.Find(id);
            return View("BringWriter", column);
        }
        public ActionResult UpdateWriter(tbl_writer p)
        {
            var c = db.tbl_writer.Find(p.id);
            c.name = p.name;
            c.surname = p.surname;
            c.detail = p.detail;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}