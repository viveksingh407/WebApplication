using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricketDataEngine.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
using System.Configuration;

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

            MongoClient client = new MongoClient(new MongoClientSettings() { Server = new MongoServerAddress("localhost", 27017) });

            IMongoDatabase db = client.GetDatabase("CricketLeagueConnection");

            //BsonClassMap.RegisterClassMap<Tournament>(cm =>
            //{
            //    cm.AutoMap();
            //    cm.MapProperty(p => p.Age);
            //});

            var tournamentData = db.GetCollection<Tournament>("Tournament");

            return tournamentMatch.GetMatchDetails(teams, tournamentStartDate);
        }
    }
}
