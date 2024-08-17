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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void addHotelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (ActiveMdiChild != null)

                ActiveMdiChild.Close();
                Hotel a = new Hotel();
                a.MdiParent = this;
                a.Show();

        }

        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (ActiveMdiChild != null)

                ActiveMdiChild.Close();
                Booking a = new Booking();
                a.MdiParent = this;
                a.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("     Are sure want to Logout ?     ", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Admin a = new Admin();
                 a.Show();
                this.Hide();
            }

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
