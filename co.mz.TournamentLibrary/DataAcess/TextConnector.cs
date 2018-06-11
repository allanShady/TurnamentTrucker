using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using co.mz.TournamentLibrary.Model;
using co.mz.TournamentLibrary.DataAcess.Helper;
using co.mz.TournamentLibrary.Utilities;

namespace co.mz.TournamentLibrary.DataAcess
{
    public class TextConnector : IDataConnection
    {
        private const string Prizefile = "Prizes.csv";
        private const string PeopleFile = "People.csv";
        private const string TeamFile = "Teams.csv";
        private const string TournamentFile = "Tournaments.csv";
        private const string MatchupFile = "MatchupFile.csv";
        private const string MatchupEntryFile = "MatchupEntryFile.csv";

        public Person CreatePerson(Person person)
        {
            var people = PeopleFile.FullFilePath().LoadFile().ConvertToPeople();

            int nextId = 1;

            if (people.Count > 0)
            {
                nextId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            person.Id = nextId;
            people.Add(person);

            people.SavePeople(PeopleFile);

            return person;
        }

        /// <summary>
        /// Save a prize into dataBase
        /// </summary>
        /// <param name="prize">Prize information to save</param>
        /// <returns>Saved prize information</returns>
        public Prize CreatePrize(Prize prize)
        {
            //Load the test file and convert to the list of Prizes
            var prizes = Prizefile.FullFilePath().LoadFile().ConvertToPrize();

            //Initialize the nextId for the fist line in text file
            int nextId = 1;

            //Calculate the next Id if the test file has records.
            if (prizes.Count > 0)
            { 
                nextId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            //Add new record with the next Id
            prize.Id = nextId;
            prizes.Add(prize);

            //Convert the Prizes to List of string and Save the list to the Prize CSV file.
            prizes.SavePrizes(Prizefile);

            return prize;
        }

        public Team CreateTeam(Team team)
        {
            //TODO -- Make create team real create a team and 
            // read the file
            var teams = TeamFile.FullFilePath().LoadFile().ConvertToTeam(PeopleFile);

            //Initialize the nextId for the fist line in text file
            int nextId = 1;

            //Calculate the next Id if the test file has records.
            if (teams.Count > 0)
            {
                nextId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            //Add new record with the next Id
            team.Id = nextId;
            teams.Add(team);

            //Convert the Prizes to List of string and Save the list to the Prize CSV file.
            teams.SaveTeams(TeamFile);

            return team;
        }


        public Tournament CreateTournament(Tournament tournament)
        {
            var tournaments = TournamentFile.FullFilePath().LoadFile().ConvertToTournaments(Prizefile, TeamFile, PeopleFile);

            //Initialize the nextId for the fist line in text file
            int nextId = 1;

            //Calculate the next Id if the test file has records.
            if (tournaments.Count > 0)
            {
                nextId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            //Add new record with the next Id
            tournament.Id = nextId;
            tournaments.Add(tournament);

            tournament.SaveRoundsToFile(GlobalConfig.MatchupFile, GlobalConfig.MatchupEntryFile);

            //Convert the Prizes to List of string and Save the list to the Prize CSV file.
            tournaments.SaveTournaments(TournamentFile);

            return tournament;
        }

        public List<Person> GetAllpeople()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPeople();
        }

        public List<Team> GetAllTeam()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeam(PeopleFile.FullFilePath());
        }
    }
}
