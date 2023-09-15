using Hostel_Management_System.helper;
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

namespace Hostel_Management_System
{
    public partial class Room : Form
    {
        HelperClass HPC = new HelperClass();

        public Room()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ErrorValidation())
            {
                return;
            }
            else
            {

                string querry = "INSERT INTO tbl_room VALUES ('" + txt_AvailableSeats.Text + "', '" + cmd_florr.Text + "', '" + cmd_type.Text + "','" + cmd_washroom.Text + "','" + txt_seatRent.Text + "','" + txt_AvailableSeats.Text + "')";
                try
                {
                    HPC.OpenCon();

                    HPC.NonExecuteQuery(querry);
                    MessageBox.Show("Successfullly save data!!");
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error in user input.\n\n\nDevelopers information: in {ex.ToString()}");
                }
                finally
                {
                    HPC.Closecon();
                }
                }
        }
        private bool ErrorValidation()
        {
            bool flag = false;
            if (string.IsNullOrEmpty(cmd_florr.Text))
            {
                flag = true;
                errorProvider1.SetError(cmd_florr, "Please Enter Value");
            }
            else if (string.IsNullOrEmpty(cmd_type.Text))
            {
                flag = true;
                errorProvider1.SetError(cmd_type, "Please Enter Value");
            }
            else if (string.IsNullOrEmpty(cmd_washroom.Text))
            {
                flag = true;
                errorProvider1.SetError(cmd_washroom, "Please Enter Value");
            }
            else if (string.IsNullOrEmpty(txt_seatRent.Text))
            {
                flag = true;
                errorProvider1.SetError(txt_seatRent, "Please Enter Value");
            }
            else if (string.IsNullOrEmpty(txt_AvailableSeats.Text))
            {
                flag = true;
                errorProvider1.SetError(txt_AvailableSeats, "Please Enter Value");
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
