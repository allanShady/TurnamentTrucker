using co.mz.TournamentLibrary.DataAcess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentLibrary.Utilities
{
    public static class GlobalConfig
    {
        public const string Prizefile = "Prizes.csv";
        public const string PeopleFile = "People.csv";
        public const string TeamFile = "Teams.csv";
        public const string TournamentFile = "Tournaments.csv";
        public const string MatchupFile = "MatchupFile.csv";
        public const string MatchupEntryFile = "MatchupEntryFile.csv";

        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Initilize witch data connection will be used. 
        /// </summary>
        /// <param name="db">Type of connection prefered as program Enums</param>
        public static void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.SQL)
            {
                Connection = new SqlConnector();
            }
            else if (db == DatabaseType.TextFile)
            {
                Connection = new TextConnector();
            }
        }

        /// <summary>
        /// Get a connection string in App.conf in the current application scope.
        /// </summary>
        /// <param name="name">Connection sting name in App.config</param>
        /// <returns></returns>
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
