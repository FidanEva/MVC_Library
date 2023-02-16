using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;
namespace MVC_Library.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Weather()
        {
            return View();
        }
        public ActionResult WeatherWidgets()
        {
            return View();
        }
    }
}