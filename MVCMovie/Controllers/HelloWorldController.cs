using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /HellowWorld/Welcome/
        public ActionResult Welcome(String name, int numTimes = 1)
        {
            //return HttpUtility.HtmlEncode($"Hello {name}, ID: {ID}");
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}