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
            string datasource = @"JURARUT-S\MSSQLSERVER_2";

            string database = "DroneFlightPlanner";
            string username = "test";
            string password = "p@ssw0rd";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}