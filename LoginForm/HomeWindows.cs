using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class HomeWindows : Form
    {
        public HomeWindows()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
            MySqlConnection sqlConnection = MySQLConnectionDB.GetDBConnection();
            sqlConnection.Open();
            StudentDAO studentDAO = new StudentDAO(sqlConnection);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("select * from student", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            this.dataGridView1.DataSource = dataTable;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
