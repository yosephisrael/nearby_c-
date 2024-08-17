using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nearby
{
    public partial class Hotel : Form
    {
        public string con = "Data Source= MRN; Initial Catalog= Csharp; Integrated Security = True";
        public Hotel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "clear")
            {
                tbname.Enabled = true;
                tbname.Clear();
                tbstar.Clear();
                tblocation.Clear();
                tbbedroom.Clear();
            }
            else if (button.Name == "submit")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string name = tbname.Text;
                    string star = tbstar.Text;
                    string location = tblocation.Text;
                    string bedroom = tbbedroom.Text;
                    string query = "INSERT INTO [hotel]  VALUES('" + name + "','" + star + "','" + location + "','" + bedroom + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("New Hotel Add Successully");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
                }

            }
            else if (button.Name == "update")
            {
                if (MessageBox.Show("     Are sure want to update?     ", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string name = tbname.Text;
                    string star = tbstar.Text;
                    string location = tblocation.Text;
                    string bedroom = tbbedroom.Text;
                    string update = "update hotel set hotelname = '" + name + "',star = '" + star + "',loc = '" + location + "',bedroom = '" + bedroom + "'where hotelname = '" + name + "'";
                    SqlCommand cmd = new SqlCommand(update, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                }

            }
            else if (button.Name == "delete")
            {
                if (MessageBox.Show("     Are sure want to delete?     ", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string name = tbname.Text;
                    string delete = "delete from hotel where hotelname = '" + name + "'";
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                }
            }
            else if (button.Name == "view")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string query = "SELECT * FROM [hotel]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt;
                    conn.Close();
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
                }


            }
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow rw = dgv.Rows[e.RowIndex];
                    tbname.Enabled = false;
                    tbname.Text = rw.Cells[0].Value.ToString();
                    tbstar.Text = rw.Cells[1].Value.ToString();
                    tblocation.Text = rw.Cells[2].Value.ToString();
                    tbbedroom.Text = rw.Cells[3].Value.ToString();
                }
            }
       
    } 
}
 
