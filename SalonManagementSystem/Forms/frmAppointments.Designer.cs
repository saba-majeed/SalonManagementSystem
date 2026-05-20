namespace SalonManagementSystem.Forms
{
    partial class frmAppointments
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();

            // Form
            this.Text = "Appointments Management";
            this.Size = new System.Drawing.Size(1000, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // lblTitle
            this.lblTitle.Text = "Appointments Management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Size = new System.Drawing.Size(340, 30);

            // dgvAppointments
            this.dgvAppointments.Location = new System.Drawing.Point(10, 50);
            this.dgvAppointments.Size = new System.Drawing.Size(660, 460);
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellClick);

            // lblCustomer
            this.lblCustomer.Text = "Customer:";
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomer.Location = new System.Drawing.Point(690, 50);
            this.lblCustomer.Size = new System.Drawing.Size(95, 22);

            // cmbCustomer
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Location = new System.Drawing.Point(790, 48);
            this.cmbCustomer.Size = new System.Drawing.Size(170, 22);

            // lblStaff
            this.lblStaff.Text = "Staff:";
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStaff.Location = new System.Drawing.Point(690, 95);
            this.lblStaff.Size = new System.Drawing.Size(95, 22);

            // cmbStaff
            this.cmbStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.Location = new System.Drawing.Point(790, 93);
            this.cmbStaff.Size = new System.Drawing.Size(170, 22);

            // lblService
            this.lblService.Text = "Service:";
            this.lblService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblService.Location = new System.Drawing.Point(690, 140);
            this.lblService.Size = new System.Drawing.Size(95, 22);

            // cmbService
            this.cmbService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.Location = new System.Drawing.Point(790, 138);
            this.cmbService.Size = new System.Drawing.Size(170, 22);

            // lblDate
            this.lblDate.Text = "Date & Time:";
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.Location = new System.Drawing.Point(690, 185);
            this.lblDate.Size = new System.Drawing.Size(95, 22);

            // dtpDate
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Location = new System.Drawing.Point(790, 183);
            this.dtpDate.Size = new System.Drawing.Size(170, 22);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblStatus
            this.lblStatus.Text = "Status:";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(690, 230);
            this.lblStatus.Size = new System.Drawing.Size(95, 22);

            // cmbStatus
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(790, 228);
            this.cmbStatus.Size = new System.Drawing.Size(170, 22);

            // lblNotes
            this.lblNotes.Text = "Notes:";
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNotes.Location = new System.Drawing.Point(690, 275);
            this.lblNotes.Size = new System.Drawing.Size(95, 22);

            // txtNotes
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(790, 273);
            this.txtNotes.Size = new System.Drawing.Size(170, 22);

            // btnAdd
            this.btnAdd.Text = "Book Appointment";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(690, 360);
            this.btnAdd.Size = new System.Drawing.Size(275, 34);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdateStatus
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Location = new System.Drawing.Point(690, 402);
            this.btnUpdateStatus.Size = new System.Drawing.Size(275, 34);
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);

            // btnDelete
            this.btnDelete.Text = "Delete Appointment";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(690, 444);
            this.btnDelete.Size = new System.Drawing.Size(275, 34);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Text = "Clear Fields";
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(690, 486);
            this.btnClear.Size = new System.Drawing.Size(275, 34);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Controls Add
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ComboBox cmbCustomer, cmbStaff, cmbService, cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAdd, btnUpdateStatus, btnDelete, btnClear;
        private System.Windows.Forms.Label lblTitle, lblCustomer, lblStaff, lblService,
                                                    lblDate, lblStatus, lblNotes;
    }
}