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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Register_student std = new Register_student();
            std.MdiParent = this;
            std.Show();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_New_Staff RS = new Register_New_Staff();   
            RS.MdiParent = this;
            RS.Show();
        }

        private void registerRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room Rm = new Room();   
            Rm.MdiParent = this;
            Rm.Show();
        }

        private void addVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visitor_Entry VE = new Visitor_Entry(); 
            VE.MdiParent = this;    
            VE.Show();
        }
    }
}
