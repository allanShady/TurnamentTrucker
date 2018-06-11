using co.mz.TournamentLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentLibrary.DataAcess
{
    public interface IDataConnection
    {
        Prize CreatePrize(Prize prize);
        Person CreatePerson(Person person);
        Team CreateTeam(Team team);
        Tournament CreateTournament(Tournament tournament);
        List<Team> GetAllTeam();
        List<Person> GetAllpeople();
    }
}
