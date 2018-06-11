using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentLibrary.Model
{
    public class Team
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
        /// List of team members stored in the system as people.
        /// </summary>
        private List<Person> members = new List<Person>();

        /// <summary>
        /// Set or Get Member of the team.
        /// </summary>
        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        /// <summary>
        /// Team identifier.
        /// </summary>
        private string name;

        /// <summary>
        /// Set or Get the team name (identifier)
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
