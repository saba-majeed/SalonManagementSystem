namespace SalonManagementSystem.Forms
{
    partial class frmStaff
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpJoining = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblJoining = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();

            // Form
            this.Text = "Staff Management";
            this.Size = new System.Drawing.Size(860, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // lblTitle
            this.lblTitle.Text = "Staff Management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Size = new System.Drawing.Size(280, 30);

            // dgvStaff
            this.dgvStaff.Location = new System.Drawing.Point(10, 50);
            this.dgvStaff.Size = new System.Drawing.Size(580, 420);
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);

            // lblName
            this.lblName.Text = "Full Name:";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(610, 50);
            this.lblName.Size = new System.Drawing.Size(95, 22);

            // txtName
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(710, 48);
            this.txtName.Size = new System.Drawing.Size(125, 22);

            // lblPhone
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.Location = new System.Drawing.Point(610, 95);
            this.lblPhone.Size = new System.Drawing.Size(95, 22);

            // txtPhone
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(710, 93);
            this.txtPhone.Size = new System.Drawing.Size(125, 22);

            // lblSpec
            this.lblSpec.Text = "Specialization:";
            this.lblSpec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSpec.Location = new System.Drawing.Point(610, 140);
            this.lblSpec.Size = new System.Drawing.Size(95, 22);

            // txtSpec
            this.txtSpec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpec.Location = new System.Drawing.Point(710, 138);
            this.txtSpec.Size = new System.Drawing.Size(125, 22);

            // lblSalary
            this.lblSalary.Text = "Salary:";
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSalary.Location = new System.Drawing.Point(610, 185);
            this.lblSalary.Size = new System.Drawing.Size(95, 22);

            // txtSalary
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.Location = new System.Drawing.Point(710, 183);
            this.txtSalary.Size = new System.Drawing.Size(125, 22);

            // lblJoining
            this.lblJoining.Text = "Joining Date:";
            this.lblJoining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJoining.Location = new System.Drawing.Point(610, 230);
            this.lblJoining.Size = new System.Drawing.Size(95, 22);

            // dtpJoining
            this.dtpJoining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpJoining.Location = new System.Drawing.Point(710, 228);
            this.dtpJoining.Size = new System.Drawing.Size(125, 22);
            this.dtpJoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // btnAdd
            this.btnAdd.Text = "Add Staff";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(610, 310);
            this.btnAdd.Size = new System.Drawing.Size(230, 34);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Text = "Update Staff";
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(610, 352);
            this.btnUpdate.Size = new System.Drawing.Size(230, 34);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Text = "Remove Staff";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(610, 394);
            this.btnDelete.Size = new System.Drawing.Size(230, 34);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Text = "Clear Fields";
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(610, 436);
            this.btnClear.Size = new System.Drawing.Size(230, 34);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Controls Add
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblJoining);
            this.Controls.Add(this.dtpJoining);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.TextBox txtName, txtPhone, txtSpec, txtSalary;
        private System.Windows.Forms.DateTimePicker dtpJoining;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.Label lblTitle, lblName, lblPhone, lblSpec, lblSalary, lblJoining;
    }
}