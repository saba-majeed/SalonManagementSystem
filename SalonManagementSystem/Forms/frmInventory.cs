using SalonManagementSystem.Database;
using SalonManagementSystem.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalonManagementSystem.Forms
{
    /// <summary>
    /// Inventory Management - salon products aur stock manage karo
    /// </summary>
    public partial class frmInventory : Form
    {
        private InventoryRepository repo = new InventoryRepository();
        private int selectedID = 0;

        public frmInventory()
        {
            InitializeComponent();
            LoadInventory();
        }

        private void LoadInventory()
        {
            dgvInventory.DataSource = repo.GetAll();
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Item ka naam zaroori hai!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new Inventory
            {
                ItemName = txtName.Text.Trim(),
                Quantity = int.TryParse(txtQty.Text, out int q) ? q : 0,
                UnitPrice = decimal.TryParse(txtPrice.Text, out decimal p) ? p : 0,
                Supplier = txtSupplier.Text.Trim()
            };

            if (repo.Add(item))
            {
                MessageBox.Show("Item add ho gaya!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadInventory();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle koi item select karo!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new Inventory
            {
                ItemID = selectedID,
                ItemName = txtName.Text.Trim(),
                Quantity = int.TryParse(txtQty.Text, out int q) ? q : 0,
                UnitPrice = decimal.TryParse(txtPrice.Text, out decimal p) ? p : 0,
                Supplier = txtSupplier.Text.Trim()
            };

            if (repo.Update(item))
            {
                MessageBox.Show("Item update ho gaya!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadInventory();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Pehle koi item select karo!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Item delete karna chahte ho?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.Delete(selectedID);
                ClearFields();
                LoadInventory();
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvInventory.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["ItemID"].Value);
                txtName.Text = row.Cells["ItemName"].Value?.ToString();
                txtQty.Text = row.Cells["Quantity"].Value?.ToString();
                txtPrice.Text = row.Cells["UnitPrice"].Value?.ToString();
                txtSupplier.Text = row.Cells["Supplier"].Value?.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            selectedID = 0;
            txtName.Clear(); txtQty.Clear();
            txtPrice.Clear(); txtSupplier.Clear();
        }
    }
}
