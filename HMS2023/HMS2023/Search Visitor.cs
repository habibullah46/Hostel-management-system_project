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

namespace HMS2023
{
    public partial class Search_Visitor : Form
    {
        public Search_Visitor()
        {
            InitializeComponent();
        }

        private void Search_Visitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDB2023DataSet13.tbl_VisitorEntry' table. You can move, or remove it, as needed.
            this.tbl_VisitorEntryTableAdapter.Fill(this.hMSDB2023DataSet13.tbl_VisitorEntry);
           
        }

        private void cmb_searchwith_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_searchwith.Text=="CNIC")
            {
                txt_scnic.Enabled = true;
                txt_sname.Enabled = false;
            }
            else if (cmb_searchwith.Text=="Name")
            {
                txt_sname.Enabled= true;
                txt_scnic.Enabled= false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)

        {
           if(cmb_searchwith.Text=="CNIC")
            {
                string Querry = "SELECT * FROM tbl_VisitorEntry WHERE CNIC LIKE'%" + txt_scnic.Text + "%' ";
                string conn = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlCommand cmd = new SqlCommand(Querry, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    grd_searchvisitor.DataSource = dt;
                }
                else
                {
                    grd_searchvisitor.DataSource = null;
                }
            }
           else if(cmb_searchwith.Text=="Name")
            {
                string Querry = "SELECT * FROM tbl_VisitorEntry WHERE Name LIKE'%" + txt_sname.Text + "%' ";
                string conn = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlCommand cmd = new SqlCommand(Querry, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if(dt.Rows.Count > 0)
                {
                    grd_searchvisitor.DataSource = dt;

                }
                else
                {
                    grd_searchvisitor.DataSource = null;
                }

            }
           
        }
    }
}
