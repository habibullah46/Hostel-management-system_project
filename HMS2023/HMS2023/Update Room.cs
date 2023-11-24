using HMS2023.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023
{
    public partial class Update_Room : Form
    {
        ErrorProvider er = new ErrorProvider();
        public Update_Room()
        {
            InitializeComponent();
        }

        private void Update_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'udpateRoom.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter.Fill(this.udpateRoom.tbl_Room);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_Room WHERE RoomNumber='" + cmb_roomnumber.Text + "' ";
            SqlConnection con = new SqlConnection(helper.constring);
            con.Open(); 
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_flour.Text = dr["Floor"].ToString();
                cmb_type.Text = dr["Type"].ToString();
                cmb_AttachBAth.Text = dr["Attach_Bath"].ToString();
                txt_Rentseat.Text = dr["SeatRent"].ToString();
                txt_Availableseats.Text = dr["Available_Seats"].ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(errorvalidation())
            {


                try
                {
                    DialogResult d = MessageBox.Show("Do You Want To Update This Records", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        string update = "UPDATE tbl_Room SET RoomNumber='" + cmb_roomnumber.Text + "',Floor='" + txt_flour.Text + "',Type='" + cmb_type.Text + "',Attach_Bath='" + cmb_AttachBAth.Text + "',SeatRent='" + txt_Rentseat.Text + "',Available_Seats='" + txt_Availableseats.Text + "'WHERE RoomNumber='" + cmb_roomnumber.Text + "'";

                        SqlConnection con = new SqlConnection(helper.constring);
                        con.Open();
                        SqlCommand cmd = new SqlCommand(update, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update Records Successfully", "Sucessful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (var room in this.Controls)
                        {
                            if (room is TextBox)
                            {
                                TextBox t = (TextBox)room;
                                t.Clear();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in user input.\n\n\nDevelopers information: \n {ex.ToString()}");

                }
                finally
                {
                    Close();
                }

            }
            else
            {
                return;
            }
          
           
        }
        //error provider code
        private bool errorvalidation()
        {
           

            bool flag = true;
            if(string.IsNullOrEmpty(cmb_roomnumber.Text))
            {
                flag = false;
                er.SetError(cmb_roomnumber, "Enter Room number");
               
             }
            else if (string .IsNullOrEmpty(cmb_type.Text))
            { 
                flag = false;
                er.SetError(txt_flour, "Enter flour");
             }
            else if (string.IsNullOrEmpty(cmb_type.Text))
            {
                flag = false;
                er.SetError(cmb_type, "Enter Type ");
            }
            else if (string.IsNullOrEmpty (cmb_AttachBAth.Text))
            {
                flag = false;
                er.SetError(cmb_AttachBAth,"Enter AttachBath");
            }
            else if (string.IsNullOrEmpty(txt_Rentseat.Text))
            {
                flag = false;
                er.SetError(txt_Rentseat, "Enter SeatRent");
            }
            else if(string.IsNullOrEmpty(txt_Availableseats.Text)) 
            {
                flag = false;
                er.SetError(txt_Availableseats, "Enter AvailableSeat");
            }
            else
            {

                flag = true;
               er.Clear();
            }
            return flag;
           
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do You Want To Delete This Records", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_Room WHERE RoomNumber='" + cmb_roomnumber.Text + "' ";
                SqlConnection con = new SqlConnection(helper.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete  Records Successfully", "Sucessful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var delete in this.Controls)
                {
                    if(delete is TextBox)
                    {
                        TextBox t = (TextBox)delete;
                        t.Clear();
                    }
                }
            }
        }
    }
}
