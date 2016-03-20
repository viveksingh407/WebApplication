using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketDataEngine.Models
{
    public enum KnockoutGamesType
    {
        QuarterFinal,
        SemiFinal,
        Final
    }
    public enum MatchStateType
    {
        Qualifying,
        League,
        Knockout
    }

    public enum ResultStateType {
        Yes,
        NoResult,
        Tie,
        Abandoned,
        NotPlayed
    }

    public class Match
    {
        public IList<Team> MatchTeams { get; set; }
        public DateTime MatchDate { get; set; }
        public ResultStateType MatchResultType { get; set; }
        public Team WinningTeam { get; set; }
        public Team LosingTeam { get; set; }

        public IList<Match> GetMatchDetails(IList<Team> teams, DateTime tournamentStartDate)
        {
            var matches = new List<Match>() as IList<Match>;

            foreach(var firstTeam in teams)
            {
                foreach(var secondTeam in teams)
                {
                    if (firstTeam.TeamId != secondTeam.TeamId)
                    {
                        matches.Add(new Match()
                        {
                            MatchTeams = new List<Team>() { firstTeam, secondTeam } as IList<Team>,
                            MatchDate = tournamentStartDate,
                            MatchResultType = ResultStateType.NotPlayed,
                            WinningTeam = null,
                            LosingTeam = null
                        });
                    }
                }
            }

            return matches;
        }
    }
}
