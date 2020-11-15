using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp3
{
   public class login_class
    {
        private string username;
        private string password;
        public string _username
        {
            get { return username; }
            set { username = value; }
        }
        public string _password
        {
            get { return password; }
            set { password = value; }
        }
        dbConnection conn = new dbConnection();
        public bool checkUser()
        {
            string query;
            query = "select Username from Users where Username='" + username + "' and Passcode='" + password + "'";
            DataTable dt = null;
            try{dt = conn.Retrieve(query);}
            catch (Exception e){Console.WriteLine(e.Message);}
            if (dt.Rows.Count > 0){
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}