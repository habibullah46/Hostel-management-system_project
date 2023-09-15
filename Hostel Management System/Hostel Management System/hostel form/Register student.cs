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
    public partial class Register_student : Form
    {
        HelperClass HP = new HelperClass();
        public Register_student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO tbl_student VALUES('"+txt_cnic.Text+"', '"+txt_name.Text+"','"+txt_fathername.Text+"','"+txt_address.Text+"','"+txt_mobile.Text+"','"+txt_educationalInstitute.Text+"','"+txt_class.Text+"','"+txt_registrationdate.Text+"','"+txt_dateofbirht.Text+"','"+txt_Bloodgroup.Text+"','"+txt_guardannumber.Text+"','"+txt_GuardianName.Text+"')";
            HP.OpenCon();
            HP.NonExecuteQuery(querry);
            HP.Closecon();
            MessageBox.Show("data save successfully!!");
        }
    }
}
