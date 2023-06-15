using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hostel_Management_System.helper
{
    public  class HelperClass
    {
       

        public static  string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["MYConString"].ToString();
        static SqlConnection con = new SqlConnection(connstring);
        public  void OpenCon()
        {
            con.Open();
        }
        public  void Closecon() 
        {
            con.Close();
        }
        public   void  NonExecuteQuery( string querry)
        {
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
        }
    }
}
