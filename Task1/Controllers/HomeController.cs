﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Personal()
        {
            return View();
        }
        public ActionResult Reference()
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
    }
}