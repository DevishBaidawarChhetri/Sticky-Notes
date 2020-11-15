using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class categories_class
    {
        private String Category;
        public string _category
        {
            get { return Category; }
            set { Category = value; }
        }
        dbConnection categ = new dbConnection();
        public void Addcategory()
        {
            string query;
            query = "insert into Categories(Categories_Name)values('" + Category + "')";
            try
            {
                categ.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public DataTable Categorydgv()
        {
            DataTable dt = null;
            string query;
            query = "Select Categories_ID,Categories_Name from Categories";
            try
            {
                dt = categ.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }

    }
   
}
