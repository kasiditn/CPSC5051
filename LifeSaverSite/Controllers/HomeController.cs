using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your About Page.";

            return View();
        }

        public ActionResult Contact()
        {
            /*ViewBag.Message = "Your Contact Page.";*/

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your Login Page.";

            return View();
        }
        public ActionResult Compare()
        {
            ViewBag.Message = "Your Compare page.";

            return View();
        }
        public ActionResult SiteMap()
        {
            ViewBag.Message = "Your SiteMap page.";

            return View();
        }
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your Dashboard page.";

            return View();
        }
        public ActionResult Report()
        {
            ViewBag.Message = "Your Report page.";

            return View();
        }
        public ActionResult Image()
        {
            ViewBag.Message = "Your Image page.";

            return View();
        }

        public ActionResult Inventory()
        {
            ViewBag.Message = "You are on Inventory page";

            return View();
        }

    }
}