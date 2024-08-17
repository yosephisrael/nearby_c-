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
using System.Xml.Linq;

namespace Nearby
{
    public partial class Book : Form
    {
        public string con = "Data Source= MRN; Initial Catalog= Csharp; Integrated Security = True";
        DataTable dt;
        public Book()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "SELECT * FROM [hotel]";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
                conn.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("loc LIKE '%{0}%'",tbsearch.Text);
            dgv.DataSource = dv;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rw = dgv.Rows[e.RowIndex];
                tblocation.Text = rw.Cells[2].Value.ToString();              
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "clear")
            {
                tblocation.Clear();
                tbname.Clear();
                tbphone.Clear();
            }
            else if (button.Name == "submit")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string name = tbname.Text;
                    string location = tblocation.Text;
                    string phone = tbphone.Text;
                    string query = "INSERT INTO [book]  VALUES('" + name + "','" + phone + "','" + location + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Booked Successully");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
                }

            }
        }
    }
}
