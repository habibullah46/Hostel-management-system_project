using HMS2023.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Assign_Room : Form
    {
        public Assign_Room()
        {
            InitializeComponent();
        }

        private void Assign_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDB2023DataSet3.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter.Fill(this.hMSDB2023DataSet3.tbl_Room);
            // TODO: This line of code loads data into the 'hMSDB2023DataSet2.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.hMSDB2023DataSet2.tbl_student);


        }

        private void cmb_StudentCNIC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_student WHERE  CNIC = '" + cmb_StudentCNIC.Text + "' ";
            SqlConnection con = new SqlConnection(helper.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr =  cmd.ExecuteReader();
            if (dr.Read()) 
            {
                txt_StudentName.Text = dr["Name"].ToString();
            }

           

        }

        private void cmb_RoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_Room WHERE RoomNumber = '" + cmb_RoomNo.Text + "'";
            SqlConnection con = new SqlConnection(helper.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_AvialbleSeat.Text = dr["Available_Seats"].ToString();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Querry = "INSERT INTO tbl_AssignRoom VALUES('"+cmb_StudentCNIC.Text+ "','"+txt_StudentName.Text+"','"+txt_AvialbleSeat.Text+"')";
           
            helper hp = new helper();
            hp.OpenCon();
            hp.NonQuerryExecute(Querry);
            int NumberOfSeats = Convert.ToInt32(txt_AvialbleSeat.Text);
            NumberOfSeats = NumberOfSeats - 1;
            string UpdateQerry = "UPDATE tbl_Room SET Available_Seats = '" + NumberOfSeats +"' Where RoomNumber = '" + cmb_RoomNo.Text + "'";
            hp.NonQuerryExecute(UpdateQerry);
            hp.CloseCon();
            My_Message.success("Assign Room ");

        }
    }
}
