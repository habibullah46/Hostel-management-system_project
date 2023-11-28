using System;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dash_Board : Form
    {
        private string text;
        private int len = 0;

        public Dash_Board()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = MessageBox.Show("Do You Want To Exit?", "Asking Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (result == "Yes")
            {
                Application.Exit();
            }
        }

        private void Dash_Board_Load(object sender, EventArgs e)
        {
            text = lbl_txt.Text;
            lbl_txt.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lbl_txt.Text = lbl_txt.Text + text[len];
                len++;
                
            }
            else
            {
                // Reset len to 0 to restart the animation
                lbl_txt.Text = null;
                len = 0;
            }
        }
    }
}
