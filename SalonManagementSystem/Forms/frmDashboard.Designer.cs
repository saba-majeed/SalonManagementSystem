namespace SalonManagementSystem.Forms
{
    partial class frmDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form
            this.Text = "Salon Management System - Dashboard";
            this.Size = new System.Drawing.Size(500, 480);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // lblTitle
            this.lblTitle.Text = "Salon Management System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Size = new System.Drawing.Size(380, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblWelcome
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWelcome.ForeColor = System.Drawing.Color.Gray;
            this.lblWelcome.Location = new System.Drawing.Point(60, 60);
            this.lblWelcome.Size = new System.Drawing.Size(380, 22);
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnCustomers
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCustomers.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Size = new System.Drawing.Size(360, 45);
            this.btnCustomers.Location = new System.Drawing.Point(68, 95);
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);

            // btnStaff
            this.btnStaff.Text = "Staff";
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnStaff.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Size = new System.Drawing.Size(360, 45);
            this.btnStaff.Location = new System.Drawing.Point(68, 150);
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);

            // btnServices
            this.btnServices.Text = "Services";
            this.btnServices.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnServices.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Size = new System.Drawing.Size(360, 45);
            this.btnServices.Location = new System.Drawing.Point(68, 205);
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);

            // btnInventory
            this.btnInventory.Text = "Inventory";
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnInventory.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Size = new System.Drawing.Size(360, 45);
            this.btnInventory.Location = new System.Drawing.Point(68, 260);
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);

            // btnAppointments
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAppointments.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAppointments.ForeColor = System.Drawing.Color.White;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Size = new System.Drawing.Size(360, 45);
            this.btnAppointments.Location = new System.Drawing.Point(68, 315);
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);

            // btnLogout
            this.btnLogout.Text = "Logout";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Size = new System.Drawing.Size(360, 38);
            this.btnLogout.Location = new System.Drawing.Point(68, 375);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Controls Add
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnAppointments);
            this.Controls.Add(this.btnLogout);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnLogout;
    }
}