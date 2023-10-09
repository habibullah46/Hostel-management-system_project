using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Room : Form
    {
       

        public Room()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["myconstring"].ToString();
            string querry = "INSERT INTO tbl_Room VALUES('"+txt_Number.Text+"','"+txt_flour.Text+"','"+cmb_type.Text+"','"+cmb_AttachBAth.Text+"','"+txt_Rentseat.Text+"')";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save Record Successfuly!!");
        }
    }
}
