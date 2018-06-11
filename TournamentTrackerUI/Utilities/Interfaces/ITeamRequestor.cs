using co.mz.TournamentLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerUI.Utilities.Interfaces
{
    public interface ITeamRequestor
    {
        void TeamCompleted(Team _team);
    }
}
