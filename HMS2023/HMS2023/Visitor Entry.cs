using HMS2023.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Visitor_Entry : Form
    {
        helper hp = new helper();
      
        public Visitor_Entry()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
          //  string constring = ConfigurationManager.ConnectionStrings["myconstring"].ToString();
           // string querry = "INSERT INTO tbl_Room VALUES('" + txt_Number.Text + "','" + txt_flour.Text + "','" + cmb_type.Text + "','" + cmb_AttachBAth.Text + "','" + txt_Rentseat.Text + "')";
            string querry = "INSERT INTO tbl_VisitorEntry  VALUES('" + cmb_Visitor_cnic.Text+"','"+txt_Visitor_name.Text+"','"+txt_timedate.Text+"','"+txt_VRelation.Text+"','"+cmd_studentCNIC.Text+"','"+txt_Studentname.Text+"')";
            hp.OpenCon();
            hp.NonQuerryExecute(querry);
            hp.CloseCon();
            My_Message.success("Visitor Entry");
        }
    }
}
