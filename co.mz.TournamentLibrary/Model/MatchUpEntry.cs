using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentLibrary.Model
{
    public class MatchUpEntry
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
        /// Determine a team competing from the MatchUp entry.
        /// </summary>
        private Team teamCompeting;

        /// <summary>
        /// Set or Get the competing team.
        /// </summary>
        public Team TeamCompeting
        {
            get { return teamCompeting; }
            set { teamCompeting = value; }
        }

        /// <summary>
        /// Score of the team competing.
        /// </summary>
        private double score;

        /// <summary>
        /// Set or Get score of the team competing.
        /// </summary>
        public double Score
        {
            get { return score; }
            set { score = value; }
        }

        /// <summary>
        /// Detemine the MatchUp parent from the previous round. 
        /// </summary>
        private MatchUp parent;

        /// <summary>
        /// Set or Get the MatchUp parent from the previous round.
        /// </summary>
        public MatchUp Parent
        {
            get { return parent; }
            set { parent = value; }
        }
    }
}
