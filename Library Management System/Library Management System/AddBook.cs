using Library_Management_System.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO AddBook VALUES('" + txt_bookname.Text + "','" + txt_bookauthourname.Text + "','" + txt_bookpublicaton.Text + "','" + txt_datetime.Text + "','" + txt_bookprice.Text + "','" + txt_bookquantity.Text + "')";
            helper hp = new helper();
            hp.OpenCon();
            hp.NonexecuteQuerry(querry);
            MessageBox.Show("Add Book Successfully ");
            hp.CloseCon();

            txt_bookname.Clear();
            txt_bookauthourname.Clear();
            txt_bookpublicaton.Clear();
            txt_bookprice.Clear();
            txt_bookquantity.Clear();
            txt_bookname.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_bookname.Clear();
            txt_bookauthourname.Clear();
            txt_bookpublicaton.Clear();
            txt_bookprice.Clear();
            txt_bookquantity.Clear();
            txt_bookname.Focus();
        }
    }
}
