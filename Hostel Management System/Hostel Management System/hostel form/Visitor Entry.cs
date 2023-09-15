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
    public partial class Visitor_Entry : Form
    {
        HelperClass HP = new HelperClass();
       
        public Visitor_Entry()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Vquerry = "INSERT INTO tbl_VisitorEntry VALUES('"+txt_CNIC.Text+"','"+txt_VName.Text+"','"+cmd_Visittime.Text+"','"+txt_VisitRelation.Text+"','"+txt_Sname.Text+"','"+txt_SCNIC.Text+"')";
            HP.OpenCon();
            HP.NonExecuteQuery(Vquerry);
            HP.Closecon();
            MessageBox.Show("Data Save successfully !!");
        }
    }
}
