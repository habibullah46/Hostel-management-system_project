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
    public partial class Password_setting : Form
    {
        private int id;
        helper hp = new helper();
        public Password_setting()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == txt_Cpassword.Text)
            {

                string querry = "INSERT INTO tbl_login VALUES('" + txt_username.Text + "','" + txt_password.Text + "')";
                //  string conn = System.Configuration.ConfigurationManager.ConnectionStrings[""].ToString();
                hp.OpenCon();
                hp.NonQuerryExecute(querry);
                MessageBox.Show("Register New User Successfully!","Message Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password and confirm Password is not Mataching!!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Cpassword.Clear();
            txt_password.Clear();   
            txt_username.Clear();
            txt_username.Focus();
        }

        private void Password_setting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'changepassworddataset.tbl_login' table. You can move, or remove it, as needed.
            this.tbl_loginTableAdapter.Fill(this.changepassworddataset.tbl_login);

        }

        private void cmb_username_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_login WHERE Username ='" + cmb_Cusername.Text+ "' ";
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                txt_password.Text =  dr["Password"].ToString();

            }
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_Cpassword.Text.Equals(txt_password.Text))
            {
                string UpdateQuerry = "UPDATE tbl_login SET Password = '" + txt_password.Text + "'Where Id='" + id + "'";
                SqlConnection con = new SqlConnection(helper.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(UpdateQuerry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("UpDate Record Sucessfully!!");

            }
            else
            {
                MessageBox.Show("Password and confirm Password is not Mataching!!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
    }
}
