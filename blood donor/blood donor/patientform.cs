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

namespace blood_donor
{
    public partial class patientform : Form
    {
        public patientform()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO tbl_patient VALUES('" + txt_cnic.Text + "','" + txt_name.Text + "','" + txt_contact.Text + "','" + cmb_bloodGroup.Text + "','" + cmb_gender.Text + "','" + txt_age.Text + "')";
            string mycon = System.Configuration.ConfigurationManager.ConnectionStrings["MYConString"].ToString();
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient record save succesffully");
        }
    }
}
