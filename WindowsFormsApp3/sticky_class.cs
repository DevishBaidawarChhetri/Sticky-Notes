using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class sticky_class
    {
        private string Userid,Categoriesid, Date, Title, Content;
         int   Isstickied, Iscompleted;
        public string _userid
        {
            get { return Userid; }
            set { Userid = value; }
        }
        public string _categoriesid
        {
            get { return Categoriesid; }
            set { Categoriesid = value; }
        }

        public string _date
        {
            get { return Date; }
            set { Date = value; }
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
        public int _isstickied
        {
            get { return Isstickied; }
            set { Isstickied = value; }
        }
        public int _iscompleted
        {
            get { return Iscompleted; }
            set { Iscompleted = value; }
        }
        dbConnection stick = new dbConnection();

        
        public DataTable getName(int UserID)
        {
            String query = "select FirstName,LastName from Users where Users_ID = " + UserID+";";


            DataTable dt = null;
            try
            {
                dt = stick.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;


        }
        public void addSticky()
        {
            string query;
            query = "insert into StickyNotes(Users_ID,Categories_ID,Date_Created,Title,Content_Of_Notes,Isstickied,Iscompleted)values('" + Userid + "'," +Categoriesid + ",'" + Date + "','" + Title + "','" + Content + "'," + Isstickied + "," + Iscompleted + ");";
            try
            {
                stick.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       
    }
}
