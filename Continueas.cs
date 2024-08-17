using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nearby
{
    public partial class Continueas : Form
    {
        public Continueas()
        {
            InitializeComponent();
        }
        private void admin_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "admin")
            {
                Admin a= new Admin();
                a.Show();
                this.Hide();
            }
            if (button.Name == "user")
            {
                Userlogin a = new Userlogin();
                a.Show();
                this.Hide();
            }
        }

        private void admin_MouseHover(object sender, EventArgs e)
        {
            admin.BackColor= Color.Bisque;
            
        }

        private void user_MouseHover(object sender, EventArgs e)
        {
            user.BackColor = Color.Bisque;
            
        }

        private void admin_MouseLeave(object sender, EventArgs e)
        {
            admin.BackColor = Color.White;
        }

        private void user_MouseLeave(object sender, EventArgs e)
        {
            user.BackColor = Color.White;
        }
    }
}