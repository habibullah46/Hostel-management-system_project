using Hostel_Management_System.helper;
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
using System.Windows.Forms;

namespace Hostel_Management_System.hostel_form
{
    public partial class Edit_Visitor : Form
    {
        public Edit_Visitor()
        {
            InitializeComponent();
        }

        private void cmd_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Querry = "SELECT * FROM tbl_VisitorEntry WHERE Name = '"+cmd_name.Text+"'";
            SqlConnection con = new SqlConnection(HelperClass.connstring);
            con.Open();
           SqlCommand cmd = new SqlCommand(Querry,con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read()) 
            {
                txt_CNIC.Text = dr["CNIC"].ToString();
                cmd_name.Text = dr["Name"].ToString();
               cmd_Visittime.Text = dr["VisitTime"].ToString();
                txt_VisitRelation.Text = dr["Relation"].ToString();
                txt_Sname.Text = dr["VisitingTo"].ToString();
                txt_SCNIC.Text = dr["VsitingToCNIC"].ToString();
            }
        }

        private void Edit_Visitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet6.tbl_VisitorEntry' table. You can move, or remove it, as needed.
            this.tbl_VisitorEntryTableAdapter.Fill(this.hostelDbDataSet6.tbl_VisitorEntry);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
          DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete it","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) 
            {
                string Querry = "DELETE FROM tbl_VisitorEntry WHERE Name = '" + cmd_name.Text + "'";
                HelperClass hp = new HelperClass();
                hp.OpenCon();
                hp.NonExecuteQuery(Querry);
                hp.Closecon();
                MessageBox.Show("Delete Data Successfully!!");
                foreach (var item in this.Controls)
                {
                    if(item is TextBox)
                    {
                        TextBox tb = (TextBox)item;
                        tb.Clear();
                    }

                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are You Sure You Want To Update it", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string Querry = "UPDATE tbl_VisitorEntry SET VisitTime = '" + cmd_Visittime.Text+ "',Relation = '"+txt_VisitRelation.Text+ "',VisitingTo = '"+txt_Sname.Text+"',VsitingToCNIC = '"+txt_SCNIC.Text+"'  WHERE Name = '"+cmd_name.Text+"'  ";
                HelperClass hp = new HelperClass();
                hp.OpenCon();
                hp.NonExecuteQuery(Querry);
                hp.Closecon();
                MessageBox.Show("Update Data Successfully!!");
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tb = (TextBox)item;
                        tb.Clear();
                    }

                }
            }

        }
    }
}
