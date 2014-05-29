using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc3Application11.Controllers
{
    //http://pluralsight.com/training/Courses/TableOfContents/native-mobile-apps-with-html5
    //Building Hybrid Mobile Application Web Apps by Jon Flanders
    //Responsive Web Apps ==> Media Queries ==> 640x480 to 2560x1440
    public class CSS3Controller : Controller
    {
        //
        // GET: /CSS3/
        //http://localhost:56787/CSS3/ResponsiveDesign
        public ActionResult ResponsiveDesign()
        {
            return View();
        }

    }
}
