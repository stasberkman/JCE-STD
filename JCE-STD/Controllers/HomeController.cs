/*
 * to this controller we redirect each pach that we are entering in JCE-STD
 * includes all the views of the student that are entering to site
 */

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
        public ActionResult Help()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult moti()
        {
            return View();
        }
        public ActionResult stas()
        {
            return View();
        }
        public ActionResult oren()
        {
            return View();
        }
        public ActionResult ariel()
        {
            return View();
        }

    }
}
