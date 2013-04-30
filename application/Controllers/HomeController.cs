using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace application.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Hello,this is my first web application!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
