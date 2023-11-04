using HMS2023.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Search_Staff : Form
    {
       helper hp = new helper();
        public Search_Staff()
        {
            InitializeComponent();
        }

        private void Search_Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'searchstaff.tbl_Staff' table. You can move, or remove it, as needed.
            this.tbl_StaffTableAdapter1.Fill(this.searchstaff.tbl_Staff);
           

        }

        private void cmb_searchwith_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_searchwith.Text == "Name")
            {
                txt_name.Enabled = true;
                txt_cnic.Enabled = false;
            }
            else if(cmb_searchwith.Text == "CNIC")
            {
                txt_cnic.Enabled = true;
                txt_name.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_cnic.Text == txt_cnic.Text) 
            {
               
                string querry = "SELECT * FROM tbl_Staff WHERE CNIC LIKE '%" + txt_cnic.Text + "%'";
                string conn = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    grd_searchstaf.DataSource = dt;
                }
                else
                {
                    grd_searchstaf.DataSource = null;
                }
            }
            else if(txt_name.Text == txt_name.Text)
            {
                string querry = "SELECT * FROM tbl_Staff WHERE Name LIKE '%" + txt_name.Text + "%'";
                string conn = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    grd_searchstaf.DataSource = dt;
                }
                else
                {
                    grd_searchstaf.DataSource = null;
                }
            }
           
        }
    }
}
