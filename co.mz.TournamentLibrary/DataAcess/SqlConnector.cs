using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using co.mz.TournamentLibrary.Model;
using Dapper;
using co.mz.TournamentLibrary.Utilities;

namespace co.mz.TournamentLibrary.DataAcess
{

    public class SqlConnector : IDataConnection
    {
        private const string dataBaseName = "Tournaments"; 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Person CreatePerson(Person person)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(dataBaseName)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@FirstName", person.FirstName);
                parameters.Add("@LastName", person.LastName);
                parameters.Add("@EmailAdress", person.Email);
                parameters.Add("@PhoneNumber", person.CellPhoneNumber);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeopleInsert", parameters, commandType: CommandType.StoredProcedure);

                person.Id = parameters.Get<int>("@Id");

                return person;
            }
        }

        /// <summary> 
        /// Save a prize into dataBase
        /// </summary>
        /// <param name="prize">Prize information to save</param>
        /// <returns>Saved prize information</returns>
        public Prize CreatePrize(Prize prize)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(dataBaseName)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@PlaceNumber", prize.PlaceNumber);
                parameters.Add("@PlaceName", prize.PlaceName);
                parameters.Add("@PrizeAmount", prize.Amount);
                parameters.Add("@PrizePercentage", prize.Percentage);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizesInsert", parameters, commandType: CommandType.StoredProcedure);

                prize.Id = parameters.Get<int>("@Id");

                return prize;
            }
        }

        /// <summary>
        /// Create team into database and create relationship between its members (People). 
        /// </summary>
        /// <param name="team">Team contents to be inserted into dataBase.</param>
        /// <returns>Team content previously created including its Id (unique identifier).</returns>
        public Team CreateTeam(Team team)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(dataBaseName)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@TeamName", team.Name);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeamsInsert", parameters, commandType: CommandType.StoredProcedure);

                team.Id = parameters.Get<int>("@Id");

                //Create relationship between team and its member (People).
                foreach (var person in team.Members)
                {
                    //Overide the parameters
                    parameters = new DynamicParameters();
                    parameters.Add("@TeamId", team.Id);
                    parameters.Add("@PersonId", person.Id);
                    parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTeamMembersInsert", parameters, commandType: CommandType.StoredProcedure);
                }

                return team;
            }
        }

        public Tournament CreateTournament(Tournament tournament)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(dataBaseName)))
            {
                SaveTournament(connection, tournament);

                SaveTournamentTeams(connection, tournament);

                SaveTournamentPrizes(connection, tournament);

                SaveTournamentRounds(connection, tournament);
            }

            return tournament;
        }

        private void SaveTournamentRounds(IDbConnection connection, Tournament tournament)
        {
            //Loop through the rounds
            //Loop through the matchup
            //Save the matchup
            //Loop through the the entries and save; 

            foreach (var round in tournament.Rounds)
            {
                foreach (var matchup in round)
                {
                    var parameters = new DynamicParameters();

                    parameters.Add("@TournamentId", tournament.Id);
                    parameters.Add("@MachupRound ", matchup.Round);
                    parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spMatchupsInsert", parameters, commandType: CommandType.StoredProcedure);

                    matchup.Id = parameters.Get<int>("@Id");

                    foreach (var entry in matchup.Entries)
                    {
                        parameters = new DynamicParameters();

                        parameters.Add("@MatchupId", matchup.Id);

                        if(entry.Parent == null)
                        { 
                            parameters.Add("@ParentId ", null);
                        }
                        else
                        {
                            parameters.Add("@ParentId ", entry.Parent.Id);
                        }

                        if(entry.TeamCompeting == null)
                        { 
                            parameters.Add("@TeamCompetingId ", null);
                        }
                        else
                        {
                            parameters.Add("@TeamCompetingId ", entry.TeamCompeting.Id);
                        }

                        parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntriesInsert", parameters, commandType: CommandType.StoredProcedure);

                        entry.Id = parameters.Get<int>("@Id");
                    }
                }
            }
        }

        private void SaveTournament(IDbConnection connection, Tournament tournament)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@Name", tournament.Name);
            parameters.Add("@EntryFee ", tournament.EntryFee);
            parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("dbo.spTournamentsInsert", parameters, commandType: CommandType.StoredProcedure);

            tournament.Id = parameters.Get<int>("@Id");
        }

        private void SaveTournamentTeams(IDbConnection connection, Tournament tournament)
        {
            //Create relationship between tournament and its teams (players).
            foreach (var team in tournament.Teams)
            {
                var parameters = new DynamicParameters();

                parameters.Add("@TournamentId", tournament.Id);
                parameters.Add("@TeamId", team.Id);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentsEntriesInsert", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentPrizes(IDbConnection connection, Tournament tournament)
        {
            //Create relationship between tournament and its Prizes.
            foreach (var prize in tournament.Prizes)
            {
                var parameters = new DynamicParameters();

                parameters.Add("@TournamentId", tournament.Id);
                parameters.Add("@PrizeId", prize.Id);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizesInsert", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Get all People in the SQL dataBase
        /// </summary>
        /// <returns></returns>
        public List<Person> GetAllpeople()
        {
            var output = new List<Person>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(dataBaseName)))
            {
                output = connection.Query<Person>("dbo.spPeopleGetAll").ToList();
            }

            return output;
        }

        /// <summary>
        /// Get all teams including its members
        /// </summary>
        /// <returns></returns>
        public List<Team> GetAllTeam()
        {
            var output = new List<Team>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(dataBaseName)))
            {
                output = connection.Query<Team>("dbo.spTeamsGetAll").ToList();

                foreach (var team in output)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@TeamId", team.Id);

                    team.Members = connection.Query<Person>("dbo.spTeamMembersGetByTeamID", parameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }
    }
}
