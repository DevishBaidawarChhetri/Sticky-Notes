using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class dashboard_class
    {
        dbConnection dbconnection = new dbConnection();
        private string Username, Userid, Title, Content;
        private int Categoryid,StickyID;
        public int _stickyid
        {
            get { return StickyID; }
            set { StickyID = value; }
        }



        public int _categoryid
        {
            get { return Categoryid; }
            set { Categoryid = value; }
        }

        public string _username
        {
            get { return Username; }
            set { Username = value; }

        }
            public string _userid
        {
            get { return Userid; }
            set { Userid = value; }
        }
        public string _title
        {
            get { return Title; }
            set { Title = value; }

        }
        public string _content
        {
            get { return Content; }
            set { Content = value; }

        }
      

        public string userIDD()
        {
            string query = "select  Users_ID from Users where Username = '" + Username + "';";
            DataTable datatable = null;
            try
            {
                datatable = dbconnection.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string userid = datatable.Rows[0][0].ToString();
            return userid;

        }
        
        public DataTable titleandcontent()
        {
            String query = "select Title,Content_Of_Notes,StickyNotes_ID from StickyNotes where Users_ID = " + Userid + ";";
            DataTable dt = null;
            try
            {
                dt= dbconnection.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
        public DataTable titleandcontent2()
        {
            String query = "select Title,Content_Of_Notes,StickyNotes_ID from StickyNotes where IsStickied = +1 and Users_ID= " + Userid + ";";
            DataTable dt = null;
            try
            {
                dt = dbconnection.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
        public DataTable titleandcontent3()
        {
            String query = "select Title,Content_Of_Notes,StickyNotes_ID from StickyNotes where IsCompleted = +1 and Users_ID= " + Userid + ";";
            DataTable dt = null;
            try
            {
                dt = dbconnection.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
        
        public void updateContent()
        {
            String query = "update StickyNotes set Content_of_Notes = '" + Content + "',Categories_ID=" + Categoryid + " where Title = '" + Title+"';";
            try
            {
                dbconnection.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public DataTable titleandcontent4()
        {
            String query = "select Title,Content_of_Notes,Date_Created,StickyNotes_ID from StickyNotes where Users_ID = " + Userid + " order by Date_Created desc;";
            DataTable dt = null;
            try
            {
                dt = dbconnection.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;

        }
        public DataTable titleandcontent5()
        {
            String query = "select Title,Content_of_Notes,StickyNotes_ID from StickyNotes where Title = '" + Title + "' and Users_ID= " + Userid + ";";

            DataTable dt = null;
            try
            {
                dt = dbconnection.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;

        }
        public void deletesticky()
        {
            String query = "delete from StickyNotes where Users_ID= " + Userid + " and Title = '" + Title + "';";
            try
            {
                dbconnection.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public DataTable getcategory()
        {
            
            
            string Categoryid = "select Categories_ID from StickyNotes where StickyNotes_ID=" + StickyID + ";";
            DataTable dt3 = dbconnection.Retrieve(Categoryid);
            Categoryid = dt3.Rows[0][0].ToString();
            string Categoryname = "select * from Categories where Categories_ID=" + Categoryid + ";";
            DataTable dt4 = null;
          
     
            
            try
            {
                dt4 = dbconnection.Retrieve(Categoryname);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt4;

        }
        public DataTable getcategory1()
        {

          
            string Categoryid = "select Categories_ID from StickyNotes where StickyNotes_ID=" + StickyID + ";";
            DataTable dt3 = dbconnection.Retrieve(Categoryid);
            Categoryid = dt3.Rows[0][0].ToString();
        
            string query = "select* from Categories where Categories_ID!='"+Categoryid+"';";
           

            DataTable dt = null;

            try
            {
                dt = dbconnection.Retrieve(query);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;

        }

    }
}
