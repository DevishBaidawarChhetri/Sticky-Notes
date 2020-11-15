using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class user_type_class
    {
        dbConnection conn = new dbConnection();
        private string Usertype;
        public string _usertype
        {
            get { return Usertype; }
            set { Usertype = value; }
        }
        public void addusertype()
        {
            string query;
            
            query = "insert into Usertype(Usertype_Name) values('" + Usertype + "')";
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public DataTable Usertypedgv()
        {
            DataTable dt = null;
            string query;
            query = "Select Usertype_ID,Usertype_Name from Usertype";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }

    }
}
