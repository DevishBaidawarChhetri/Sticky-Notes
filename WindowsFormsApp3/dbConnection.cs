using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class dbConnection
    {
        SqlConnection cn = new SqlConnection(@"Data source=UBUNTU; Initial Catalog=Devish_Stickynotes; Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public void Manipulate(string query)

        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable Retrieve(string query)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(query, cn);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
