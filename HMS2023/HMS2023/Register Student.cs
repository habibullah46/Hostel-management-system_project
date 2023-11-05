using HMS2023.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Register_Student : Form
    {
        helper hp = new helper();
        public Register_Student()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Querry = "INSERT INTO tbl_student VALUES('"+txt_CNIC.Text+"','"+txt_Name.Text+"','"+txt_FatherName.Text+"','"+txt_address.Text+"','"+txt_mobile.Text+"','"+txt_Institute.Text+"','"+txt_class.Text+ "','"+txt_dateOFREG.Text+"','"+txt_dateOFBirth.Text+"','"+txt_BloodGroup.Text+"', '"+ txt_guardianName.Text+"','"+txt_GuardianNumber.Text+"')";
            hp.OpenCon();
            hp.NonQuerryExecute(Querry);
            hp.CloseCon();
            My_Message.success("Register Student ");
        }
    }
}
