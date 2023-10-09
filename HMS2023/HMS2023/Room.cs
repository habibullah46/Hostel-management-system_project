using HMS2023.HelperClass;
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
       helper hp = new helper();

        public Room()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            string querry = "INSERT INTO tbl_Room VALUES('"+txt_Number.Text+"','"+txt_flour.Text+"','"+cmb_type.Text+"','"+cmb_AttachBAth.Text+"','"+txt_Rentseat.Text+"')";
            hp.OpenCon();
            hp.NonQuerryExecute(querry);
            hp.CloseCon();
            MessageBox.Show("Save Record Successfuly!!");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_flour.Clear();  
            txt_Number.Clear();
            txt_Rentseat.Clear();
            cmb_type.Items.Clear();
            cmb_AttachBAth.Items.Clear();
            txt_Number.Focus();
        }
    }
}
