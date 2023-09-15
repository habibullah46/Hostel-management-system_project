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
    public partial class Edit_Register_Student : Form
    {
        public Edit_Register_Student()
        {
            InitializeComponent();
        }

        private void Edit_Register_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet8.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.hostelDbDataSet8.tbl_student);

        }

        private void cmd_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_student WHERE Name = '"+cmd_name.Text+"'";
            SqlConnection con = new SqlConnection(HelperClass.connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                txt_cnic.Text = dr["CNIC"].ToString();
                cmd_name.Text = dr["Name"].ToString();
                txt_fathername.Text = dr["FatherName"].ToString();
                txt_address.Text = dr["Address"].ToString();
                txt_mobile.Text = dr["Mobile"].ToString();
                txt_educationalInstitute.Text = dr["Institute"].ToString();
                txt_class.Text = dr["Class"].ToString();
                txt_registrationdate.Text = dr["DateOfReg"].ToString();
                txt_dateofbirht.Text = dr["DOB"].ToString();
                txt_Bloodgroup.Text = dr["BloodGroup"].ToString();
                txt_guardannumber.Text = dr["GuardianNumber"].ToString();
                txt_GuardianName.Text = dr["GuardianName"].ToString();
                    }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           DialogResult dr =  MessageBox.Show("Are You Sure You Want To Delete The Data","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
           if (dr == DialogResult.Yes)
            {
                string Querry = "DELETE FROM tbl_student WHERE Name ='" + cmd_name.Text + "' ";
                HelperClass hp = new HelperClass();
                hp.OpenCon();
                hp.NonExecuteQuery(Querry);
                hp.Closecon();
                MessageBox.Show("Delete The Data Successfully!!");
                foreach (var item in this.Controls)
                {
                    if(item is TextBox)
                    {
                        TextBox    txt = (TextBox)item;
                        txt.Clear();
                    }

                }


            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Update The Data", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string Querry = " UPDATE  tbl_student SET CNIC = '"+txt_cnic.Text+"', FatherName = '"+txt_fathername.Text+"',Address = '"+txt_address.Text+"',Mobile = '"+txt_mobile.Text+ "',Institute = '"+txt_educationalInstitute.Text+"',Class = '"+txt_class.Text+ "',DateOfReg = '"+txt_registrationdate.Text+"',DOB = '"+txt_dateofbirht.Text+"',BloodGroup = '"+txt_Bloodgroup.Text+ "',GuardianNumber = '"+txt_guardannumber.Text+ "',GuardianName = '"+txt_GuardianName.Text+"' WHERE Name = '"+cmd_name.Text+"'";

                HelperClass hp = new HelperClass();
                hp.OpenCon();
                hp.NonExecuteQuery(Querry);
                hp.Closecon();
                MessageBox.Show("Udated Successfully!!");

                foreach (var item in this.Controls)
                {
                    if( item is TextBox)
                    {
                        TextBox txt = (TextBox)item;
                        txt.Clear();
                    }

                }


            }
        }
    }
}
