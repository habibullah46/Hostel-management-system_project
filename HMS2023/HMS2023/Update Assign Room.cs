using HMS2023.HelperClass;
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

namespace HMS2023
{
    public partial class Update_Assign_Room : Form
    {
        public Update_Assign_Room()
        {
            InitializeComponent();
        }

        private void Update_Assign_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDB2023DataSet8.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter1.Fill(this.hMSDB2023DataSet8.tbl_Room);
            // TODO: This line of code loads data into the 'updateAssignRoomdataset.tbl_AssignRoom' table. You can move, or remove it, as needed.
            this.tbl_AssignRoomTableAdapter.Fill(this.updateAssignRoomdataset.tbl_AssignRoom);

        }

        private void cmb_StudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_AssignRoom WHERE StudentName='"+cmb_StudentName.Text+"' ";
            SqlConnection con = new SqlConnection(helper.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                txt_StudentCnic.Text = dr["StudentCNIC"].ToString();
                cmb_RoomNo.Text = dr["RoomNumber"].ToString();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
         string result =  MessageBox.Show("Do You Want To Update This Record!","confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString();
            if(result.Equals("Yes"))
            {
                string update = "UPDATE tbl_AssignRoom SET StudentName='" + cmb_StudentName.Text + "',RoomNumber='" + cmb_RoomNo.Text + "' WHERE StudentCNIC='" + txt_StudentCnic.Text + "' ";
                SqlConnection con = new SqlConnection(helper.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Record Successfully!", "Sucessful Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            string result = MessageBox.Show("Do You Want To Delete This Record!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (result.Equals("Yes"))
            {
                string Delete = "DELETE FROM tbl_AssignRoom WHERE StudentCNIC = '"+txt_StudentCnic.Text+"'";
                SqlConnection con = new SqlConnection(helper.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(Delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Record Successfully!", "Sucessful Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
    }
    }

