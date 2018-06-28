using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"NAPAT";

            string database = "DroneFlightPlanner";
            string username = "";
            string password = "";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}