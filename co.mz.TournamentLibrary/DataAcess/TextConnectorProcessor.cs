using co.mz.TournamentLibrary.Model;
using co.mz.TournamentLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentLibrary.DataAcess.Helper
{
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// Get full file path to modified or just read.
        /// </summary>
        /// <param name="fileName">The name of the file</param>
        /// <returns>The full file path name as a string.</returns>
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";
        }

        /// <summary>
        /// Load the contents of the file. 
        /// </summary>
        /// <param name="file">File to load the contents.</param>
        /// <returns>contents as list of string.</returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<Person> ConvertToPeople(this List<string> lines)
        {
            var output = new List<Person>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                var _person = new Person
                {
                    Id = int.Parse(cols[0]),
                    FirstName = cols[1],
                    LastName = cols[2],
                    Email = cols[3],
                    CellPhoneNumber = cols[4]
                };

                output.Add(_person);
            }

            return output;
        }

        public static List<Tournament> ConvertToTournaments(this List<string> lines, string prizefile, string teamfile, string peopleFile)
        {
            //Model ___ Id, Name,Fee, (id|id|id - Teams), (id|id|id| Prizes), (id^id^id|id^id^id|id^id^id - Rounds)
            var output = new List<Tournament>();
            var teams = teamfile.FullFilePath().LoadFile().ConvertToTeam(peopleFile);
            var prizes = prizefile.FullFilePath().LoadFile().ConvertToPrize();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                var tournament = new Tournament
                {
                    Id = int.Parse(cols[0]),
                    Name = cols[1],
                    EntryFee = decimal.Parse(cols[2])
                };

                string[] teamIds = cols[3].Split('|');

                foreach (var id in teamIds)
                {
                    tournament.Teams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                //Prizes
                string[] prizeIds = cols[4].Split('|');

                foreach (var id in prizeIds)
                {
                    tournament.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(tournament);

                //TODO - Rounds matchups in text file
            }

            return output;
        }

        public static void SaveRoundsToFile(this Tournament tournament, string matchupFile, string matchupEntryFile)
        {
            //Loop through each round
            //Loop trrough each MatchUp
            //Get the id for the new matchup and record
            //Loop through each entry get the id and save id

            foreach (var round in tournament.Rounds)
            {
                foreach (var matchup in round)
                {
                    //Load all the matchup
                    //Get the top id and add one
                    //Save the matchup Id
                    //Save the matchup record
                    matchup.SaveMatchupToFile(matchupFile, matchupEntryFile);
                }
            }
        }

        private static void SaveMatchupToFile(this MatchUp matchUp, string matchupFile, string mactupEntryFile)
        {
            var matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchup();
            int currentId = 1;

            if(matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchUp.Id = currentId;

            foreach (var entry in matchUp.Entries)
            {
                entry.SaveMatchupEntryToFile(mactupEntryFile);
            }

            var lines = new List<string>();

            foreach (var _matchup in matchups)
            {
                lines.Add($"{ _matchup.Id },{ ConvertMatchupEntriesListToString(_matchup.Entries) },{ _matchup.Winner.Id },{ _matchup.Round }");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        private static void ConvertMatchupEntriesListToString(List<MatchUpEntry> matchUpEntries)
        {

        }

        private static void SaveMatchupEntryToFile(this MatchUpEntry matchUpEntry, string mactupEntryFile)
        {
            var matchupEntries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntries();
            int currentId = 1;

            if(matchupEntries.Count > 0)
            {
                currentId = matchupEntries.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchUpEntry.Id = currentId;
            matchupEntries.Add(matchUpEntry);

            var lines = new List<string>();

            foreach (var _matchupEntry in matchupEntries)
            {
                lines.Add($"{ _matchupEntry.Id },{ _matchupEntry.TeamCompeting.Id },{ _matchupEntry.Score },{ _matchupEntry.Parent.Id }");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static List<MatchUp> ConvertToMatchup(this List<string> lines)
        {
            var output = new List<MatchUp>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                var _person = new MatchUp
                {
                    Id = int.Parse(cols[0]),
                    Entries = ConvertToStringMatchupEntries(cols[1]),
                    Winner= LookupTeamById(int.Parse(cols[2])),
                    Round = int.Parse(cols[3]),
                };

                output.Add(_person);
            }

            return output;
        }
        
        private static Team LookupTeamById(int id)
        {
            var teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeam(GlobalConfig.PeopleFile);

            return teams.Where(x => x.Id == id).FirstOrDefault();
        }

        private static MatchUp LookupMacthupEntryById(int id)
        {
            var matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchup();

            return matchups.Where(x => x.Id == id).First();
        }

        private static List<MatchUpEntry> ConvertToMatchupEntries(this List<string> lines)
        {
            var outputMatchupEntries = new List<MatchUpEntry>();

            foreach (var line in lines)
            {
                string[] cols = line.Split('|');
                var matchupEntry = new MatchUpEntry
                {
                    Id = int.Parse(cols[0]),
                    TeamCompeting = LookupTeamById(int.Parse(cols[1])),
                    Score = double.Parse(cols[2])
                };

                if (int.TryParse(cols[3], out int parentID))
                { 
                    matchupEntry.Parent = LookupMacthupEntryById(int.Parse(cols[3]));
                }
                else
                {
                    matchupEntry.Parent = null;
                }

                outputMatchupEntries.Add(matchupEntry);
            }

            return outputMatchupEntries;
        }


        private static List<MatchUpEntry> ConvertToStringMatchupEntries(string matchupIds)
        {
            var ids = matchupIds.Split('|');
            var outputMatchupEntry = new List<MatchUpEntry>();
            var matchupEntries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntries();  

            foreach (var id in ids)
            {
                outputMatchupEntry.Add(matchupEntries.Where(x => x.Id == int.Parse(id)).First());
            }

            return outputMatchupEntry;
        }

        public static void SavePeople(this List<Person> people, string fileName)
        {
            var lines = new List<string>();

            foreach (var person in people)
            {
                lines.Add($"{ person.Id },{ person.FirstName },{ person.LastName },{ person.Email },{ person.CellPhoneNumber }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveTournaments(this List<Tournament> tournaments, string tournamentFile)
        {
            var lines = new List<string>();

            foreach (var tournament in tournaments)
            {
                lines.Add($@"{ tournament.Id },
                             { tournament.Name },
                             { tournament.EntryFee },
                             { tournament.Teams.ConvertTeamListToString() },
                             { tournament.Prizes.ConvertPrizeListToString() },
                             { tournament.Rounds.ConvertRoundListToString() }");
            }

            File.WriteAllLines(tournamentFile.FullFilePath(), lines);
        }

        private static string ConvertRoundListToString(this List<List<MatchUp>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
                return output;

            foreach (var round in rounds)
            {
                output += $"{ round.ConvertMatchupListToString() }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(this List<MatchUp> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
                return output;

            foreach (var matchup in matchups)
            {
                output += $"{ matchup.Id }^";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }


        private static string ConvertTeamListToString(this List<Team> teams)
        {
            string output = "";

            if (teams.Count == 0)
                return output;

            foreach (var team in teams)
            {
                output += $"{ team.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrizeListToString(this List<Prize> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
                return output;

            foreach (var prize in prizes)
            {
                output += $"{ prize.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        /// <summary>
        /// Convert the list of prizes as string to list of Prizes objects.
        /// </summary>
        /// <param name="lines">Prizes contents.</param>
        /// <returns>Prizes contents turned to a list of Prize object.</returns>
        public static List<Prize> ConvertToPrize(this List<string> lines)
        {
            var output = new List<Prize>();

            foreach (var line in lines)
            {
                string[] columns = line.Split(',');

                var _price = new Prize
                {
                    Id = int.Parse(columns[0]),
                    PlaceNumber = int.Parse(columns[1]),
                    PlaceName = columns[2],
                    Amount = decimal.Parse(columns[3]),
                    Percentage = double.Parse(columns[4])
                };

                output.Add(_price);
            }

            return output;
        }

        /// <summary>
        /// Save Prizes into the specified file
        /// </summary>
        /// <param name="prizes">List of Prize objects contains the prize contents.</param>
        /// <param name="fileName">File name to modify.</param>
        public static void SavePrizes(this List<Prize> prizes, string fileName)
        {
            var lines = new List<string>();

            foreach (var prize in prizes)
            {
                lines.Add($"{ prize.Id },{ prize.PlaceNumber },{ prize.PlaceName },{ prize.Amount },{ prize.Percentage }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<Team> ConvertToTeam(this List<string> lines, string peopleFileName)
        {
            var output = new List<Team>();
            var people = peopleFileName.FullFilePath().LoadFile().ConvertToPeople();
            //Id, teamName, var of pesons as (4|8|3)
            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                Team team = new Team
                {
                    Id = int.Parse(cols[0]),
                    Name = cols[1]
                };

                string[] peopleIds = cols[2].Split('|');

                foreach (var personId in peopleIds)
                {
                    team.Members.Add(people.Where(x => x.Id == int.Parse(personId)).FirstOrDefault());
                }

                output.Add(team);
            }

            return output;
        }

        public static void SaveTeams(this List<Team> teams, string teamFileName)
        {
            var lines = new List<string>();

            foreach (var team in teams)
            {
                lines.Add($"{ team.Id },{ team.Name }, { team.Members.ConvertPeopleListToString() }");
            }

            File.WriteAllLines(teamFileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(this List<Person> people)
        {
            string output = "";

            if (people.Count == 0)
                return output;

            foreach (var person in people)
            {
                output += $"{ person.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
