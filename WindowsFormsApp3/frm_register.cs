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
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }
        dbConnection user = new dbConnection();
        private void DataDisplay()
        {
            DataTable dt = Userentrycl.User();
            dgv1.DataSource = dt;
        }
        private void Userentry_Load(object sender, EventArgs e)
        {

            DataDisplay();
            string query;
            query = "select * from Usertype";
            DataTable dt1 = user.Retrieve(query);
            cmb6.DataSource = dt1;
            cmb6.DisplayMember = "Usertype_Name";
            cmb6.ValueMember = "Usertype_ID";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main main = new frm_main();
            main.ShowDialog();
        }
        
        user_type Userentrycl = new user_type();
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "ADD")
            {
                string gender;
                if (rdobtn1.Checked == true)
                {

                    gender = "Male";

                }
                else if (rdobtn2.Checked == true)
                {
                    gender = "Female";

                }
                else
                {
                    gender = "Others";

                }

                Userentrycl._firstname = txt1.Text;
                Userentrycl._lastname = txt2.Text;
                Userentrycl._addrss = txt3.Text;
                Userentrycl._phone = txt4.Text;
                Userentrycl._email = txt5.Text;
                Userentrycl._gender = gender;
                Userentrycl._usertypeid = cmb6.SelectedValue.ToString();
                Userentrycl._username = txt7.Text;
                Userentrycl._password = txt8.Text;
                Userentrycl.addUser();

                MessageBox.Show(Userentrycl._firstname + " " + Userentrycl._lastname + " account has been created");
                DataTable dts = Userentrycl.User();
                dgv1.DataSource = dts;
            }
            else if (btnadd.Text == "Update")
            {
                string gender;
                if (rdobtn1.Checked == true)
                {

                    gender = "Male";

                }
                else if (rdobtn2.Checked == true)
                {
                    gender = "Female";

                }
                else
                {
                    gender = "Others";

                }

                Userentrycl._firstname = txt1.Text;
                Userentrycl._lastname = txt2.Text;
                Userentrycl._addrss = txt3.Text;
                Userentrycl._phone = txt4.Text;
                Userentrycl._email = txt5.Text;
                Userentrycl._gender = gender;
                Userentrycl._usertypeid = cmb6.SelectedValue.ToString();
                Userentrycl._username = txt7.Text;
                Userentrycl._password = txt8.Text;
                Userentrycl.Update();
                MessageBox.Show(Userentrycl._firstname + " " + Userentrycl._lastname + " account has been updated successfully");
                DataTable dts = Userentrycl.User();
                dgv1.DataSource = dts;
            }
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = txt7.Text = txt8.Text = "";
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_Click(object sender, EventArgs e)
        {
            int columnIndex = dgv1.CurrentCell.ColumnIndex;
            int userid = int.Parse(dgv1.CurrentRow.Cells["Users_ID"].Value.ToString());
            Userentrycl._userid = userid;
            if (dgv1.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                DataTable dts = Userentrycl.UserUpdate();
                
               
                txt1.Text = dts.Rows[0][2].ToString();
                txt2.Text = dts.Rows[0][3].ToString();
                txt3.Text = dts.Rows[0][4].ToString();
                txt4.Text = dts.Rows[0][5].ToString();
                txt5.Text = dts.Rows[0][6].ToString();
                txt7.Text = dts.Rows[0][8].ToString();
                txt8.Text = dts.Rows[0][9].ToString();

                string Gender = dts.Rows[0][7].ToString();

                if (Gender == "Male")
                {

                    rdobtn1.Checked = true;

                }
                else if (Gender == "Female")
                {
                    rdobtn2.Checked = true;

                }
                else
                {
                    rdobtn3.Checked = true;

                }
                btnadd.Text ="Update";
            }
            else if (dgv1.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Userentrycl.Delete();
                    DataTable dts = Userentrycl.User();
                    dgv1.DataSource = dts;
                }
            }

        }
            
    }
}
