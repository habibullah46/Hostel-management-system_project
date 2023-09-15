using Hostel_Management_System.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.hostel_form
{
    public partial class Change_Password : Form
    {
        int id;
        public Change_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (errorvalidation())
            {
                return;

            }
            else
            {
                string querry = "INSERT INTO tbl_login VALUES('" + txt_UserName.Text + "','" + txt_Password.Text + "')";
                HelperClass hp = new HelperClass();
                try
                {
                    if (txt_Password.Text == txt_confirmPassword.Text)
                    {

                        
                        hp.OpenCon();
                        hp.NonExecuteQuery(querry);
                        hp.Closecon();
                        MessageBox.Show("Save Successfully!!");
                        txt_confirmPassword.Clear();
                        txt_Password.Clear();
                        txt_UserName.Clear();
                        txt_Password.Focus();
                    }


                    else
                    {
                        MessageBox.Show("Password and confirm Password not mataching");
                        txt_confirmPassword.Clear();
                        txt_Password.Clear();
                        txt_Password.Focus();
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error in user input.\n\n\n Developers information:\n{ex.ToString()}");
                }
                finally
                {
                    hp.Closecon();
                }
            }
        }
        private bool  errorvalidation()
        {
            bool flag = false;
            if (string.IsNullOrEmpty(txt_UserName.Text))
            {
                flag = true;
                errorProvider1.SetError(txt_UserName, "Please enter User Name");
                
            }
            else if(string.IsNullOrEmpty(txt_Password.Text)) 
            {
                flag = true;
                errorProvider1.SetError(txt_Password, "Please Enter Password");
            }
            else if(string.IsNullOrEmpty(txt_confirmPassword.Text))
            {
                flag = true;
                errorProvider1.SetError(txt_confirmPassword, "Please Enter Confirm Password");
            }
            else
            {
                flag = false;
                errorProvider1.Clear();
            }
            return flag;
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet5.tbl_login' table. You can move, or remove it, as needed.
            this.tbl_loginTableAdapter.Fill(this.hostelDbDataSet5.tbl_login);

        }

        private void cmd_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string UpdateQuerry = "SELECT * FROM tbl_login where UserName = '" + txt_UserName.Text + "'";
            SqlConnection con = new SqlConnection(HelperClass.connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(UpdateQuerry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                 id = Convert.ToInt32(dr["Id"].ToString());
                txt_Password.Text = txt_confirmPassword.Text = dr["Password"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Errorvalidation())
            {
                return;
            }
            else
            {
                string querry = "UPDATE tbl_login SET Password = '" + txt_Password.Text + "'Where Id = '" + id + "'";
                HelperClass hp = new HelperClass();
                try
                {
                    if (txt_Password.Text.Equals(txt_confirmPassword.Text))
                    {


                        hp.OpenCon();
                        hp.NonExecuteQuery(querry);
                        hp.Closecon();
                        MessageBox.Show("Change Password Sucessfully");

                    }

                    else
                    {
                        MessageBox.Show("New Password and Confirm Password Not Matching Please Try Again Letter!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in user input.\n\n\nDeveloper information:\n{ex.ToString()}");
                }
                finally
                {
                    hp.Closecon();
                }
            }
        }
      private   bool Errorvalidation()
        {
            bool flag = false;
            if(string.IsNullOrEmpty(txt_Password.Text))
            {
                flag = true;
                errorProvider1.SetError(txt_Password, "Please Enter Password");
            }
            else if(string.IsNullOrEmpty(txt_confirmPassword.Text))
            {
                flag = true;
                errorProvider1.SetError(txt_confirmPassword, "Please Enter confirm password");
            }
            else
            {
                flag = false;
                errorProvider1.Clear();
            }
            return flag;
        }
    }
}
