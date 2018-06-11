using co.mz.TournamentLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTrackerUI.Utilities.Interfaces
{
    public interface IPrizeRequestor
    {
        void PrizeCompleted(Prize _prize);
    }
}
