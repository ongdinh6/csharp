using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    class StudentDAO
    {
        private MySqlConnection conn;

        public StudentDAO(MySqlConnection conn)
        {
            this.conn = conn;
        }

        public void GetList()
        {
            conn.Open();
            MySqlCommand sqlCommand = new MySqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = "select * from student";
            sqlCommand.ExecuteReader();

        }
    }
}
