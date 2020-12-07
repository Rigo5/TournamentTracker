using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Queste si occupano della creazione del form 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Inizializza le connessioni 
            GlobalConfig.InizializeConnection(true, true);
            // non finere questa applicazione fino a quando questo non viene chiuso 
            Application.Run(new CreateTeamForm());
        }
    }
}
