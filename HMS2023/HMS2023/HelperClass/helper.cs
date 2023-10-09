using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS2023.HelperClass
{
    public class helper
    {
        public static string constring = ConfigurationManager.ConnectionStrings["myconstring"].ToString();
        SqlConnection con = new SqlConnection(constring);

        public void OpenCon()
        {
            con.Open();
        }
        public void CloseCon()
        { 
            con.Close();
        }
        public void NonQuerryExecute(string Qerry)
        {
           SqlCommand cmd = new SqlCommand(Qerry, con);
            cmd.ExecuteNonQuery();
        }


  
    }
}
