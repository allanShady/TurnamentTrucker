using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using co.mz.TournamentLibrary.Utilities;

namespace TournamentTrackerUI
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfig.InitializeConnection(DatabaseType.SQL);
            
            Application.Run(new TournamentCreate());
            //Application.Run(new DashBoard());
        }
    }
}
