using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketDataEngine.Models
{
    public class Team
    {
        private int _teamSize = 11;

        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public IList<Match> Matches { get; set; }
        public IList<Player> Players { get; set; }


        public Team GetTempTeamData(int teamId, string teamName)
        {
            var team = new Team()
            {
                TeamId = teamId,
                TeamName = teamName,
                Players = new List<Player>() as IList<Player>
            };

            Player player = null;

            for (var count = 1; count <= _teamSize; count++)
            {
                var playerName = team.TeamName + "Player" + count;
                player = new Player();
                player = GetPlayerData(count, playerName);

                team.Players.Add(player);
            }

            return team;
        }

        private Player GetPlayerData(int playerId, string playerName)
        {
            var player = new Player();
           return player.GetTempPlayerData(playerId, playerName);
        }
    }
}
