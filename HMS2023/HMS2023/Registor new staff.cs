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
    public partial class Registor_new_staff : Form
    {
        public Registor_new_staff()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO tbl_Staff VALUES('" + txt_CNIC.Text+"','"+txt_Name.Text+"','"+txt_FatherName.Text+"','"+txt_mobile.Text+"','"+txt_dateOFREG.Text+"','"+txt_dateOFBirth.Text+"','"+txt_BloodGroup.Text+"','"+txt_address.Text+"')";
            SqlConnection con = new SqlConnection(helper.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            My_Message.success("Register New Staff ");
        }
    }
}
