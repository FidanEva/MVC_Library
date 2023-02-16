using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;
namespace MVC_Library.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        [HttpGet]
        public ActionResult Index()
        {
            var columns = db.tbl_employers.ToList();
            return View(columns);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(tbl_employers p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEmployee");
            }
            db.tbl_employers.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult DelEmployee(int id)
        {
            var employee = db.tbl_employers.Find(id);
            db.tbl_employers.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult BringEmployee(int id) //id ye gore datani getirirsen
        {
            var ctg = db.tbl_employers.Find(id);
            return View("BringEmployee", ctg);
        }

        [HttpPost]
        public ActionResult UpdateEmployee(tbl_employers p) //datani bura post eliyirsen formdan
        {
            var ctg = db.tbl_employers.Find(p.id);
            ctg.employee = p.employee;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}