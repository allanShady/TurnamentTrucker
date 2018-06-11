using co.mz.TournamentLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentBusinessRules
{
    public static class TournamentLogic
    {
        public static void CreateRounds(this Tournament tournament)
        {
            var randomizedTeams = RandomizedTeamsOrder(tournament.Teams);

            int rounds = FindNumberOfRounds(tournament.Teams.Count);

            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            tournament.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            CreateOtherRound(tournament, rounds);
        }

        private static void CreateOtherRound(Tournament tournament, int rounds)
        {
            int round = 2;
            var previousRound = tournament.Rounds[0];
            var currentRound = new List<MatchUp>();
            var currentMatchup = new MatchUp();

            while(round <= rounds)
            {
                foreach (var matchup in previousRound)
                {
                    currentMatchup.Entries.Add(new MatchUpEntry { Parent = matchup });

                    if(currentMatchup.Entries.Count > 1)
                    {
                        currentMatchup.Round = round;
                        currentRound.Add(currentMatchup);
                        currentMatchup = new MatchUp();
                    }
                }

                tournament.Rounds.Add(currentRound);
                previousRound = currentRound;

                currentRound = new List<MatchUp>();
                round += 1;
            }
        }

        private static List<MatchUp> CreateFirstRound(int byes, List<Team> teams)
        {
            var matchups = new List<MatchUp>();
            var currentMacthup = new MatchUp();

            foreach (var team in teams)
            {
                currentMacthup.Entries.Add(new MatchUpEntry { TeamCompeting = team });

                if(byes > 0 || currentMacthup.Entries.Count > 1)
                {
                    currentMacthup.Round = 1;
                    matchups.Add(currentMacthup);
                    currentMacthup = new MatchUp();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }

            return matchups;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }

        private static int FindNumberOfRounds( int teamsCount )
        {
            int output = 1;
            int auxValRounds = 2;

            while(auxValRounds < teamsCount)
            {
                output += 1;

                auxValRounds *= 2;
            }

            return output;
        }

        private static List<Team> RandomizedTeamsOrder(List<Team> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
