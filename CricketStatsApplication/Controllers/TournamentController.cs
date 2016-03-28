using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CricketStatsApplication.Models;
using CricketDataEngine.Models;

namespace CricketStatsApplication.Controllers
{
    public class TournamentController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}