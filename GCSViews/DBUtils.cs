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
<<<<<<< HEAD
            string datasource = @"CS-RABBIT";
||||||| merged common ancestors
            string datasource = @"CS-RABBI";
=======
            string datasource = @"NAPAT";
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc

            string database = "DroneFlightPlanner";
            string username = "";
            string password = "";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}