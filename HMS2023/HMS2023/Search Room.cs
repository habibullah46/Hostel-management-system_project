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
    public partial class Search_Room : Form
    { 
        public Search_Room()
        {
            InitializeComponent();
        }

        private void Search_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDB2023DataSet5.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter.Fill(this.hMSDB2023DataSet5.tbl_Room);

        }

      

        private void btn_search_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM tbl_Room WHERE RoomNumber ='" + txt_roomnumber.Text + "'";
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr =  cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if(dt.Rows.Count > 0 )
            {
                grd_view.DataSource = dt;   
            }

        }
       
    }
}
