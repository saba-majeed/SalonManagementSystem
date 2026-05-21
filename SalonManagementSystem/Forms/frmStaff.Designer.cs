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
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.ColumnHeadersHeight = 34;
            this.dgvStaff.Location = new System.Drawing.Point(10, 50);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowHeadersWidth = 62;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(580, 420);
            this.dgvStaff.TabIndex = 1;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(697, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 31);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(697, 93);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 31);
            this.txtPhone.TabIndex = 5;
            // 
            // txtSpec
            // 
            this.txtSpec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpec.Location = new System.Drawing.Point(697, 138);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(125, 31);
            this.txtSpec.TabIndex = 7;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.Location = new System.Drawing.Point(697, 183);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(125, 31);
            this.txtSalary.TabIndex = 9;
            // 
            // dtpJoining
            // 
            this.dtpJoining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpJoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoining.Location = new System.Drawing.Point(697, 223);
            this.dtpJoining.Name = "dtpJoining";
            this.dtpJoining.Size = new System.Drawing.Size(125, 31);
            this.dtpJoining.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(610, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(230, 34);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Staff";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(610, 334);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(230, 34);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Staff";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(610, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(230, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Remove Staff";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(610, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(230, 34);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Staff Management";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(596, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 22);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Full Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.Location = new System.Drawing.Point(596, 93);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(95, 22);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // lblSpec
            // 
            this.lblSpec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSpec.Location = new System.Drawing.Point(596, 138);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(95, 22);
            this.lblSpec.TabIndex = 6;
            this.lblSpec.Text = "Specialization:";
            // 
            // lblSalary
            // 
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSalary.Location = new System.Drawing.Point(605, 183);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(95, 22);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "Salary:";
            // 
            // lblJoining
            // 
            this.lblJoining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJoining.Location = new System.Drawing.Point(596, 228);
            this.lblJoining.Name = "lblJoining";
            this.lblJoining.Size = new System.Drawing.Size(95, 22);
            this.lblJoining.TabIndex = 10;
            this.lblJoining.Text = "Joining Date:";
            // 
            // frmStaff
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(838, 464);
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
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.TextBox txtName, txtPhone, txtSpec, txtSalary;
        private System.Windows.Forms.DateTimePicker dtpJoining;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.Label lblTitle, lblName, lblPhone, lblSpec, lblSalary, lblJoining;
    }
}