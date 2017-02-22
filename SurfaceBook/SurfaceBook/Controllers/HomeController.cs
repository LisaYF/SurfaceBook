﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurfaceBook.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult Manage()
        {
            ViewBag.Message = "Your manage page.";

            return View();
        }
        [Authorize]
        public ActionResult HelpMe()
        {
            ViewBag.Message = "Your feedback here.";

            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Message = "Our description page.";

            return View();
        }

        public ActionResult ContactUs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Thanks()
        {
            ViewBag.Message = "Thanks page.";

            return View();
        }
    }
}
