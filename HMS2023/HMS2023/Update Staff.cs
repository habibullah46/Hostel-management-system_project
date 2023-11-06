using HMS2023.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Update_Staff : Form
    {
        public Update_Staff()
        {
            InitializeComponent();
        }

        private void Update_Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDB2023DataSet10.tbl_Staff' table. You can move, or remove it, as needed.
            this.tbl_StaffTableAdapter1.Fill(this.hMSDB2023DataSet10.tbl_Staff);
            // TODO: This line of code loads data into the 'updatestaff.tbl_Staff' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'hMSDB2023DataSet9.tbl_Staff' table. You can move, or remove it, as needed.
           

        }

      

        private void cmb_name_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_Staff WHERE Name = '"+cmb_name.Text+"'";
            SqlConnection con = new SqlConnection(helper.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_CNIC.Text = dr["CNIC"].ToString();
                cmb_name.Text = dr["Name"].ToString();
                txt_FatherName.Text = dr["FatherName"].ToString();
                txt_mobile.Text = dr["Mobile"].ToString();
                txt_dateOFREG.Text = dr["DateOfReg"].ToString();
                txt_dateOFBirth.Text = dr["DateOfBirth"].ToString() ;
                txt_BloodGroup.Text = dr["BloodGroup"].ToString();
                txt_address.Text = dr["Address"].ToString();


            }

        }

        private void btn_udpate_Click(object sender, EventArgs e)
        { 
           DialogResult Result =  MessageBox.Show("Do You Want To Update This Record?","confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(Result == DialogResult.Yes) 
            {
                string Update = "UPDATE tbl_Staff SET Name='" + cmb_name.Text + "',CNIC='" + txt_CNIC.Enabled + "',FatherName='" + txt_FatherName.Text + "',Mobile='" + txt_mobile.Text + "',DateOfReg='" + txt_dateOFREG.Text + "',DateOfBirth='" + txt_dateOFBirth.Text + "',BloodGroup='" + txt_BloodGroup.Text + "',Address='" + txt_address.Text + "' WHERE CNIC='"+txt_CNIC.Text+"' ";
                SqlConnection con = new SqlConnection(helper.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(Update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Update Sucessfully ","Sucessfull Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                foreach (var item in this.Controls)
                {
                    if(item is TextBox)
                    {
                        TextBox ttb = (TextBox)item;
                        ttb.Clear();
;                    } 
                }
            }

           
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want To Delete This Record", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string Deletequerry = "DELETE FROM tbl_Staff WHERE CNIC='" + txt_CNIC.Text + "'";
                SqlConnection con = new SqlConnection(helper.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(Deletequerry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Records Sucessfully","Sucessful Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                foreach (var item in this.Controls)
                {

                    if(item is TextBox)
                    {
                        TextBox ttb = (TextBox)item;
                        ttb.Clear();
                    }
                }
            }
        }
    }
}
