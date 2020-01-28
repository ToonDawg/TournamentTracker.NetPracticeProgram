using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TournamentTrackerv1;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }


        public static void InitialiseConnection(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the Sql connection properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create the text connection
                TextHelpers text = new TextHelpers();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
