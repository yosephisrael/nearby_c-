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
    public partial class Userlogin : Form
    {
        public string con = "Data Source= MRN; Initial Catalog= Csharp; Integrated Security = True";
        ErrorProvider er;
        public Userlogin()
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
            if (checkBoxpass.Checked == false)
                tbPass.UseSystemPasswordChar = true;
            else
                tbPass.UseSystemPasswordChar = false;
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "signup")
            {
                Signup s =  new Signup();
                s.Show();
               //Application.Run(s);
                this.Hide();
            }
            else if (button.Name == "login")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(con);
                    conn.Open();
                    string username = tbUser.Text;
                    string password = tbPass.Text;
                    string query = "SELECT * FROM [users] WHERE username='" + username + "' AND pass='" + password + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Logged in");
                        UserHome u = new UserHome();
                        u.Show();
                        this.Hide();
                    }
                    else if (string.IsNullOrEmpty(tbUser.Text))
                    {
                       ErrorProvider er = new ErrorProvider();
                        er.SetError(tbUser, "User Name is Required");   
                    }
                    else if (string.IsNullOrEmpty(tbUser.Text))
                    {
                        er = new ErrorProvider();
                        er.SetError(tbUser, "User Name is Required");
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
            tbPass.Clear();
            tbUser.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Continueas c = new Continueas();
            c.Show();
            this.Hide();
        }

        private void tbUser_MouseDown(object sender, MouseEventArgs e)
        {
           er.Clear();
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string username = tbUser.Text;
                string password = tbPass.Text;
                string query = "SELECT * FROM [users] WHERE username='" + username + "' AND pass='" + password + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Logged in");
                    UserHome u = new UserHome();
                    u.Show();
                    this.Hide();
                }
                else if (string.IsNullOrEmpty(tbUser.Text))
                {
                    ErrorProvider er = new ErrorProvider();
                    er.SetError(tbUser, "User Name is Required");
                }
                else if (string.IsNullOrEmpty(tbUser.Text))
                {
                    er = new ErrorProvider();
                    er.SetError(tbUser, "User Name is Required");
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

