using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nearby
{
    public partial class Admin : Form
    {
        public string con = "Data Source= MRN; Initial Catalog= Csharp; Integrated Security = True";
        ErrorProvider er;
        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (admincheckBoxpass.Checked == false)
                admintbPass.UseSystemPasswordChar = true;
            else
                admintbPass.UseSystemPasswordChar = false;
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "adminlogin")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string username = admintbUser.Text;
                    string password = admintbPass.Text;
                    string query = "SELECT * FROM [admin] WHERE username='" + username + "' AND pass='" + password + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                   
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Logged in");
                            AdminHome a= new AdminHome();
                            a.Show();
                            this.Hide();
                        }
                        else if (string.IsNullOrEmpty(admintbUser.Text))
                        {
                             er = new ErrorProvider();
                            er.SetError(admintbUser, "User Name is Required");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password");
                        }
                    
                    conn.Close();

                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admintbPass.Clear();
            admintbUser.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Continueas c = new Continueas();
            c.Show();
            this.Hide();
        }

        private void admintbUser_MouseDown(object sender, MouseEventArgs e)
        {
            er.Clear();
        }

        private void admintbPass_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void adminlogin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string username = admintbUser.Text;
                string password = admintbPass.Text;
                string query = "SELECT * FROM [admin] WHERE username='" + username + "' AND pass='" + password + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Logged in");
                    AdminHome a = new AdminHome();
                    a.Show();
                    this.Hide();
                }
                else if (string.IsNullOrEmpty(admintbUser.Text))
                {
                    er = new ErrorProvider();
                    er.SetError(admintbUser, "User Name is Required");
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }

                conn.Close();

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }
    }
  }

