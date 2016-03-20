using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CricketStatsApplication.Models;

namespace CricketStatsApplication.Controllers
{
    public class TournamentController : Controller
    {
        // GET: Tournament
        public ActionResult Index()
        {
            var tournament = new TournamentModel();

            tournament.GetTournamentData();

            return View();
        }
    }
}