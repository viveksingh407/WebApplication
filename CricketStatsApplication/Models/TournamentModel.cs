using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CricketDataEngine.Models;
using CricketDataEngine.Data;

namespace CricketStatsApplication.Models
{
    public class TournamentModel
    {
        public Tournament Tournament { get; set; }
        public IList<Match> Matches { get; set; }

        public void GetTournamentData()
        {
            TournamentFactory data = new TournamentFactory();

            this.Tournament = data.GetTournamentDetails();
            this.Matches = data.GetAllTournamentMatches(this.Tournament.Teams, this.Tournament.StartDate);
        }
    }
}