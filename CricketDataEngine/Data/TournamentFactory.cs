using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricketDataEngine.Models;

namespace CricketDataEngine.Data
{
    public class TournamentFactory
    {
        public Tournament GetTournamentDetails()
        {
            var tournament = new Tournament();

            var tournamentId = 1;
            var tournamentName = "T20BigBash";
            var startDate = new DateTime(2016, 4, 15);
            var endDate = startDate.AddDays(15);

            return tournament.GetTempTournamentData(tournamentId, tournamentName, startDate, endDate);
        }

        public IList<Match> GetAllTournamentMatches(IList<Team> teams, DateTime tournamentStartDate)
        {
            var tournamentMatch = new Match();

            return tournamentMatch.GetMatchDetails(teams, tournamentStartDate);
        }
    }
}
