using Hostel_Management_System.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class Assign_Room : Form
    {
        public Assign_Room()
        {
            InitializeComponent();
        }

        private void Assign_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet1.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter.Fill(this.hostelDbDataSet1.tbl_room);
            // TODO: This line of code loads data into the 'hostelDbDataSet.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.hostelDbDataSet.tbl_student);

        }

    //    string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["MYConString"].ToString();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_student WHERE CNIC='" + cmd_studentCnic.Text + "' ";
            SqlConnection con = new SqlConnection(HelperClass.connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry,con);
            SqlDataReader dr =  cmd.ExecuteReader();
            if (dr.Read()) 
            {
                txt_StudentNmae.Text = dr["Name"].ToString();
            }
           
        }

        private void cmd_RoomNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_room WHERE RoomNumber = '"+cmd_RoomNO.Text+"'";
            SqlConnection con = new SqlConnection(HelperClass.connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_AvailableSeats.Text = dr["AvailableSeats"].ToString();
            }
        }

        HelperClass hp = new HelperClass();
        private void btn_Assign_Click(object sender, EventArgs e)
        {
            if (errorvalidation())
            {
                return;
            }
            else
            {
                //string UpdateQuerry = "UPDATE tbl_room SET AvailableSeats='" +NumberOfSeats+ "' WHERE RoomNumber = '" + cmd_RoomNO.Text + "'";
                string Querry = "INSERT INTO tbl_AssignRoom VALUES('" + cmd_studentCnic.Text + "','" + txt_StudentNmae.Text + "','" + cmd_RoomNO.Text + "')";
                try
                {
                    int NumberOfSeats;

                    hp.OpenCon();
                    hp.NonExecuteQuery(Querry);
                    NumberOfSeats = Convert.ToInt32(txt_AvailableSeats.Text);
                    NumberOfSeats = NumberOfSeats - 1;
                    hp.NonExecuteQuery("UPDATE tbl_room SET AvailableSeats='" + NumberOfSeats + "' WHERE RoomNumber = '" + cmd_RoomNO.Text + "'");
                    hp.Closecon();
                    MessageBox.Show("AssignRoom Successfully!!");
                }
                catch(Exception ex) 
                
                { 
                    MessageBox.Show($"Error in user input.\n\n\nDevelopers information: \n {ex.ToString()}");
                }
                finally
                {
                    hp.Closecon();
                }
                }
          
        }
        private bool errorvalidation()
        {
            bool flag = false;
            if (string.IsNullOrEmpty(cmd_studentCnic.Text))
            {
                flag = true;
                errorProvider1.SetError(cmd_studentCnic, "Please Enter Student CNIC");
            }
            else if(string.IsNullOrEmpty(txt_StudentNmae.Text))
            {
                flag = true;
                errorProvider1.SetError(txt_StudentNmae, "Please Enter Student Name");
            }
            else if(string.IsNullOrEmpty(cmd_RoomNO.Text))
            {
                flag = true;
                errorProvider1.SetError(cmd_RoomNO, "Please Enter Room Number");
            }
            else if(string.IsNullOrEmpty(txt_AvailableSeats.Text))
            {
                flag = true;
                errorProvider1.SetError(txt_AvailableSeats, "Please Enter AvailableSeats");
            }
            else
            {
                flag = false;
                errorProvider1.Clear();
            }
            return flag;
        }
    }
}
