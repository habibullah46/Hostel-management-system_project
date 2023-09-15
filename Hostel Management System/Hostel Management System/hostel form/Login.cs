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

namespace Hostel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void chk_password_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_password.Checked)
            {
                txt_Password.UseSystemPasswordChar= false;
            }
            else if(chk_password.CheckState==CheckState.Unchecked)
            {
                txt_Password.UseSystemPasswordChar= true;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string Qerry = "SELECT * FROM tbl_login WHERE UserName='" +txt_UserName.Text+ "' AND Password='"+txt_Password.Text+"'";
            SqlConnection con = new SqlConnection(HelperClass.connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Qerry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                this.Hide();
                main Main = new main();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Invalid UserName OR Password","information",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);
                txt_Password.Clear();
                txt_UserName.Clear();
                txt_UserName.Focus();
            }
        }
    }
}
