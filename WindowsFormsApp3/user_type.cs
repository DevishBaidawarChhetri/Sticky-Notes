using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class user_type
    {
        private String Firstname, Lastname, Addrss, Phone,Email,Gender,UsertypeID, Username, Password;
        private int Userid;
        public int _userid
        {
            get { return Userid; }
            set { Userid = value; }
        }
        public string _firstname
        {
            get { return Firstname; }
            set { Firstname = value; }
        }

        public string _lastname
        {
            get { return Lastname; }
            set { Lastname = value; }
        }

        public string _addrss
        {
            get { return Addrss; }
            set { Addrss = value; }
        }

        public string _phone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        public string _email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string _gender
        { 
             
            get { return Gender; }
            set { Gender = value; }
        }
        public string _usertypeid
        {
            get { return UsertypeID; }
            set { UsertypeID = value; }
        }
        public string _username
        {
            get { return Username; }
            set { Username = value; }
        }
        public string _password
        {
            get { return Password; }
            set { Password = value; }
        }
        dbConnection user = new dbConnection();
        public DataTable UserUpdate()
        {
            DataTable dt = null;
            string query;
            query = "select * from Users where Users_ID=" + Userid;
            //MessageBox.Show(query);
            try
            {
                dt = user.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
        public void Update()
        {
            string query;
            query = "Update Users set Usertype_ID=" + UsertypeID + ",FirstName='" + Firstname + "',LastName='" + Lastname + "',Address_Name='" + Addrss + "',Phone_No='" + Phone + "',Email='" + Email + "',Gender='" + Gender + "',Username='" + Username + "',Passcode='" + Password + "' where Users_ID=" + Userid;
            try
            {
                user.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Delete()
        {
            string query,query1;
            query = "Delete from Users where Users_ID=" + Userid;
            
            query1 = "Delete From StickyNotes where Users_ID=" +Userid;
            try
            {
                
                user.Manipulate(query1);
                user.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

            public void addUser()
        {
            string query;
            query = "insert into Users(Usertype_id,FirstName,LastName,Address_Name,Phone_No,Email,Gender,Username,Passcode)values(" + UsertypeID + ",'" + Firstname + "','" +Lastname + "','" + Addrss + "','" + Phone + "','" + Email + "','" + Gender + "','" + Username + "','" + Password + "');";
            try
            {
                user.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public DataTable User()
        {
            DataTable dt = null;
            string query;
            query = "Select Usertype_id,Users_ID,FirstName,LastName,Address_Name,Phone_No,Email,Gender,Username,Passcode from Users";
            try
            {
                dt = user.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
    }
}
