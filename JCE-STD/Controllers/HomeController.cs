using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JCE_STD.Controllers
{
    public class HomeController : Controller
    {
        //HOME/INDEX
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to JCE-STD!";

            return View();
        }
        //HOME/ABOUT
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}
