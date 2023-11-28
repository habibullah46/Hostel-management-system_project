using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
