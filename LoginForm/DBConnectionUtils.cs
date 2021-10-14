using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    class DBConnectionUtils
    {

        public static MySqlConnection GetDBConnection(string host, int port, string database, string uid, string password)
        {
            string connectionString = "Server=" + host + ";Port=" + port +
                ";Database=" + database + ";Uid=" + uid + ";Pwd=" + password+ ";SSL Mode=None";

            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
