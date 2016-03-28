using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using CricketStatsApplication.Models;
using CricketDataEngine.Models;
using Newtonsoft.Json;

namespace CricketStatsApplication.Controllers
{
    public class TournamentServiceController : ApiController
    {
        // GET: Tournament
        public HttpResponseMessage Get()
        {
            var model = new TournamentModel();

            model.GetTournamentData();

            var teams = model.Tournament.Teams.Select(team => new { TeamId = team.TeamId, TeamName = team.TeamName });

            var jsonData = JsonConvert.SerializeObject(teams);

            HttpResponseMessage response = Request.CreateResponse<string>(System.Net.HttpStatusCode.Created, jsonData);

            return response;
        }
    }
}