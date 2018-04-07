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
            string datasource = @"CS-RABBIT\SQLEXPRESS";

            string database = "DroneFlightPlanner";
            string username = "test";
            string password = "P@ssw0rd";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}