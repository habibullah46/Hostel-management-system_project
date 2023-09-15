using Hostel_Management_System.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class Register_New_Staff : Form
    {
        public Register_New_Staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO tbl_RegistrationNewStaff VALUES('"+txt_cnic.Text+"','"+txt_name.Text+"','"+txt_fathername.Text+"','"+txt_mobile.Text+"','"+txt_registrationdate.Text+"','"+txt_dateofbirht.Text+"','"+txt_Bloodgroup.Text+"','"+txt_address.Text+"')";
            HelperClass hp = new HelperClass();
            hp.OpenCon();
            hp.NonExecuteQuery(querry);
            hp.Closecon();
            MessageBox.Show("Insert data successfully!!");
        }
    }
}
