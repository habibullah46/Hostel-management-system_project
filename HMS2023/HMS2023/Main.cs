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
   
            rm.Show(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Visitor_Entry VE = new Visitor_Entry();
        
            VE.Show(this);
        }

        private void registerRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room rm = new Room();
            rm.MdiParent = this;
            rm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Search_Sutudet ss = new Search_Sutudet();
            ss.Show(this);

        }

        private void searchStduentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Sutudet ss = new     Search_Sutudet();
            ss.Show(this);
        }

        private void searchRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Search_Room rm = new Search_Room();
            rm.Show(this);
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search_Staff ss = new Search_Staff();
            ss.Show(this);
        }

        private void searchStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Staff ss = new Search_Staff();
            ss.Show(this);
        }

        private void searchVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Visitor sv = new Search_Visitor();
            sv.Show(this);
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Update_Register ur = new Update_Register();
            ur.Show(this);
        }

        private void editStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Staff us = new Update_Staff();   
            us.Show(this);
        }

        private void editRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Room ur = new Update_Room(); 
            ur.Show(this);  
        }

        private void editVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Visitor uv   = new Update_Visitor(); 
            uv.Show(this);
        }
    }
}
