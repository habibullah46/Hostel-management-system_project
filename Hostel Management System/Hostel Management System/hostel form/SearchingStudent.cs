using Hostel_Management_System.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.hostel_form
{
    public partial class SearchingStudent : Form
    {
        public SearchingStudent()
        {
            InitializeComponent();
        }

        private void SearchingStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet2.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.hostelDbDataSet2.tbl_student);

        }

     

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (cmd_searchwith.Text == "CNIC")
            {
                SearchWithCNIC();

            }
            else if (cmd_searchwith.Text == "Name")
            {
               SearchWithName();
            }
        }

        private void cmd_searchwith_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmd_searchwith.Text=="CNIC")
            {
                txt_cnic.Enabled= true;
                txt_Name.Enabled = false;

            }
            else if(cmd_searchwith.Text=="Name")
            {
                txt_Name.Enabled= true;
                txt_cnic.Enabled = false;
            }

        }
        private void SearchWithName()
        {
            string Querry = "SELECT * FROM tbl_student WHERE Name Like '%" + txt_Name.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(Querry, HelperClass.connstring);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dg_searchstudent.DataSource= ds.Tables[0];
        }
        private void SearchWithCNIC()
        {
            string Querry = "SELECT * FROM tbl_student WHERE CNIC Like'%" + txt_cnic.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(Querry, HelperClass.connstring);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dg_searchstudent.DataSource = ds.Tables[0];
        }
   
    }
}
