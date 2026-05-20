namespace SalonManagementSystem.Forms
{
    partial class frmServices
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();

            // Form
            this.Text = "Services Management";
            this.Size = new System.Drawing.Size(860, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // lblTitle
            this.lblTitle.Text = "Services Management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Size = new System.Drawing.Size(280, 30);

            // dgvServices
            this.dgvServices.Location = new System.Drawing.Point(10, 50);
            this.dgvServices.Size = new System.Drawing.Size(580, 400);
            this.dgvServices.ReadOnly = true;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.MultiSelect = false;
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);

            // lblName
            this.lblName.Text = "Service Name:";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(610, 50);
            this.lblName.Size = new System.Drawing.Size(100, 22);

            // txtName
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(715, 48);
            this.txtName.Size = new System.Drawing.Size(120, 22);

            // lblDesc
            this.lblDesc.Text = "Description:";
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesc.Location = new System.Drawing.Point(610, 95);
            this.lblDesc.Size = new System.Drawing.Size(100, 22);

            // txtDesc
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDesc.Location = new System.Drawing.Point(715, 93);
            this.txtDesc.Size = new System.Drawing.Size(120, 22);

            // lblPrice
            this.lblPrice.Text = "Price (Rs):";
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.Location = new System.Drawing.Point(610, 140);
            this.lblPrice.Size = new System.Drawing.Size(100, 22);

            // txtPrice
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(715, 138);
            this.txtPrice.Size = new System.Drawing.Size(120, 22);

            // lblDuration
            this.lblDuration.Text = "Duration (min):";
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDuration.Location = new System.Drawing.Point(610, 185);
            this.lblDuration.Size = new System.Drawing.Size(100, 22);

            // txtDuration
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDuration.Location = new System.Drawing.Point(715, 183);
            this.txtDuration.Size = new System.Drawing.Size(120, 22);

            // btnAdd
            this.btnAdd.Text = "Add Service";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(610, 260);
            this.btnAdd.Size = new System.Drawing.Size(230, 34);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Text = "Update Service";
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(610, 302);
            this.btnUpdate.Size = new System.Drawing.Size(230, 34);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Text = "Delete Service";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(610, 344);
            this.btnDelete.Size = new System.Drawing.Size(230, 34);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Text = "Clear Fields";
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(610, 386);
            this.btnClear.Size = new System.Drawing.Size(230, 34);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Controls Add
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.TextBox txtName, txtDesc, txtPrice, txtDuration;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.Label lblTitle, lblName, lblDesc, lblPrice, lblDuration;
    }
}