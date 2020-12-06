using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Connections;

namespace TrackerUI
{
    /*Questa classe rispecchia le configurazione generali dell'applicazione*/
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InizializeConnection(bool database, bool textfiles) {
            if (database)
            {
                //create sql connection
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql); 
            }
            if (textfiles)
            {
                //create text connection 
                TextConnector text = new TextConnector();
                Connections.Add(text); 
            }
        }
    }
}
