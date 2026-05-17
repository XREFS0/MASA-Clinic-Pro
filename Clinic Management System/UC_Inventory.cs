using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_Inventory : UserControl
    {
        private int _selectedItemId = -1;

        public UC_Inventory()
        {
            InitializeComponent();
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            LoadInventory();
            ClearForm();
        }

        private void LoadInventory(string search = "")
        {
            try
            {
                string query = "SELECT ItemID, ItemName, Category, Quantity, AlertLevel, ExpiryDate FROM Inventory";
                SQLiteParameter[] parameters = null;

                if (!string.IsNullOrWhiteSpace(search))
                {
                    query += " WHERE ItemName LIKE @search OR Category LIKE @search";
                    parameters = new SQLiteParameter[] { new SQLiteParameter("@search", "%" + search + "%") };
                }

                query += " ORDER BY ItemName ASC;";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvInventory.DataSource = dt;

                if (dgvInventory.Columns.Count > 0)
                {
                    dgvInventory.Columns["ItemID"].HeaderText = "رقم الصنف";
                    dgvInventory.Columns["ItemName"].HeaderText = "اسم الصنف";
                    dgvInventory.Columns["Category"].HeaderText = "القسم / التصنيف";
                    dgvInventory.Columns["Quantity"].HeaderText = "الكمية المتاحة";
                    dgvInventory.Columns["AlertLevel"].HeaderText = "حد الأمان";
                    dgvInventory.Columns["ExpiryDate"].HeaderText = "تاريخ الصلاحية";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل المخزون: {ex.Message}");
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
                _selectedItemId = Convert.ToInt32(row.Cells["ItemID"].Value);

                txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtAlertLevel.Text = row.Cells["AlertLevel"].Value.ToString();
                
                if (DateTime.TryParse(row.Cells["ExpiryDate"].Value.ToString(), out DateTime exp))
                {
                    dtpExpiry.Value = exp;
                }

                lblSelectedID.Text = $"الصنف المحدد: {_selectedItemId}";
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void dgvInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Highlight low stock rows in light red/warning coral
            if (dgvInventory.Columns[e.ColumnIndex].Name == "Quantity" && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                int alert = Convert.ToInt32(row.Cells["AlertLevel"].Value);

                if (qty <= alert)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                }
                else
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadInventory(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الصنف والكمية المتاحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int qty = 0;
                int alert = 0;
                int.TryParse(txtQuantity.Text.Trim(), out qty);
                int.TryParse(txtAlertLevel.Text.Trim(), out alert);

                string query = @"
                    INSERT INTO Inventory (ItemName, DrugName, Category, Quantity, AlertLevel, MinAlertQty, ExpiryDate) 
                    VALUES (@Name, @Name, @Category, @Qty, @Alert, @Alert, @Expiry);";

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Name", txtItemName.Text.Trim()),
                    new SQLiteParameter("@Category", cmbCategory.Text),
                    new SQLiteParameter("@Qty", qty),
                    new SQLiteParameter("@Alert", alert),
                    new SQLiteParameter("@Expiry", dtpExpiry.Value.ToString("yyyy-MM-dd"))
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تمت إضافة الصنف بنجاح إلى المخزن.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInventory();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء إضافة الصنف: {ex.Message}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedItemId == -1) return;

            try
            {
                int qty = 0;
                int alert = 0;
                int.TryParse(txtQuantity.Text.Trim(), out qty);
                int.TryParse(txtAlertLevel.Text.Trim(), out alert);

                string query = @"
                    UPDATE Inventory 
                    SET ItemName = @Name, DrugName = @Name, Category = @Category, Quantity = @Qty, AlertLevel = @Alert, MinAlertQty = @Alert, ExpiryDate = @Expiry 
                    WHERE ItemID = @ItemID;";

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Name", txtItemName.Text.Trim()),
                    new SQLiteParameter("@Category", cmbCategory.Text),
                    new SQLiteParameter("@Qty", qty),
                    new SQLiteParameter("@Alert", alert),
                    new SQLiteParameter("@Expiry", dtpExpiry.Value.ToString("yyyy-MM-dd")),
                    new SQLiteParameter("@ItemID", _selectedItemId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم تعديل بيانات الصنف بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInventory();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء التعديل: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedItemId == -1) return;

            var result = MessageBox.Show("هل أنت متأكد من حذف هذا الصنف نهائياً من المخزون؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Inventory WHERE ItemID = @ItemID;";
                    var parameters = new SQLiteParameter[] { new SQLiteParameter("@ItemID", _selectedItemId) };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("تم حذف الصنف بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventory();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء الحذف: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedItemId = -1;
            txtItemName.Clear();
            cmbCategory.SelectedIndex = 0;
            txtQuantity.Text = "0";
            txtAlertLevel.Text = "5";
            dtpExpiry.Value = DateTime.Today.AddYears(1);
            lblSelectedID.Text = "الصنف المحدد: لا يوجد";
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }
    }
}
