using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;
using PagedList;
using PagedList.Mvc;
namespace MVC_Library.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        public ActionResult Index(int page = 1)
        {
            var values = db.tbl_users.ToList().ToPagedList(page, 3);
            return View(values);
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(tbl_users p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddUser");
            }
            db.tbl_users.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DelUser(int id)
        {
            var user = db.tbl_users.Find(id);
            db.tbl_users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult BringUser(int id) //id ye gore datani getirirsen
        {
            var user = db.tbl_users.Find(id);
            return View("BringUser", user);
        }

        [HttpPost]
        public ActionResult UpdateUser(tbl_users p) //datani bura post eliyirsen formdan
        {
            var user = db.tbl_users.Find(p.id);
            user.name = p.name;
            user.surname = p.surname;
            user.email = p.email;
            user.password = p.password;
            user.user_name = p.user_name;
            user.phone_number = p.phone_number;
            user.prof_photo = p.prof_photo;
            user.university = p.university;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}