using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentLibrary.Model
{
    public class MatchUp
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
        /// List of matchUp Entries 
        /// to hold the currents plays
        /// </summary>
        private List<MatchUpEntry> entries = new List<MatchUpEntry>();

        /// <summary>
        /// Set or Get MatchUP Entries
        /// </summary>
        public List<MatchUpEntry> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        /// <summary>
        /// The winner team
        /// </summary>
        private Team winner = new Team();

        /// <summary>
        /// Set or Get the winner of the macthUp
        /// </summary>
        public Team Winner
        {
            get { return winner; }
            set { winner = value; }
        }

        /// <summary>
        /// Determine the current round of the MatchUp 
        /// </summary>
        private int round;

        /// <summary>
        /// Set or Get the round of matchup
        /// </summary>
        public int Round
        {
            get { return round; }
            set { round = value; }
        }
    }
}
