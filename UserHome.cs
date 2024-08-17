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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }
        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (ActiveMdiChild != null)

                ActiveMdiChild.Close();
                Book a = new Book();
                a.MdiParent = this;
                a.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("     Are sure want to Logout ?     ", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
               
                if (ActiveMdiChild != null)

                    ActiveMdiChild.Close();
                    Userlogin u = new Userlogin();
                    u.Show();
                    this.Hide();
            }
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (ActiveMdiChild != null)

                ActiveMdiChild.Close();
                Help u = new Help();
                u.MdiParent = this;
                u.Show();

        }
    }
}
