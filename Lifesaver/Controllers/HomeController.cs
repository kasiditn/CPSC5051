﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lifesaver.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DashBoard()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult map()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LoginPage()
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