﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();


        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //TODO -Set up the SQL connector prop
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - 
                TextConnector text = new TextConnector();
                Connections.Add(text);

            }
        }
    }
}