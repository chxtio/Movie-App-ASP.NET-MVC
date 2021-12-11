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
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // GET: /HellowWorld/Welcome/
        public string Welcome(String name, int ID = 1)
        {
            return HttpUtility.HtmlEncode($"Hello {name}, ID: {ID}");
        }


        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}