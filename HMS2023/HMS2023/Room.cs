using HMS2023.HelperClass;
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
using System.Xml.Serialization;

namespace HMS2023
{
    public partial class Room : Form
    {
       helper hp = new helper();

        public Room()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(Errorvalidation())
            {
                return;
            }
            else
            {
                string querry = "INSERT INTO tbl_Room VALUES('" + txt_Number.Text + "','" + txt_flour.Text + "','" + cmb_type.Text + "','" + cmb_AttachBAth.Text + "','" + txt_Rentseat.Text + "','" + txt_Availableseats.Text + "')";

                try
                {
                    hp.OpenCon();
                    hp.NonQuerryExecute(querry);
                    hp.CloseCon();
                    My_Message.success("Room");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in user input.\n\n\nDevelopers information: \n {ex.ToString()}");
                }
                finally { hp.CloseCon(); }
              

            }
            foreach (var room in this.Controls)
            {
                if(room is TextBox)
                {
                    TextBox tb = (TextBox)room;
                    tb.Clear();
                }
            }

        }
        private bool Errorvalidation()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            bool flag = false;
            if(string.IsNullOrEmpty(txt_Number.Text))
            {
                flag = true;
                errorProvider.SetError(txt_Number, "Enter RoomNumber");
            }
            else if(string.IsNullOrEmpty(txt_flour.Text))
            {
                flag = true;
                errorProvider.SetError(txt_flour,"Enter Flour");
            }
            else if (string.IsNullOrEmpty(cmb_type.Text))
            {
                flag = true;
                errorProvider.SetError(cmb_type, "Enter Type");
            }
            else if (string.IsNullOrEmpty (cmb_AttachBAth.Text))
            {
                flag = true;
                errorProvider.SetError(cmb_AttachBAth,"Enter AttachBath");
            }
            else if (string.IsNullOrEmpty(txt_Rentseat.Text))
            {
                flag = true;
                errorProvider.SetError(txt_Rentseat,"Enter Seat Rent");
            }
            else if (string.IsNullOrEmpty(txt_Availableseats.Text)) 
            {
                flag = true;
                errorProvider.SetError(txt_Availableseats, "Etner AvailableSeats");
            }
            else
            {
                flag = false;
                errorProvider.Clear();
            }
            return flag;
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_flour.Clear();  
            txt_Number.Clear();
            txt_Rentseat.Clear();
            cmb_type.Items.Clear(); 
            cmb_AttachBAth.Items.Clear();
            txt_Number.Focus();
        }
    }
}
