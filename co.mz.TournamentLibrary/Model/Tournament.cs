using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentLibrary.Model
{
    public class Tournament
    {
        /// <summary>
        /// Unique identifier for a prize into dataBase 
        /// </summary>
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Identifier of teh tournament.
        /// </summary>
        private string name;

        /// <summary>
        /// Set or Get name of the tournament.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Entery fee for the tournament.
        /// </summary>
        private decimal entryFee;

        /// <summary>
        /// Set or Get of the tournament.
        /// </summary>
        public decimal EntryFee
        {
            get { return entryFee; }
            set { entryFee = value; }
        }

        /// <summary>
        /// List of teams in the tournament.
        /// </summary>
        private List<Team> teams = new List<Team>();

        /// <summary>
        /// Set or Get teams in the tournament.
        /// </summary>
        public List<Team> Teams
        {
            get { return teams;}
            set { teams = value; }
        }

        /// <summary>
        /// Prizes for the winners of the Tournament. 
        /// </summary>
        private List<Prize> prizes = new List<Prize>();

        /// <summary>
        /// Set or get the tournament prizes.
        /// </summary>
        public List<Prize> Prizes
        {
            get { return prizes; }
            set { prizes = value; }
        }

        /// <summary>
        /// List of rounds that consist of list of list of MatchUp entries.
        /// </summary>
        private List<List<MatchUp>> round = new List<List<MatchUp>>();

        /// <summary>
        /// Set or Get the tournament rounds. 
        /// </summary>
        public List<List<MatchUp>> Rounds
        {
            get { return round; }
            set { round = value; }
        }
    }
}
