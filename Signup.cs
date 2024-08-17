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

namespace Nearby
{
    public partial class Signup : Form
    {
        public string con = "Data Source= MRN; Initial Catalog= Csharp; Integrated Security = True";
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBoxback_Click(object sender, EventArgs e)
        {
            Userlogin c = new Userlogin();
            c.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "clear")
            {
                tbfirstname.Clear();
                tblastname.Clear();
                tbusername.Clear();    
                tbpassword.Clear();
            }
            else if (button.Name == "submit")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string firstname = tbfirstname.Text;
                    string lastname = tblastname.Text;
                    string username = tbusername.Text;
                    string password = tbpassword.Text;
                    string query = "INSERT INTO [users]  VALUES('"+firstname+"','"+lastname+ "','" + username + "','" + password + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Account Created");
                    conn.Close();

                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
                }

            }
        }
    }
}
