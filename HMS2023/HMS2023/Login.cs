using HMS2023.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void chk_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_showpass.CheckState == CheckState.Checked)
            {
                txt_password.UseSystemPasswordChar= false;
            }
            else if (chk_showpass.CheckState == CheckState.Unchecked)
            {
                txt_password.UseSystemPasswordChar= true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_login WHERE Username = '"+txt_Username.Text+ "' AND Password = '"+txt_password.Text+"' ";
            SqlConnection con = new SqlConnection(helper.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
             SqlDataReader dr =  cmd.ExecuteReader();
            if (dr.Read()) 
            { 
                this.Hide();
                Main m = new Main();
                m.Show();
            }
            else
            {
                MessageBox.Show("User name or password or not correct");
                txt_password.Clear();   
                txt_Username.Clear();
                txt_Username.Focus();
            }
        }
    }
}
