using System;
using System.Windows.Forms;
using SalonManagementSystem.Database;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Forms
{
    /// <summary>
    /// Login Form - application yahan se start hoti hai
    /// </summary>
    public partial class frmLogin : Form
    {
        // Static property - logged in user poori app mein accessible rahega
        public static User LoggedInUser { get; private set; }

        private UserRepository userRepo = new UserRepository();

        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin; // Enter press = Login click
        }

        /// <summary>
        /// Login button click - credentials check karta hai
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Empty fields check
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username aur Password zaroori hain!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Database se login verify karo
                User user = userRepo.Login(
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim()
                );

                if (user != null)
                {
                    // Login success
                    LoggedInUser = user;
                    MessageBox.Show($"Welcome, {user.Username}!\nRole: {user.Role}",
                        "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Dashboard kholo aur login form chupao
                    frmDashboard dashboard = new frmDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    // Wrong credentials
                    MessageBox.Show("Galat Username ya Password!",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}