using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerUI;

namespace TrakerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TrackerLibrary.GlobalConfig.InitialiseConnection(TournamentTrackerv1.DatabaseType.Sql);
            Application.Run(new CreateTournamentForm());
            //Application.Run(new TournamentDashBoard());
        }
    }
}
