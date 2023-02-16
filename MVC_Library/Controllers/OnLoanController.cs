using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;

namespace MVC_Library.Controllers
{
    public class OnLoanController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        // GET: LendBook
        public ActionResult Index()
        {
            var values = db.tbl_action.Where(k => k.action_status == false).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult LendBook()
        {
            List<SelectListItem> book = (from i in db.tbl_book.ToList()
                                         where i.book_status == true
                                        select new SelectListItem
                                        {
                                            Text = i.name,
                                            Value = i.id.ToString()
                                        }).ToList();
            ViewBag.books = book;
            return View();
        }
        [HttpPost]
        public ActionResult LendBook(tbl_action p)
        {
            db.tbl_action.Add(p);
            db.SaveChanges();
            return RedirectToAction("LendBook");
        }
        public ActionResult GetBackBook(int id)
        {
            var book = db.tbl_action.Find(id);
            return View("GetBackBook", book);
        }

        [HttpPost]
        public ActionResult UpdateLend(tbl_action p) 
        {
            var act = db.tbl_action.Find(p.id);
            act.bring_time = p.bring_time;
            act.action_status = true;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}