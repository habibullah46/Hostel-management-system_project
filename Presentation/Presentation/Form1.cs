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

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Pindi = "INSERT INTO Pindi VALUES('" + txt_cnic.Text + "','" + txt_name.Text + "','" + txt_dob.Value + "','" + cmb_gender.Text + "','" + cmb_address.Text + "','" + txt_email.Text + "')";
            string Kotli = "INSERT INTO kolti VALUES('"+txt_cnic.Text+"','"+txt_name.Text+"','"+txt_dob.Value+"','"+cmb_gender.Text+"','"+cmb_address.Text+"','"+txt_email.Text+"')";
            string mainQuerry = "INSERT INTO mainform VALUES('" + txt_cnic.Text + "','" + txt_name.Text + "','" + txt_dob.Value + "','" + cmb_gender.Text + "','" + cmb_address.Text + "','" + txt_email.Text + "')";
            string mirpure = "INSERT INTO mirpure VALUES('" + txt_cnic.Text + "','" + txt_name.Text + "','" + txt_dob.Value + "','" + cmb_gender.Text + "','" + cmb_address.Text + "','" + txt_email.Text + "')";
            // string mycon = System.Configuration.ConfigurationManager.ConnectionStrings["MYConString"].ToString();
            string mycon = System.Configuration.ConfigurationManager.ConnectionStrings["MYConstring"].ToString();
            if (cmb_address.Text == "Kotli")
            {
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand(Kotli, con);
                cmd.ExecuteNonQuery();

                SqlConnection Con = new SqlConnection(mycon);
                Con.Open();
                SqlCommand Cmd = new SqlCommand(mainQuerry, Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Save successfully!!","Successfull Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
            else if (cmb_address.Text == "Pindi")
            {
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand(Pindi, con);
                cmd.ExecuteNonQuery();
                SqlConnection Con = new SqlConnection(mycon);
                Con.Open();
                SqlCommand Cmd = new SqlCommand(mainQuerry, Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Save successfully!!", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmb_address.Text == "Mirpure")
            {
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand(mirpure, con);
                cmd.ExecuteNonQuery();
                SqlConnection Con = new SqlConnection(mycon);
                Con.Open();
                SqlCommand Cmd = new SqlCommand(mainQuerry, Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Save successfully!!", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'presentationDataSet8.mainform' table. You can move, or remove it, as needed.
            this.mainformTableAdapter5.Fill(this.presentationDataSet8.mainform);
            // TODO: This line of code loads data into the 'presentationDataSet7.mainform' table. You can move, or remove it, as needed.
            this.mainformTableAdapter4.Fill(this.presentationDataSet7.mainform);
            // TODO: This line of code loads data into the 'presentationDataSet5.mainform' table. You can move, or remove it, as needed.
            this.mainformTableAdapter3.Fill(this.presentationDataSet5.mainform);


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           
                txt_cnic.Clear();
                txt_name.Clear();
                txt_email.Clear();
 
                txt_cnic.Focus();
           
          
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        }
    }
}
