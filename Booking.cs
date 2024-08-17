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
    public partial class Booking : Form
    {
        public string con = "Data Source= MRN; Initial Catalog= Csharp; Integrated Security = True";
        public Booking()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "view")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string query = "SELECT * FROM [book]";
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
            else if (button.Name == "delete")
            {
                if (MessageBox.Show("     Are sure want to delete?     ", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string name = tbname.Text;
                    string delete = "delete from book where name = '" + name + "'";
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                }

            }
            else if (button.Name == "print")
            {
                ppd.Document = pdoc;
                if (ppd.ShowDialog() == DialogResult.OK)
                {
                    pdoc.Print();

                }
            }
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rw = dgv.Rows[e.RowIndex];
                tbname.Text = rw.Cells[0].Value.ToString();
                tblocation.Text = rw.Cells[2].Value.ToString();
                tbphone.Text = rw.Cells[1].Value.ToString();

            }
        }

        private void pdoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string  s = "=================||--Book Check-In--||=================\n\n\n" +
                         "\t\tName\t\t" + tbname.Text + " \n" +
                         "\t\tLocation\t\t" + tblocation.Text + "\n" +
                         "\t\tPhone\t\t" + tbphone.Text + "\n" +
                         "\t\t\t\t\"" + "Checked"+ "\n" +
                         "===========================================================";
            e.Graphics.DrawString(s, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            
        }
    }

    }


