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
    public partial class frm_categories_add : Form
    {
        public frm_categories_add()
        {
            InitializeComponent();
        }
        private void DataDisplay()
        {
            DataTable dt = category.Categorydgv();
            dgv1.DataSource = dt;
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        categories_class category = new categories_class();
        private void button1_Click(object sender, EventArgs e)
        {
            category._category = txt1.Text;
            category.Addcategory();
            MessageBox.Show(category._category + " category has been added!");
            txt1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main main = new frm_main();
            main.ShowDialog();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            DataDisplay();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
