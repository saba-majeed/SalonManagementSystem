using System;
using System.Windows.Forms;

namespace SalonManagementSystem.Forms
{
    /// <summary>
    /// Main Dashboard - sab forms yahan se open hote hain
    /// </summary>
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            // Logged in user ka naam show karo
            lblWelcome.Text = $"Welcome: {frmLogin.LoggedInUser?.Username}" +
                              $"  |  Role: {frmLogin.LoggedInUser?.Role}";
        }

        // Customers form kholo
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new frmCustomers().ShowDialog();
        }

        // Staff form kholo
        private void btnStaff_Click(object sender, EventArgs e)
        {
            new frmStaff().ShowDialog();
        }

        // Services form kholo
        private void btnServices_Click(object sender, EventArgs e)
        {
            new frmServices().ShowDialog();
        }

        // Inventory form kholo
        private void btnInventory_Click(object sender, EventArgs e)
        {
            new frmInventory().ShowDialog();
        }

        // Appointments form kholo
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            new frmAppointments().ShowDialog();
        }

        /// <summary>
        /// Logout - confirm karke login page par wapas jao
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout karna chahte ho?", "Confirm Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frmLogin().Show();
                this.Close();
            }
        }
    }
}
