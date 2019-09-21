using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        // MVC Request will look around to see if it can find anything w/ name
        // It will look in the query string

        // Web API is used to: 
        // Consume JSON or XML
        // Produce JSON or XML
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();

            model.Name = name ?? "no name";            
            model.Message = ConfigurationManager.AppSettings["message"];

            return View(model);
        }
    }
}