using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3Application11.Models;

namespace Mvc3Application11.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Canvas()
        {
            return View();
        }

        public ActionResult Variety()
        {
            return View();
        }

        public ActionResult jQueryDemo()
        {
            return View();
        }

        [HttpPost]
        public string Upload(string dataUrl)
        {
            var image = new ImageDataUrl(dataUrl);
            var fileName = image.SaveTo(Server.MapPath("~/Content/uploads"));
            var url = Url.Content("~/Content/uploads/" + fileName);
            return url;
        }

        public ActionResult FontFace()
        {
            return View();
        }

        public ActionResult Browsers()
        {
            return View();
        }
    }
}
