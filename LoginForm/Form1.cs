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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = txtBoxEmail.Text;
            string Password = txtBoxPass.Text; 

            if(UserName.Length == 0 || Password.Length == 0)
            {
                lbErrorLogin.Text = "Vui lòng nhập đầy đủ thông tin!";
                lbErrorLogin.Visible = true;
            }else
            {
               if(UserName.Equals("admin") && Password.Equals("admin"))
                {
                    HomeWindows Form2 = new HomeWindows();
                    Form2.Show();
                    this.Hide();
                }
                else
                {
                    lbErrorLogin.Visible = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Bạn muốn thoát chương trình ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }
    }
}
;