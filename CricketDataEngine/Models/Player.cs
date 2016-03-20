using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketDataEngine.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }

        public Player GetTempPlayerData(int playerId, string playerName)
        {
            return new Player()
            {
                PlayerId = playerId,
                PlayerName = playerName
            };
        }
    }
}
