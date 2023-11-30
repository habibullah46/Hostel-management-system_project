using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Helper
{
    public  class helper
    { 
       
      public static string  connection = System.Configuration.ConfigurationManager.ConnectionStrings["myconnecton"].ToString();
        static SqlConnection con = new SqlConnection(connection);
        public void OpenCon()
        {
            con.Open();
        }
        public void CloseCon()
        {
            con.Close();

        }
        public void NonexecuteQuerry(string querry)
        {
            SqlCommand cmd = new SqlCommand(querry,con);
            cmd.ExecuteNonQuery();
        }
    }
}
