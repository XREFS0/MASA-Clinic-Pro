using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_Patients : UserControl
    {
        private int _selectedPatientId = -1;

        public UC_Patients()
        {
            InitializeComponent();
        }

        private void UC_Patients_Load(object sender, EventArgs e)
        {
            LoadPatients();
            ClearForm();
        }

        private void LoadPatients(string search = "")
        {
            try
            {
                string query = "SELECT PatientID, Name, Age, Gender, Phone, Address, MedicalHistory FROM Patients";
                SQLiteParameter[] parameters = null;

                if (!string.IsNullOrWhiteSpace(search))
                {
                    query += " WHERE Name LIKE @search OR Phone LIKE @search OR PatientID = @id";
                    int idVal = -1;
                    int.TryParse(search, out idVal);
                    parameters = new SQLiteParameter[]
                    {
                        new SQLiteParameter("@search", "%" + search + "%"),
                        new SQLiteParameter("@id", idVal)
                    };
                }

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvPatients.DataSource = dt;

                if (dgvPatients.Columns.Count > 0)
                {
                    dgvPatients.Columns["PatientID"].HeaderText = "معرف المريض";
                    dgvPatients.Columns["Name"].HeaderText = "الاسم";
                    dgvPatients.Columns["Age"].HeaderText = "العمر";
                    dgvPatients.Columns["Gender"].HeaderText = "الجنس";
                    dgvPatients.Columns["Phone"].HeaderText = "رقم الهاتف";
                    dgvPatients.Columns["Address"].HeaderText = "العنوان";
                    dgvPatients.Columns["MedicalHistory"].Visible = false; // Hide from grid, show in tabs
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل بيانات المرضى: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatients.Rows[e.RowIndex];
                _selectedPatientId = Convert.ToInt32(row.Cells["PatientID"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtHistory.Text = row.Cells["MedicalHistory"].Value.ToString();

                lblSelectedID.Text = $"المريض المحدد: {_selectedPatientId}";
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المريض ورقم الهاتف كبيانات أساسية.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    INSERT INTO Patients (Name, Age, Gender, Phone, Address, MedicalHistory) 
                    VALUES (@Name, @Age, @Gender, @Phone, @Address, @MedicalHistory);";

                int ageVal = 0;
                int.TryParse(txtAge.Text, out ageVal);

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Name", txtName.Text.Trim()),
                    new SQLiteParameter("@Age", ageVal),
                    new SQLiteParameter("@Gender", cmbGender.Text),
                    new SQLiteParameter("@Phone", txtPhone.Text.Trim()),
                    new SQLiteParameter("@Address", txtAddress.Text.Trim()),
                    new SQLiteParameter("@MedicalHistory", txtHistory.Text.Trim())
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم إضافة المريض بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPatients();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء الإضافة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedPatientId == -1) return;

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("الاسم والهاتف مطلوبان لتعديل البيانات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    UPDATE Patients 
                    SET Name = @Name, Age = @Age, Gender = @Gender, Phone = @Phone, Address = @Address, MedicalHistory = @MedicalHistory 
                    WHERE PatientID = @PatientID;";

                int ageVal = 0;
                int.TryParse(txtAge.Text, out ageVal);

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Name", txtName.Text.Trim()),
                    new SQLiteParameter("@Age", ageVal),
                    new SQLiteParameter("@Gender", cmbGender.Text),
                    new SQLiteParameter("@Phone", txtPhone.Text.Trim()),
                    new SQLiteParameter("@Address", txtAddress.Text.Trim()),
                    new SQLiteParameter("@MedicalHistory", txtHistory.Text.Trim()),
                    new SQLiteParameter("@PatientID", _selectedPatientId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم تعديل بيانات المريض بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPatients();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء التعديل: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPatientId == -1) return;

            var result = MessageBox.Show("هل أنت متأكد من حذف هذا المريض وكافة سجلاته وحجوزاته بشكل نهائي؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Patients WHERE PatientID = @PatientID;";
                    var parameters = new SQLiteParameter[] { new SQLiteParameter("@PatientID", _selectedPatientId) };
                    
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("تم حذف المريض بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPatients();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPatients(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedPatientId = -1;
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = 0;
            txtPhone.Clear();
            txtAddress.Clear();
            txtHistory.Clear();
            lblSelectedID.Text = "المريض المحدد: لا يوجد";
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }
    }
}
