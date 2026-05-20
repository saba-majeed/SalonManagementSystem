using SalonManagementSystem.Database;
using SalonManagementSystem.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalonManagementSystem.Forms
{
    /// <summary>
    /// Staff Management Form - salon employees manage karo
    /// </summary>
    public partial class frmStaff : Form
    {
        private StaffRepository repo = new StaffRepository();
        private int selectedID = 0;

        public frmStaff()
        {
            InitializeComponent();
            LoadStaff();
        }

        private void LoadStaff()
        {
            dgvStaff.DataSource = repo.GetAll();
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Staff ka naam zaroori hai!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var staff = new Staff
            {
                FullName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Specialization = txtSpec.Text.Trim(),
                Salary = decimal.TryParse(txtSalary.Text, out decimal sal) ? sal : 0,
                JoiningDate = dtpJoining.Value
            };

            if (repo.Add(staff))
            {
                MessageBox.Show("Staff member add ho gaya!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadStaff();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle koi staff member select karo!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var staff = new Staff
            {
                StaffID = selectedID,
                FullName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Specialization = txtSpec.Text.Trim(),
                Salary = decimal.TryParse(txtSalary.Text, out decimal sal) ? sal : 0
            };

            if (repo.Update(staff))
            {
                MessageBox.Show("Staff update ho gaya!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadStaff();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle koi staff member select karo!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Staff member ko inactive karna chahte ho?",
                    "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.Delete(selectedID); // Soft delete
                ClearFields();
                LoadStaff();
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvStaff.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["StaffID"].Value);
                txtName.Text = row.Cells["FullName"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtSpec.Text = row.Cells["Specialization"].Value?.ToString();
                txtSalary.Text = row.Cells["Salary"].Value?.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            selectedID = 0;
            txtName.Clear(); txtPhone.Clear();
            txtSpec.Clear(); txtSalary.Clear();
        }
    }
}
