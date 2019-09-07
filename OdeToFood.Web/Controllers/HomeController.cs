using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    // HomeController = 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Views->Home->Index.cshtml.
            // We return a view because it is difficult to write HTML.
            // inside of a String literal.
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}