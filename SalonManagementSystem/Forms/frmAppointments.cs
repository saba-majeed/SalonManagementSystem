using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Cmp;
using SalonManagementSystem.Database;
using SalonManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace SalonManagementSystem.Forms
{
    /// <summary>
    /// Appointments Form - customer ki service booking manage karo
    /// </summary>
    public partial class frmAppointments : Form
    {
        private AppointmentRepository apptRepo = new AppointmentRepository();
        private CustomerRepository custRepo = new CustomerRepository();
        private StaffRepository staffRepo = new StaffRepository();
        private ServiceRepository svcRepo = new ServiceRepository();
        private int selectedID = 0;

        public frmAppointments()
        {
            InitializeComponent();
            LoadDropdowns();   // ComboBox populate karo
            LoadAppointments();
        }

        /// <summary>
        /// Customer, Staff, Service ComboBox mein data bharo
        /// </summary>
        private void LoadDropdowns()
        {
            // Customer dropdown
            cmbCustomer.DataSource = custRepo.GetAll();
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "CustomerID";

            // Staff dropdown
            cmbStaff.DataSource = staffRepo.GetAll();
            cmbStaff.DisplayMember = "FullName";
            cmbStaff.ValueMember = "StaffID";

            // Service dropdown
            cmbService.DataSource = svcRepo.GetAll();
            cmbService.DisplayMember = "ServiceName";
            cmbService.ValueMember = "ServiceID";

            // Status options
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new[] { "Pending", "Completed", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadAppointments()
        {
            dgvAppointments.DataSource = apptRepo.GetAll();
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Naya appointment book karo
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null ||
                cmbStaff.SelectedValue == null ||
                cmbService.SelectedValue == null)
            {
                MessageBox.Show("Customer, Staff aur Service select karo!",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var appt = new Appointment
            {
                CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue),
                StaffID = Convert.ToInt32(cmbStaff.SelectedValue),
                ServiceID = Convert.ToInt32(cmbService.SelectedValue),
                AppointmentDate = dtpDate.Value,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Pending",
                Notes = txtNotes.Text.Trim()
            };

            if (apptRepo.Add(appt))
            {
                MessageBox.Show("Appointment book ho gayi!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadAppointments();
            }
        }

        /// <summary>
        /// Selected appointment ka status update karo
        /// </summary>
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle appointment select karo!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = cmbStatus.SelectedItem?.ToString();
            if (apptRepo.UpdateStatus(selectedID, status))
            {
                MessageBox.Show("Status update ho gaya!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle appointment select karo!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Appointment delete karna chahte ho?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                apptRepo.Delete(selectedID);
                ClearFields();
                LoadAppointments();
            }
        }

        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvAppointments.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["AppointmentID"].Value);
                txtNotes.Text = row.Cells["Notes"].Value?.ToString();

                // Status bhi set karo
                string st = row.Cells["Status"].Value?.ToString();
                int idx = cmbStatus.Items.IndexOf(st);
                if (idx >= 0) cmbStatus.SelectedIndex = idx;
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            selectedID = 0;
            txtNotes.Clear();
            cmbStatus.SelectedIndex = 0;
        }
    }
}
