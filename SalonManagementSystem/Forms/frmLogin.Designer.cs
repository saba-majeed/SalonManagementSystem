namespace SalonManagementSystem.Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            this.Text = "Salon Management System - Login";
            this.Size = new System.Drawing.Size(420, 320);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // ── lblTitle ──────────────────────────────────────────
            this.lblTitle.Text = "💇 Salon Management System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(60, 25);
            this.lblTitle.Size = new System.Drawing.Size(310, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblUser ───────────────────────────────────────────
            this.lblUser.Text = "Username:";
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUser.Location = new System.Drawing.Point(60, 90);
            this.lblUser.Size = new System.Drawing.Size(90, 25);

            // ── txtUsername ───────────────────────────────────────
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(160, 88);
            this.txtUsername.Size = new System.Drawing.Size(190, 28);

            // ── lblPass ───────────────────────────────────────────
            this.lblPass.Text = "Password:";
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPass.Location = new System.Drawing.Point(60, 135);
            this.lblPass.Size = new System.Drawing.Size(90, 25);

            // ── txtPassword ───────────────────────────────────────
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(160, 133);
            this.txtPassword.Size = new System.Drawing.Size(190, 28);
            this.txtPassword.PasswordChar = '*';   // characters hide karo

            // ── btnLogin ──────────────────────────────────────────
            this.btnLogin.Text = "Login";
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(155, 190);
            this.btnLogin.Size = new System.Drawing.Size(110, 38);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // ── Controls Add ──────────────────────────────────────
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.ResumeLayout(false);
        }

        // Control declarations
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}