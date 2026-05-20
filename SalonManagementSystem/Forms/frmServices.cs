using SalonManagementSystem.Database;
using SalonManagementSystem.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalonManagementSystem.Forms
{
    /// <summary>
    /// Services Management - Haircut, Facial wagera manage karo
    /// </summary>
    public partial class frmServices : Form
    {
        private ServiceRepository repo = new ServiceRepository();
        private int selectedID = 0;

        public frmServices()
        {
            InitializeComponent();
            LoadServices();
        }

        private void LoadServices()
        {
            dgvServices.DataSource = repo.GetAll();
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Service ka naam zaroori hai!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var service = new Service
            {
                ServiceName = txtName.Text.Trim(),
                Description = txtDesc.Text.Trim(),
                Price = decimal.TryParse(txtPrice.Text, out decimal p) ? p : 0,
                DurationMinutes = int.TryParse(txtDuration.Text, out int d) ? d : 0
            };

            if (repo.Add(service))
            {
                MessageBox.Show("Service add ho gayi!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadServices();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle koi service select karo!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var service = new Service
            {
                ServiceID = selectedID,
                ServiceName = txtName.Text.Trim(),
                Description = txtDesc.Text.Trim(),
                Price = decimal.TryParse(txtPrice.Text, out decimal p) ? p : 0,
                DurationMinutes = int.TryParse(txtDuration.Text, out int d) ? d : 0
            };

            if (repo.Update(service))
            {
                MessageBox.Show("Service update ho gayi!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadServices();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle koi service select karo!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Service delete karna chahte ho?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.Delete(selectedID);
                ClearFields();
                LoadServices();
            }
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvServices.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["ServiceID"].Value);
                txtName.Text = row.Cells["ServiceName"].Value?.ToString();
                txtDesc.Text = row.Cells["Description"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                txtDuration.Text = row.Cells["DurationMinutes"].Value?.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            selectedID = 0;
            txtName.Clear(); txtDesc.Clear();
            txtPrice.Clear(); txtDuration.Clear();
        }
    }
}
