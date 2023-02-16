using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UploadFiles()
        {
            return View("UploadFiles");
        }
        [HttpPost]
        public ActionResult UploadFiles(HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    if (file != null)
                    {
                        string path = Path.Combine(Server.MapPath("~/UploadedFiles"), Path.GetFileName(file.FileName));
                        file.SaveAs(path);

                    }
                    ViewBag.FileStatus = "File uploaded successfully.";
                }
                catch (Exception)
                {

                    ViewBag.FileStatus = "Error while file uploading.";
                }

            }
            return View("UploadFiles");
        }
    }
}