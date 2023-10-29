using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Student RS =  new Register_Student();
            RS.MdiParent= this;
            RS.Show();
          
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registor_new_staff RS = new Registor_new_staff();   
            RS.MdiParent= this;
            RS.Show();  
        }

        private void assignRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign_Room rm= new Assign_Room();
            rm.MdiParent= this;  
            rm.Show();
        }

        private void addVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visitor_Entry VE = new Visitor_Entry();
            VE.MdiParent= this;
            VE.Show();  
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Assign_Room rm = new Assign_Room();
            rm.MdiParent = this;
            rm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Visitor_Entry VE = new Visitor_Entry();
            VE.MdiParent = this;
            VE.Show();
        }

        private void registerRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room rm = new Room();
            rm.MdiParent = this;
            rm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Search_Sutudet SS = new Search_Sutudet();
            SS.MdiParent = this;
            SS.Show();
        }

        private void searchStduentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Sutudet ss = new Search_Sutudet();
            ss.MdiParent = this;
            ss.Show();
        }

        private void searchRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Room rm = new Search_Room();
            rm.MdiParent = this;
            rm.Show();
            
        }
    }
}
