using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    class MySQLConnectionDB
    {
       
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "student_management";
            string uid = "root";
            string password = "";

            return DBConnectionUtils.GetDBConnection(host, port, database, uid, password);

        }
    }
}
