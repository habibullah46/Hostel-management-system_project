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

namespace Library_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if(txt_username.Text == "UserName")
            {
                txt_username.Clear();
            }
          
        }

        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            if(txt_password.Text =="Password")
            {
                txt_password.Clear();
                //txt_password.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close ();  
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbox.CheckState==CheckState.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else if (chkbox.CheckState==CheckState.Unchecked)
            {
                txt_password.UseSystemPasswordChar= true;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Habibul88592480/status/1721750203303133657?t=2WkrqMz8lymd9G9-nfMjhQ&s=19");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void pbinsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/habib_khalqi?igshid=MmVlMjlkMTBhMg==");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM Login WHERE UserName='" + txt_username.Text + "' AND Password='"+txt_password.Text+"'";
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["myconnecton"].ToString();

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Dash_Board db = new Dash_Board();
                db.Show(this);
            }
            else
            {
                MessageBox.Show("UserName or Password not Correct Try Again!");
                txt_password.Clear();
                txt_username.Clear();
                txt_username.Focus();
            }
        }
    }
}
