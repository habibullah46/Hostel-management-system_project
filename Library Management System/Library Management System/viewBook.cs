using Library_Management_System.Helper;
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

namespace Library_Management_System
{
    public partial class viewBook : Form
    {
        public viewBook()
        {
            InitializeComponent();
        }

        private void viewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            // TODO: This line of code loads data into the 'libraryManagementSystemDataSet.AddBook' table. You can move, or remove it, as needed.
            this.addBookTableAdapter.Fill(this.libraryManagementSystemDataSet.AddBook);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string querry = "SELECT * FROM AddBook WHERE BookName LIKE  '%" + txt_Name.Text + "%'";
           string connection = System.Configuration.ConfigurationManager.ConnectionStrings["myconnecton"].ToString();
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if(dr.Read())
            {
                gridview.DataSource = dt;
            }

    }
        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                int  bid = int.Parse(gridview.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["myconnecton"].ToString();
            string querry = "SELECT * FROM AddBook";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry,con );
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count > 0)
            {
                txt_bookname.Text = dr["BookName"].ToString();
            }
            
        }
    }
}
