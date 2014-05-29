using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Mvc3Application11.Models;

namespace Mvc3Application11.Controllers
{
    public class DocController : Controller
    {
        //
        // GET: /Doc/

        public ActionResult Index()
        {
            //http://odetocode.com/blogs/scott/archive/2013/01/08/why-use-the-bootstrap-grid.aspx
            return Redirect(Url.Content("~/Content/Html/bootstraplayout.htm"));
        }

        public ContentResult Document()
        {

            return Content("Hello World!");
        }

        public DateTime MyDateTime()
        {
            return DateTime.Now;
        }

        //<link href="@Url.Action("CssStyle", "Doc")" rel="stylesheet" type="text/css" />
        public ActionResult CssStyle()
        {
            string style = "something here"; //GetStyleFromDB(clientID);
            if (!String.IsNullOrWhiteSpace(style))
                return Content(style, "text/css");
            return View();
        }

        public ContentResult ReadHamlet()
        {
            string fileName = Server.MapPath(@"~\Content\Hamlet.xml");
            TextReader tr = new StreamReader(fileName);
            string contents = tr.ReadToEnd();
            return Content(contents, "text/xml");
        }

        public ActionResult RazorView(Product product)
        {
            //List<Product> plist = new List<Product>() {
            //    new Product{Category="A", Name="Coca", ProductID=1111, UnitPrice=10, UnitsInStock=1},
            //    new Product{Category="B", Name="Beer", ProductID=1122, UnitPrice=20, UnitsInStock=1},
            //    new Product{Category="C", Name="Wine", ProductID=1234, UnitPrice=55, UnitsInStock=1}
            //};

            var pclist = new[] {
                new Product{Category="A", Name="Coca", ProductID=1111, UnitPrice=10, UnitsInStock=1},
                new Product{Category="B", Name="Beer", ProductID=1122, UnitPrice=20, UnitsInStock=1},
                new Product{Category="C", Name="Wine", ProductID=1234, UnitPrice=55, UnitsInStock=1},
                new Product{Category="D", Name="Vodaca", ProductID=2288, UnitPrice=265, UnitsInStock=1}
            };

            //return View(plist);
            return View(pclist.ToList<Product>());
        }

        public ActionResult Html5Demo()
        {
            return View();
        }


    }

    
}
