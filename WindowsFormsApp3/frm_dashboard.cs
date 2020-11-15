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
    public partial class frm_dashboard : Form
    {
        private string username;

        public frm_dashboard(string username)
        {
            this.username = username;


            InitializeComponent();
        }


        public frm_dashboard()
        {
            InitializeComponent();
        }
        dashboard_class dash = new dashboard_class();
        private void Dashboard_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            lblUsername.Text = username;
            panel1.Controls.Clear();

            dash._username = lblUsername.Text;
            string userid = dash.userIDD();

            dash._userid = userid;
            DataTable dt = dash.titleandcontent2();


            int x = 10, y = 50;
            int d = 1;
            int n = 0;
            for (int s = 0; s < dt.Rows.Count; s++)
            {

                Panel childPanel = new Panel();
                childPanel.Location = new Point(x, y);
                childPanel.BackColor = Color.AliceBlue;
                childPanel.Size = new Size(250, 250);
                Label lblid = new Label();
                lblid.Text = dt.Rows[n][2].ToString();

                lblid.Location = new Point(10, 220);
                lblid.Visible = true;
                Label lbltitle = new Label();
                lbltitle.Text = dt.Rows[n][0].ToString();

                lbltitle.Location = new Point(10, 10);
                ComboBox cmbcategory = new ComboBox();
                dash._stickyid = int.Parse(lblid.Text);
                DataTable dt1 = dash.getcategory();
                DataTable dt2 = dash.getcategory1();
               
                for (int i = 0; i < dt2.Rows.Count; i++)
                    
                {
                    DataRow dataRow = dt1.NewRow();
                    dataRow["Categories_Name"] = dt2.Rows[i][1].ToString();
                    dataRow["Categories_ID"] = dt2.Rows[i][0].ToString();
                    dt1.Rows.Add(dataRow);
                }
               
                cmbcategory.DataSource = dt1;
                
                
                cmbcategory.DisplayMember = "Categories_Name";

                cmbcategory.ValueMember = "Categories_ID";
                cmbcategory.Location = new Point(120, 10);
                TextBox txtcontent = new TextBox();
                txtcontent.Text = dt.Rows[n][1].ToString();

                txtcontent.Size = new Size(200, 150);
                txtcontent.Location = new Point(10, 40);
                txtcontent.Multiline = true;
                Button btnclick = new Button();
                btnclick.Text = "SAVE";
                btnclick.Location = new Point(170, 200);
                n = n + 1;
                //inner click event
                btnclick.Click += (z, a) =>
                {
                    if (MessageBox.Show("Are you Sure you want to Save?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        dash._categoryid = int.Parse(cmbcategory.SelectedValue.ToString());
                        dash._title = lbltitle.Text;
                        dash._content = txtcontent.Text;

                        dash.updateContent();
                        MessageBox.Show("Successfully saved");
                        panel1.Controls.Clear();
                    }
                    else
                    {

                        MessageBox.Show("Not Updated!");
                    }


                };
                //adding to Child Panel
                childPanel.Controls.Add(lblid);
                childPanel.Controls.Add(lbltitle);
                childPanel.Controls.Add(cmbcategory);
                childPanel.Controls.Add(txtcontent);
                childPanel.Controls.Add(btnclick);
                //adding child panel to parent panel
                panel1.Controls.Add(childPanel);
                x = x + childPanel.Width + 10;
                d = d + 1;
                if (x > 1300)
                {
                    x = 10;
                    y = y + childPanel.Width + 10;
                }
            }





        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main main = new frm_main();
            main.ShowDialog();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dashboard_class dash = new dashboard_class();
            dash._username = lblUsername.Text;
            string userid = dash.userIDD();
            dash._userid = userid;
            DataTable dt = dash.titleandcontent();

           
            int x = 10, y = 50;
            int d = 1;
            int n = 0;
            for (int s = 0; s < dt.Rows.Count; s++)
            {

                Panel childPanel = new Panel();
                childPanel.Location = new Point(x, y);
                childPanel.BackColor = Color.AliceBlue;
                childPanel.Size = new Size(250, 250);
                Label lblid = new Label();
                lblid.Text = dt.Rows[n][2].ToString();
                lblid.Location = new Point(10, 220);
                lblid.Visible = true;
                Label lbltitle = new Label();
                lbltitle.Text = dt.Rows[n][0].ToString();

                lbltitle.Location = new Point(10, 10);
                ComboBox cmbcategory = new ComboBox();
                dash._stickyid = int.Parse(lblid.Text);
                DataTable dt1 = dash.getcategory();
                DataTable dt2 = dash.getcategory1();

                for (int i = 0; i < dt2.Rows.Count; i++)

                {
                    DataRow dataRow = dt1.NewRow();
                    dataRow["Categories_Name"] = dt2.Rows[i][1].ToString();
                    dataRow["Categories_ID"] = dt2.Rows[i][0].ToString();
                    dt1.Rows.Add(dataRow);
                }


                cmbcategory.DataSource = dt1;
                cmbcategory.DisplayMember = "Categories_Name";

                cmbcategory.ValueMember = "Categories_ID";
                cmbcategory.Location = new Point(120, 10);
                TextBox txtcontent = new TextBox();
                txtcontent.Text = dt.Rows[n][1].ToString();

                txtcontent.Size = new Size(200, 150);
                txtcontent.Location = new Point(10, 40);
                txtcontent.Multiline = true;
                Button btnclick = new Button();
                btnclick.Text = "SAVE";
                btnclick.Location = new Point(170, 200);
                n = n + 1;
                //inner click event
                btnclick.Click += (z, a) =>
                {
                    if (MessageBox.Show("Are you Sure you want to Save?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        dash._categoryid = int.Parse(cmbcategory.SelectedValue.ToString());

                        dash._title = lbltitle.Text;
                        dash._content = txtcontent.Text;
                        dash.updateContent();
                        MessageBox.Show("Successfully saved");
                        panel1.Controls.Clear();
                    }
                    else
                    {

                        MessageBox.Show("Not Updated!");
                    }


                };
                //adding to Child Panel
                childPanel.Controls.Add(lblid);
                childPanel.Controls.Add(lbltitle);
                childPanel.Controls.Add(cmbcategory);
                childPanel.Controls.Add(txtcontent);
                childPanel.Controls.Add(btnclick);
                //adding child panel to parent panel
                panel1.Controls.Add(childPanel);
                x = x + childPanel.Width + 10;
                d = d + 1;
                if (x > 1300)
                {
                    x = 10;
                    y = y + childPanel.Width + 10;
                }

            }


        }
        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_notes sticky = new frm_notes();
            sticky.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void completedStickyNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dashboard_class dash = new dashboard_class();
            dash._username = lblUsername.Text;
            string userid = dash.userIDD();
            dash._userid = userid;
            DataTable dt = dash.titleandcontent3();

         
            int x = 10, y = 50;
            int d = 1;
            int n = 0;
            for (int s = 0; s < dt.Rows.Count; s++)
            {

                Panel childPanel = new Panel();
                childPanel.Location = new Point(x, y);
                childPanel.BackColor = Color.AliceBlue;
                childPanel.Size = new Size(250, 250);
                Label lblid = new Label();
                lblid.Text = dt.Rows[n][2].ToString();
                lblid.Location = new Point(10, 220);
                lblid.Visible = true;
                Label lbltitle = new Label();
                lbltitle.Text = dt.Rows[n][0].ToString();

                lbltitle.Location = new Point(10, 10);
                ComboBox cmbcategory = new ComboBox();
                dash._stickyid = int.Parse(lblid.Text);
                DataTable dt1 = dash.getcategory();
                DataTable dt2 = dash.getcategory1();

                for (int i = 0; i < dt2.Rows.Count; i++)

                {
                    DataRow dataRow = dt1.NewRow();
                    dataRow["Categories_Name"] = dt2.Rows[i][1].ToString();
                    dataRow["Categories_ID"] = dt2.Rows[i][0].ToString();
                    dt1.Rows.Add(dataRow);
                }


                cmbcategory.DataSource = dt1;
                cmbcategory.DisplayMember = "Categories_Name";

                cmbcategory.ValueMember = "Categories_ID";
                cmbcategory.Location = new Point(120, 10);
                TextBox txtcontent = new TextBox();
                txtcontent.Text = dt.Rows[n][1].ToString();

                txtcontent.Size = new Size(200, 150);
                txtcontent.Location = new Point(10, 40);
                txtcontent.Multiline = true;
                Button btnclick = new Button();
                btnclick.Text = "SAVE";
                btnclick.Location = new Point(170, 200);
                n = n + 1;
                //inner click event
                btnclick.Click += (z, a) =>
                {
                    if (MessageBox.Show("Are you Sure you want to Save?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        dash._categoryid = int.Parse(cmbcategory.SelectedValue.ToString());
                        dash._title = lbltitle.Text;
                        dash._content = txtcontent.Text;

                        dash.updateContent();
                        MessageBox.Show("Successfully saved");
                        panel1.Controls.Clear();
                    }
                    else
                    {

                        MessageBox.Show("Not Updated!");
                    }



                };
                //adding to Child Panel
                childPanel.Controls.Add(lblid);
                childPanel.Controls.Add(lbltitle);
                childPanel.Controls.Add(cmbcategory);
                childPanel.Controls.Add(txtcontent);
                childPanel.Controls.Add(btnclick);
                //adding child panel to parent panel
                panel1.Controls.Add(childPanel);
                x = x + childPanel.Width + 10;
                d = d + 1;
                if (x > 1300)
                {
                    x = 10;
                    y = y + childPanel.Width + 10;
                }

            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pieChartToolStripMenuItem_Click(object sender, EventArgs e)

        {
            
            pie_chart pie = new pie_chart(lblUsername.Text);
            pie.ShowDialog();

        }

        private void incompletedStickyNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dashboard_class dash = new dashboard_class();

            dash._username = lblUsername.Text;
            string userid = dash.userIDD();
            dash._userid = userid;
            DataTable dt = dash.titleandcontent2();

           
            int x = 10, y = 50;
            int d = 1;
            int n = 0;
            for (int s = 0; s < dt.Rows.Count; s++)
            {

                Panel childPanel = new Panel();
                childPanel.Location = new Point(x, y);
                childPanel.BackColor = Color.AliceBlue;
                childPanel.Size = new Size(250, 250);
                Label lblid = new Label();
                lblid.Text = dt.Rows[n][2].ToString();
                lblid.Location = new Point(10, 220);
                lblid.Visible = true;
                Label lbltitle = new Label();
                lbltitle.Text = dt.Rows[n][0].ToString();

                lbltitle.Location = new Point(10, 10);
                ComboBox cmbcategory = new ComboBox();
                dash._stickyid = int.Parse(lblid.Text);
                DataTable dt1 = dash.getcategory();
                DataTable dt2 = dash.getcategory1();

                for (int i = 0; i < dt2.Rows.Count; i++)

                {
                    DataRow dataRow = dt1.NewRow();
                    dataRow["Categories_Name"] = dt2.Rows[i][1].ToString();
                    dataRow["Categories_ID"] = dt2.Rows[i][0].ToString();
                    dt1.Rows.Add(dataRow);
                }


                cmbcategory.DataSource = dt1;
                cmbcategory.DisplayMember = "Categories_Name";

                cmbcategory.ValueMember = "Categories_ID";
                cmbcategory.Location = new Point(120, 10);
                TextBox txtcontent = new TextBox();
                txtcontent.Text = dt.Rows[n][1].ToString();

                txtcontent.Size = new Size(200, 150);
                txtcontent.Location = new Point(10, 40);
                txtcontent.Multiline = true;
                Button btnclick = new Button();
                btnclick.Text = "SAVE";
                btnclick.Location = new Point(170, 200);
                n = n + 1;
                //inner click event
                btnclick.Click += (z, a) =>
                {
                    if (MessageBox.Show("Are you Sure you want to Save?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


                    {
                        dash._categoryid = int.Parse(cmbcategory.SelectedValue.ToString());
                        dash._title = lbltitle.Text;
                        dash._content = txtcontent.Text;
                        dash.updateContent();
                        MessageBox.Show("Successfully saved");
                        panel1.Controls.Clear();
                    }
                    else
                    {

                        MessageBox.Show("Not Updated!");
                    }


                };
                //adding to Child Panel
                childPanel.Controls.Add(lblid);
                childPanel.Controls.Add(lbltitle);
                childPanel.Controls.Add(cmbcategory);
                childPanel.Controls.Add(txtcontent);
                childPanel.Controls.Add(btnclick);
                //adding child panel to parent panel
                panel1.Controls.Add(childPanel);
                x = x + childPanel.Width + 10;
                d = d + 1;
                if (x > 1300)
                {
                    x = 10;
                    y = y + childPanel.Width + 10;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tstxt1_Click(object sender, EventArgs e)
        {
            
    
         }

        private void tstxt1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tstxt1_Enter(object sender, EventArgs e)
        {
            


        }

        private void tstxt1_Click_1(object sender, EventArgs e)
        {

        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dashboard_class dash = new dashboard_class();

            dash._username = lblUsername.Text;
            string userid = dash.userIDD();
            dash._userid = userid;
            DataTable dt = dash.titleandcontent4();

          
            int x = 10, y = 50;
            int d = 1;
            int n = 0;
            for (int s = 0; s < dt.Rows.Count; s++)
            {

                Panel childPanel = new Panel();
                childPanel.Location = new Point(x, y);
                childPanel.BackColor = Color.AliceBlue;
                childPanel.Size = new Size(250, 250);
                Label lblid = new Label();
                lblid.Text = dt.Rows[n][3].ToString();
                lblid.Location = new Point(10, 220);
                lblid.Visible = true;
                Label lbltitle = new Label();
                lbltitle.Text = dt.Rows[n][0].ToString();

                lbltitle.Location = new Point(10, 10);
                Label lbldate = new Label();
                lbldate.Text= dt.Rows[n][2].ToString();
                lbldate.Location = new Point(10, 205);
                lbldate.Visible = true;
                ComboBox cmbcategory = new ComboBox();
                dash._stickyid = int.Parse(lblid.Text);
                DataTable dt1 = dash.getcategory();
                DataTable dt2 = dash.getcategory1();

                for (int i = 0; i < dt2.Rows.Count; i++)

                {
                    DataRow dataRow = dt1.NewRow();
                    dataRow["Categories_Name"] = dt2.Rows[i][1].ToString();
                    dataRow["Categories_ID"] = dt2.Rows[i][0].ToString();
                    dt1.Rows.Add(dataRow);
                }


                cmbcategory.DataSource = dt1;
                cmbcategory.DisplayMember = "Categories_Name";

                cmbcategory.ValueMember = "Categories_ID";
                cmbcategory.Location = new Point(120, 10);
                TextBox txtcontent = new TextBox();
                txtcontent.Text = dt.Rows[n][1].ToString();

                txtcontent.Size = new Size(200, 150);
                txtcontent.Location = new Point(10, 40);
                txtcontent.Multiline = true;
                Button btnclick = new Button();
                btnclick.Text = "SAVE";
                btnclick.Location = new Point(170, 200);
                n = n + 1;
                //inner click event
                btnclick.Click += (z, a) =>
                {
                    if (MessageBox.Show("Are you Sure you want to Save?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        dash._categoryid = int.Parse(cmbcategory.SelectedValue.ToString());
                        dash._title = lbltitle.Text;
                        dash._content = txtcontent.Text;
                        dash.updateContent();
                        MessageBox.Show("Successfully saved");
                        panel1.Controls.Clear();

                    }
                    else
                    {

                        MessageBox.Show("Not Updated!");
                    }



                };
                //adding to Child Panel
                childPanel.Controls.Add(lblid);
                childPanel.Controls.Add(lbltitle);
                childPanel.Controls.Add(cmbcategory);
                childPanel.Controls.Add(lbldate);
                childPanel.Controls.Add(txtcontent);
               
                childPanel.Controls.Add(btnclick);
                //adding child panel to parent panel
                panel1.Controls.Add(childPanel);
                x = x + childPanel.Width + 10;
                d = d + 1;
                if (x > 1300)
                {
                    x = 10;
                    y = y + childPanel.Width + 10;
                }
            }
        }

        private void byTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dashboard_class dash = new dashboard_class();
            dash._title = tstxt1.Text.ToString();
            dash._username = lblUsername.Text;
            string userid = dash.userIDD();
            dash._userid = userid;
            DataTable dt = dash.titleandcontent5();

           
            int x = 10, y = 50;
            int d = 1;
            int n = 0;
            for (int s = 0; s < dt.Rows.Count; s++)
            {

                Panel childPanel = new Panel();
                childPanel.Location = new Point(x, y);
                childPanel.BackColor = Color.AliceBlue;
                childPanel.Size = new Size(250, 250);
                Label lblid = new Label();
                lblid.Text = dt.Rows[n][2].ToString(); ;
                lblid.Location = new Point(10, 220);
                lblid.Visible = true;
                Label lbltitle = new Label();
                lbltitle.Text = dt.Rows[n][0].ToString();

                lbltitle.Location = new Point(10, 10);
                ComboBox cmbcategory = new ComboBox();
                dash._stickyid = int.Parse(lblid.Text);
                DataTable dt1 = dash.getcategory();
                DataTable dt2 = dash.getcategory1();

                for (int i = 0; i < dt2.Rows.Count; i++)

                {
                    DataRow dataRow = dt1.NewRow();
                    dataRow["Categories_Name"] = dt2.Rows[i][1].ToString();
                    dataRow["Categories_ID"] = dt2.Rows[i][0].ToString();
                    dt1.Rows.Add(dataRow);
                }


                cmbcategory.DataSource = dt1;
                cmbcategory.DisplayMember = "Categories_Name";

                cmbcategory.ValueMember = "Categories_ID";
                cmbcategory.Location = new Point(120, 10);
                TextBox txtcontent = new TextBox();
                txtcontent.Text = dt.Rows[n][1].ToString();
                

                txtcontent.Size = new Size(200, 150);
                txtcontent.Location = new Point(10, 40);
                txtcontent.Multiline = true;
                Button btnclick = new Button();
                btnclick.Text = "SAVE";
                btnclick.Location = new Point(170, 200);
                n = n + 1;
                //inner click event
                btnclick.Click += (z, a) =>
                {
                    if (MessageBox.Show("Are you Sure you want to Save?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        dash._categoryid = int.Parse(cmbcategory.SelectedValue.ToString());
                        dash._title = lbltitle.Text;
                        dash._content = txtcontent.Text;
                        dash.updateContent();
                        MessageBox.Show("Successfully saved");
                        panel1.Controls.Clear();
                    }
                    else
                    {

                        MessageBox.Show("Not Updated!");
                    }



                };
                //adding to Child Panel
                childPanel.Controls.Add(lblid);
                childPanel.Controls.Add(lbltitle);
                childPanel.Controls.Add(cmbcategory);
                childPanel.Controls.Add(txtcontent);
                childPanel.Controls.Add(btnclick);
                //adding child panel to parent panel
                panel1.Controls.Add(childPanel);
                x = x + childPanel.Width + 10;
                d = d + 1;
                if (x > 1300)
                {
                    x = 10;
                    y = y + childPanel.Width + 10;
                }
            }
        }

        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_help help = new frm_help();
            help.ShowDialog();
        }

        private void toolStripTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dashboard_class dash = new dashboard_class();
            dash._title = tstxt2.Text.ToString();
            dash._username = lblUsername.Text;
            string userid = dash.userIDD();
            dash._userid = userid;
            DataTable dt = dash.titleandcontent5();


            int x = 10, y = 50;
            int d = 1;
            int n = 0;
            for (int s = 0; s < dt.Rows.Count; s++)
            {

                Panel childPanel = new Panel();
                childPanel.Location = new Point(x, y);
                childPanel.BackColor = Color.AliceBlue;
                childPanel.Size = new Size(250, 250);
                Label lblid = new Label();
                lblid.Text = dt.Rows[n][2].ToString(); 
                lblid.Location = new Point(10, 220);
                lblid.Visible = true;
                Label lbltitle = new Label();
                lbltitle.Text = dt.Rows[n][0].ToString();
                dash._title = lbltitle.Text;
                lbltitle.Location = new Point(10, 10);

                TextBox txtcontent = new TextBox();
                txtcontent.Text = dt.Rows[n][1].ToString();
                dash._content = txtcontent.Text;
                txtcontent.Size = new Size(200, 150);
                txtcontent.Location = new Point(10, 40);
                txtcontent.Multiline = true;
                Button btnclick = new Button();
                btnclick.Text = "DELETE";
                btnclick.Location = new Point(170, 200);
                n = n + 1;
                //inner click event
                btnclick.Click += (z, a) =>
                {


                    if (MessageBox.Show("Are you Sure you want to delete?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {

                        dash._content = txtcontent.Text;
                        dash.deletesticky();
                        MessageBox.Show("Successfully Deleted");
                        panel1.Controls.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Not deleted!");
                    }



                };
                //adding to Child Panel
                childPanel.Controls.Add(lblid);
                childPanel.Controls.Add(lbltitle);
                childPanel.Controls.Add(txtcontent);
                childPanel.Controls.Add(btnclick);
                //adding child panel to parent panel
                panel1.Controls.Add(childPanel);
                x = x + childPanel.Width + 10;
                d = d + 1;
                if (x > 1300)
                {
                    x = 10;
                    y = y + childPanel.Width + 10;
                }
            }
        }

        private void tstxt1_Click_2(object sender, EventArgs e)
        {

        }

        private void tstxt2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl2.Text = DateTime.Now.ToString("yyyy/MM/dd        hh:mm:ss");
        }
    }
    
 }
    

