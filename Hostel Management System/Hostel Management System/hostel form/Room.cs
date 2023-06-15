using Hostel_Management_System.helper;
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

namespace Hostel_Management_System
{
    public partial class Room : Form
    {
        HelperClass HPC = new HelperClass();

        public Room()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            string querry = "INSERT INTO tbl_room VALUES ('"+txt_numberr.Text+"', '"+cmd_florr.Text+"', '"+cmd_type.Text+"','"+cmd_washroom.Text+"','"+txt_seatRent.Text+"')";
            HPC.OpenCon();
         
            HPC.NonExecuteQuery(querry);
            HPC.Closecon();
            MessageBox.Show("Successfullly save data!!");
        }
    }
}
