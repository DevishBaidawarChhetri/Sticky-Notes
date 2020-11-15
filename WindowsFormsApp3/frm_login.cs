using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_class LoginBLL = new login_class();
            LoginBLL._username = txtusername.Text.Trim();
            LoginBLL._password = txtpassword.Text.Trim();

            bool isValidUser = LoginBLL.checkUser();

            if (isValidUser)
            {
                this.Hide();
                frm_dashboard obj = new frm_dashboard(txtusername.Text);
                obj.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main main = new frm_main();
            main.ShowDialog();
        }
    }
}
