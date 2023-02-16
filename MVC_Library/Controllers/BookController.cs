using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;
namespace MVC_Library.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        public ActionResult Index(string p)
        {
            var values = from b in db.tbl_book.Where(q=>(bool)q.book_status) select b; //statusu true, yeni 1 olanlari getir
            if (!string.IsNullOrEmpty((p)))
            {
                values = values.Where(v => v.name.Contains(p));
            }
            return View(values.ToList());
        }
        [HttpGet]
        public ActionResult AddBook()
        {
            List<SelectListItem> wrt = (from i in db.tbl_writer.ToList()
                                            select new SelectListItem
                                            {
                                                Text = i.name + " " + i.surname,
                                                Value = i.id.ToString()
                                            }).ToList();
            ViewBag.writers = wrt;
            List<SelectListItem> ctg = (from i in db.tbl_category.ToList()
                                        select new SelectListItem
                                        {
                                            Text = i.name,
                                            Value = i.id.ToString()
                                        }).ToList();
            ViewBag.categories = ctg;
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(tbl_book p)
        {
            //var c = db.tbl_category.Where(k => k.id == p.tbl_category.id).FirstOrDefault();
            //var w = db.tbl_writer.Where(k => k.id == p.tbl_writer.id).FirstOrDefault();
            //p.tbl_category = c;
            //p.tbl_writer = w;
            db.tbl_book.Add(p);
            db.SaveChanges();
            return RedirectToAction("AddBook");
        }
        public ActionResult DelBook(int id)
        {
            var book = db.tbl_book.Find(id);
            db.tbl_book.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BringBook(int id)
        {
            var book = db.tbl_book.Find(id);
            List<SelectListItem> wrt = (from i in db.tbl_writer.ToList()
                                        select new SelectListItem
                                        {
                                            Text = i.name + " " + i.surname,
                                            Value = i.id.ToString()
                                        }).ToList();
            ViewBag.writers = wrt;
            List<SelectListItem> ctg = (from i in db.tbl_category.ToList()
                                        select new SelectListItem
                                        {
                                            Text = i.name,
                                            Value = i.id.ToString()
                                        }).ToList();
            ViewBag.categories = ctg;
            return View("BringBook", book);
        }

        public ActionResult UpdateBook(tbl_book p)
        {
            var book = db.tbl_book.Find(p.id);
            book.name = p.name;
            book.page = p.page;
            book.publication_year = p.publication_year;
            book.publisher = p.publisher;
            book.book_status = true;
            var ctg = db.tbl_category.Where(k => k.id == p.tbl_category.id).FirstOrDefault();
            var wrt = db.tbl_writer.Where(k => k.id == p.tbl_writer.id).FirstOrDefault();
            book.category = ctg.id;
            book.writer = wrt.id;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}