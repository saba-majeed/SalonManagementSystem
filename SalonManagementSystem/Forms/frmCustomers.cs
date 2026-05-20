using SalonManagementSystem.Database;
using SalonManagementSystem.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalonManagementSystem.Forms
{
    /// <summary>
    /// Customer Management Form
    /// Add, Update, Delete, Search - sab yahan hota hai
    /// </summary>
    public partial class frmCustomers : Form
    {
        private CustomerRepository repo = new CustomerRepository();
        private int selectedID = 0;   // Grid se selected customer ka ID

        public frmCustomers()
        {
            InitializeComponent();
            LoadCustomers(); // Form open hote hi data load karo
        }

        /// <summary>
        /// Database se customers grid mein load karo
        /// </summary>
        private void LoadCustomers()
        {
            dgvCustomers.DataSource = repo.GetAll();
            dgvCustomers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Add button - naya customer save karo
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Customer ka naam zaroori hai!",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customer = new Customer
            {
                FullName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            if (repo.Add(customer))
            {
                MessageBox.Show("Customer successfully add ho gaya!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadCustomers();
            }
            else
            {
                MessageBox.Show("Error aaya! Customer add nahi hua.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update button - selected customer ki info update karo
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle grid se koi customer select karo!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customer = new Customer
            {
                CustomerID = selectedID,
                FullName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            if (repo.Update(customer))
            {
                MessageBox.Show("Customer successfully update ho gaya!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadCustomers();
            }
        }

        /// <summary>
        /// Delete button - selected customer ko delete karo
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle grid se koi customer select karo!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Kya aap ye customer delete karna chahte ho?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (repo.Delete(selectedID))
                {
                    MessageBox.Show("Customer delete ho gaya!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadCustomers();
                }
            }
        }

        /// <summary>
        /// Search button - naam ya phone se dhundo
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                LoadCustomers();      // empty = sab dikhao
            else
                dgvCustomers.DataSource = repo.Search(txtSearch.Text.Trim());
        }

        /// <summary>
        /// Grid row click - selected customer ka data form mein fill karo
        /// </summary>
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvCustomers.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["CustomerID"].Value);
                txtName.Text = row.Cells["FullName"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
            }
        }

        // Clear button
        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        /// <summary>
        /// Sab fields aur selection clear karo
        /// </summary>
        private void ClearFields()
        {
            selectedID = 0;
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSearch.Clear();
        }
    }
}
