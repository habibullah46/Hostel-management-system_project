using Hostel_Management_System.helper;
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
    public partial class Edit_Staff : Form
    {
        public Edit_Staff()
        {
            InitializeComponent();
        }

        private void Edit_Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet7.tbl_RegistrationNewStaff' table. You can move, or remove it, as needed.
            this.tbl_RegistrationNewStaffTableAdapter.Fill(this.hostelDbDataSet7.tbl_RegistrationNewStaff);

        }

        private void cmd_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_RegistrationNewStaff WHERE Name = '" + cmd_name.Text + "'";
            SqlConnection con = new SqlConnection(HelperClass.connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry,con );
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                txt_cnic.Text = dr["CNIC"].ToString();
                cmd_name.Text = dr["Name"].ToString();
                txt_fathername.Text = dr["FatherName"].ToString();
                txt_mobile.Text = dr["Mobile"].ToString();
                txt_registrationdate.Text = dr["DateOfRegistration"].ToString();
                txt_dateofbirht.Text = dr["DateOfBirth"].ToString();
                txt_Bloodgroup.Text = dr["BloodGroup"].ToString();
                txt_address.Text = dr["Address"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are You Sure You Want To Update The Data", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string Dquerry = "UPDATE tbl_RegistrationNewStaff SET CNIC = '"+txt_cnic.Text+"',FatherName = '"+txt_fathername.Text+"',Mobile = '"+txt_mobile.Text+"',DateOfRegistration = '"+txt_registrationdate.Text+"',DateOfBirth = '"+txt_dateofbirht.Text+"',BloodGroup = '"+txt_Bloodgroup.Text+"',Address = '"+txt_address.Text+"'WHERE Name = '"+cmd_name.Text+"'";
                HelperClass hp = new HelperClass();
                hp.OpenCon();
                hp.NonExecuteQuery(Dquerry);
                hp.Closecon();
                MessageBox.Show("Update THE DATA SUCCESSFULLY!!");
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = (TextBox)item;
                        txt.Clear();
                    }
                }

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           DialogResult dr =  MessageBox.Show("Are You Sure You Want To Delete The Data","Alert", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) 
            {
                string Dquerry = "DELETE FROM tbl_RegistrationNewStaff WHERE Name = '"+cmd_name.Text+"'";
                HelperClass hp = new HelperClass();
                hp.OpenCon();
                hp.NonExecuteQuery(Dquerry);
                hp.Closecon();
                MessageBox.Show("DELETE THE DATA SUCCESSFULLY!!");
                foreach ( var item in this.Controls)
                {
                    if(item is TextBox)
                    {
                        TextBox txt = (TextBox)item;
                        txt.Clear();
                    }
                }

            }
        }
    }
}
