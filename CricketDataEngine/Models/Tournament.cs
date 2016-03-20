using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketDataEngine.Models
{
    public class Tournament
    {
        private static int _totalTeams = 8;
        private static int _totalGames = (_totalTeams * (_totalTeams - 1)) + 4 + 2 + 1;

        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public IList<Match> Matches { get; set; }
        public IList<Team> Teams { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalGames { get; set; }
        public int AvailableGameDays { get; set; }

        public Tournament GetTempTournamentData(int tournamentId, string tournamentName, DateTime startDate, DateTime endDate)
        {
            var tournament = new Tournament()
            {
                TournamentId = tournamentId,
                TournamentName = tournamentName,
                StartDate = startDate,
                EndDate = endDate,
                TotalGames = _totalGames,
                AvailableGameDays = tournamentId,
                Teams = new List<Team>() as IList<Team>
            };

            Team team = null;

            for (var count = 1; count <= _totalTeams; count++)
            {
                var teamName = "Team" + count;
                team = new Team();
                team = GetTeamData(count, teamName);

                tournament.Teams.Add(team);
            }

            return tournament;
        }

        private Team GetTeamData(int teamId, string teamName)
        {
            var team = new Team();
            return team.GetTempTeamData(teamId, teamName);
        }
    }
}
