using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.hostel_form
{
    public partial class Search_Visitor : Form
    {
        public Search_Visitor()
        {
            InitializeComponent();
        }
        

        private void Search_Visitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet3.tbl_VisitorEntry' table. You can move, or remove it, as needed.
            this.tbl_VisitorEntryTableAdapter.Fill(this.hostelDbDataSet3.tbl_VisitorEntry);

        }
        public static string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["MYConString"].ToString();
        private void button1_Click(object sender, EventArgs e)
        {
            string Querry = "SELECT * FROM tbl_VisitorEntry WHERE Name Like'%"+txt_name.Text+"%'";
            SqlDataAdapter da = new SqlDataAdapter(Querry, connstring );
            DataSet ds = new DataSet();
            da.Fill(ds);
            gd_seachstudent.DataSource = ds.Tables[0];
        }
    }
}
