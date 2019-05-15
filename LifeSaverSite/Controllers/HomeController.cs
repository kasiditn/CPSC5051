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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
        public ActionResult Compare()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
        public ActionResult SiteMap()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
    }
}