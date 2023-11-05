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
    public partial class Update_Register : Form
    {
        public Update_Register()
        {
            InitializeComponent();
        }

        private void Update_Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'updateRegister.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.updateRegister.tbl_student);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_student WHERE Name ='"+cmb_name.Text+"'";
            SqlConnection con = new SqlConnection(helper.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry,con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_CNIC.Text = dr["CNIC"].ToString();
                txt_FatherName.Text = dr["FatherName"].ToString();
                txt_address.Text = dr["Address"].ToString();
                txt_mobile.Text = dr["Mobile"].ToString() ;
                txt_Institute.Text = dr["Institute"].ToString();
                txt_class.Text = dr["Class"].ToString();
                txt_dateOFBirth.Text = dr["DOB"].ToString();
                txt_BloodGroup.Text = dr["BloodGroup"].ToString();
                txt_guardianName.Text = dr["GuardianName"].ToString();
                txt_GuardianNumber.Text = dr["Guardian_Number"].ToString();
                txt_dateOFREG.Text = dr["DateOfReg"].ToString();

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            
            string Result = MessageBox.Show("Do You Want To Delete This Record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (Result.Equals("Yes"))
            {
                string Delete = "DELETE FROM tbl_student WHERE Name ='" + cmb_name.Text + "' ";
                SqlConnection con = new SqlConnection(helper.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(Delete , con );
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Record Successfully", "Message Sucessfully ", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();

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
