using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Search_Sutudet : Form
    {
        public Search_Sutudet()
        {
            InitializeComponent();
        }

        private void Search_Sutudet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDB2023DataSet4.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.hMSDB2023DataSet4.tbl_student);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
