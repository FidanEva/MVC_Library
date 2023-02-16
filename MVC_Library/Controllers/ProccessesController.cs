using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;
namespace MVC_Library.Controllers
{
    public class ProccessesController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        // GET: Proccesses
        public ActionResult Index()
        {
            var values = db.tbl_action.Where(k => k.action_status == true).ToList();
            return View(values);
        }
    }
}