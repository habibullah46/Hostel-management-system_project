using HMS2023.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Search_Sutudet : Form
    {
        public Search_Sutudet()
        {
            InitializeComponent();
        }
           helper hp = new helper();
        private void Search_Sutudet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDB2023DataSet4.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.hMSDB2023DataSet4.tbl_student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_cnic.Text == txt_cnic.Text)
            {
                string querry = "SELECT * FROM tbl_student WHERE CNIC LIKE '%" + txt_cnic.Text + "%'";

                string connection = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
                SqlConnection con = new SqlConnection(connection);
                
                con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    grd_view.DataSource = dt;
                }
                else
                {
                    grd_view.DataSource = null;
                }
            }
            else if (txt_name.Text == txt_name.Text)
            {
                string querry = "SELECT * FROM tbl_student WHERE Name LIKE '%" + txt_name.Text + "%'";

                string connection = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    grd_view.DataSource = dt;
                }
                else
                {
                    grd_view.DataSource = null;
                }
            }

           

        }

        private void cnb_searchwith_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_searchwith.Text == "Name")
            {
               txt_name.Enabled = true;
                txt_cnic.Enabled = false;
            }
            else if (cmb_searchwith.Text == "CNIC")
            {
                txt_name.Enabled= false;
                txt_cnic.Enabled = true;
            }
        }
    }
}
