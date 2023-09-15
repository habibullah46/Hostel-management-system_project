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
    public partial class Search_Staff : Form
    {
        public Search_Staff()
        {
            InitializeComponent();
        }
        public static string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["MYConString"].ToString();

        private void Search_Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet4.tbl_RegistrationNewStaff' table. You can move, or remove it, as needed.
            this.tbl_RegistrationNewStaffTableAdapter.Fill(this.hostelDbDataSet4.tbl_RegistrationNewStaff);

        }

        private void btn_searchstaff_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_RegistrationNewStaff WHERE Name = '" + txt_name.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(querry, connstring);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gd_searchstaff.DataSource = ds.Tables[0];
        }
    }
}
