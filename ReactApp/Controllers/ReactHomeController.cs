﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactApp.Controllers
{
    public class ReactHomeController : Controller
    {
        // GET: ReactHome
        public ActionResult Index()
        {
            return View();
        }
    }
}