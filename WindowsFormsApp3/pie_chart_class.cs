using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class pie_chart_class
    {
        private string Username;
        public string _username
        {
            get { return Username; }
            set { Username = value; }

        }
        public int usersss()
        {
            
            string query = "select Users_ID from Users where Username='" + Username + "';";
            DataTable dt = null;
            try
            {
               dt= conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return int.Parse(dt.Rows[0][0].ToString());
        }



        dbConnection conn = new dbConnection();
        public DataTable NoteCounttodaydate(string todaydate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where Date_Created='" + todaydate + "'and IsCompleted='1' and Users_ID=" + usersss();
            MessageBox.Show(query);
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

        public DataTable NoteCounttodaydate2(string todaydate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where Date_Created='" + todaydate + "' and IsCompleted='0'and Users_ID=" + usersss();
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

        public DataTable NoteCountweekdate(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where Date_Created between '" + Nowdate + "' and '" + todaydate + "' and IsCompleted='1' and Users_ID=" + usersss();
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

        public DataTable NoteCountweekdate2(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where Date_Created between '" + Nowdate + "' and '" + todaydate + "' and IsCompleted='0'and Users_ID=" + usersss();
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

        public DataTable NoteCountmonthdate(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where Date_Created between '" + Nowdate + "' and '" + todaydate + "'and IsCompleted='1' and Users_ID=" + usersss();
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

        public DataTable NoteCountmonthdate2(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where Date_Created between '" + Nowdate + "' and '" + todaydate + "' and IsCompleted='0'and Users_ID=" + usersss();
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

        public DataTable NoteCountyeardate(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where Date_Created between '" + Nowdate + "' and '" + todaydate + "'and IsCompleted='1' and Users_ID=" + usersss();
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

        public DataTable NoteCountyeardate2(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where Date_Created between '" + Nowdate + "' and '" + todaydate + "' and IsCompleted='0'and Users_ID=" + usersss();
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

