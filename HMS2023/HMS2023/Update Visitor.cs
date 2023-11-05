using HMS2023.HelperClass;
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
     
    public partial class Update_Visitor : Form
    {
        public Update_Visitor()
        {
            InitializeComponent();
        }

        private void cmb_Visitor_cnic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_VisitorEntry WHERE Name = '" + cmb_VisitorName.Text + "'";
            SqlConnection con = new SqlConnection(helper.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd .ExecuteReader ();
            if(dr.Read())
            {
                txt_VisitorCnic.Text = dr["CNIC"].ToString();
                 cmb_VisitorName.Text= dr["Name"].ToString();
                txt_timedate.Text = dr["VisitTime"].ToString();
                txt_VRelation.Text = dr["Relation"].ToString();
                txt_Studentname.Text = dr["VisitingName"].ToString();
                cmb_studentCNIC.Text = dr["VisitingTo_CNIC"].ToString();
            }
        }

        private void Update_Visitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDB2023DataSet7.tbl_VisitorEntry' table. You can move, or remove it, as needed.
            this.tbl_VisitorEntryTableAdapter1.Fill(this.hMSDB2023DataSet7.tbl_VisitorEntry);
            // TODO: This line of code loads data into the 'updatevisitor.tbl_VisitorEntry' table. You can move, or remove it, as needed.
            this.tbl_VisitorEntryTableAdapter.Fill(this.updatevisitor.tbl_VisitorEntry);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Result = MessageBox.Show("Do You Want To Update This Record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
           if(Result.Equals("Yes"))
            {
                string UpdateQuerry = "UPDATE tbl_VisitorEntry SET  CNIC = '" + txt_VisitorCnic.Text + "', Name= '" + cmb_VisitorName.Text + "',VisitTime='" + txt_timedate.Text + "',Relation='" + txt_VRelation.Text + "',VisitingTo_CNIC='" + cmb_studentCNIC.Text + "',VisitingName='" + txt_Studentname.Text + "' Where   CNIC = '" + txt_VisitorCnic.Text + "'";
                SqlConnection con = new SqlConnection(helper.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(UpdateQuerry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Record Sucessfully.","Message Sucessfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
          string Result  =  MessageBox.Show("Do You Want To Delete This Record?","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning).ToString();
           if(Result.Equals("Yes"))
           {
                string Querry = "DELETE FROM tbl_VisitorEntry WHERE Name = '" + cmb_VisitorName.Text + "' ";
                SqlConnection con = new SqlConnection(helper.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(Querry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Record Sucessfully!","Sucessfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
    }
}
