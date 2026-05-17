using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_Doctors : UserControl
    {
        private int _selectedDoctorId = -1;

        public UC_Doctors()
        {
            InitializeComponent();
        }

        private void UC_Doctors_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            ClearForm();
        }

        private void LoadDoctors(string search = "")
        {
            try
            {
                string query = "SELECT DoctorID, Name, Specialty, Phone, Email, WorkHours, Fee FROM Doctors";
                SQLiteParameter[] parameters = null;

                if (!string.IsNullOrWhiteSpace(search))
                {
                    query += " WHERE Name LIKE @search OR Specialty LIKE @search";
                    parameters = new SQLiteParameter[]
                    {
                        new SQLiteParameter("@search", "%" + search + "%")
                    };
                }

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvDoctors.DataSource = dt;

                if (dgvDoctors.Columns.Count > 0)
                {
                    dgvDoctors.Columns["DoctorID"].HeaderText = "Doctor ID";
                    dgvDoctors.Columns["Name"].HeaderText = "Doctor Name";
                    dgvDoctors.Columns["Specialty"].HeaderText = "Specialty";
                    dgvDoctors.Columns["Phone"].HeaderText = "Phone";
                    dgvDoctors.Columns["Email"].HeaderText = "Email";
                    dgvDoctors.Columns["WorkHours"].HeaderText = "Working Hours";
                    dgvDoctors.Columns["Fee"].HeaderText = "Consultation Fee";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل بيانات الأطباء: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];
                _selectedDoctorId = Convert.ToInt32(row.Cells["DoctorID"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtSpecialty.Text = row.Cells["Specialty"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtHours.Text = row.Cells["WorkHours"].Value.ToString();
                txtFee.Text = row.Cells["Fee"].Value.ToString();

                lblSelectedID.Text = $"ID Selected: {_selectedDoctorId}";
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSpecialty.Text))
            {
                MessageBox.Show("الاسم والتخصص مطلوبان لإضافة طبيب جديد.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    INSERT INTO Doctors (Name, Specialty, Phone, Email, WorkHours, Fee) 
                    VALUES (@Name, @Specialty, @Phone, @Email, @WorkHours, @Fee);";

                double feeVal = 0.0;
                double.TryParse(txtFee.Text, out feeVal);

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Name", txtName.Text.Trim()),
                    new SQLiteParameter("@Specialty", txtSpecialty.Text.Trim()),
                    new SQLiteParameter("@Phone", txtPhone.Text.Trim()),
                    new SQLiteParameter("@Email", txtEmail.Text.Trim()),
                    new SQLiteParameter("@WorkHours", txtHours.Text.Trim()),
                    new SQLiteParameter("@Fee", feeVal)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم إضافة الطبيب بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDoctors();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء إضافة الطبيب: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedDoctorId == -1) return;

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSpecialty.Text))
            {
                MessageBox.Show("الاسم والتخصص مطلوبان لتعديل بيانات الطبيب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    UPDATE Doctors 
                    SET Name = @Name, Specialty = @Specialty, Phone = @Phone, Email = @Email, WorkHours = @WorkHours, Fee = @Fee 
                    WHERE DoctorID = @DoctorID;";

                double feeVal = 0.0;
                double.TryParse(txtFee.Text, out feeVal);

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Name", txtName.Text.Trim()),
                    new SQLiteParameter("@Specialty", txtSpecialty.Text.Trim()),
                    new SQLiteParameter("@Phone", txtPhone.Text.Trim()),
                    new SQLiteParameter("@Email", txtEmail.Text.Trim()),
                    new SQLiteParameter("@WorkHours", txtHours.Text.Trim()),
                    new SQLiteParameter("@Fee", feeVal),
                    new SQLiteParameter("@DoctorID", _selectedDoctorId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم تعديل بيانات الطبيب بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDoctors();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء التعديل: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDoctorId == -1) return;

            var result = MessageBox.Show("هل أنت متأكد من حذف هذا الطبيب بشكل نهائي؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Doctors WHERE DoctorID = @DoctorID;";
                    var parameters = new SQLiteParameter[] { new SQLiteParameter("@DoctorID", _selectedDoctorId) };
                    
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("تم حذف الطبيب بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDoctors();
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
            LoadDoctors(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedDoctorId = -1;
            txtName.Clear();
            txtSpecialty.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtHours.Clear();
            txtFee.Clear();
            lblSelectedID.Text = "ID Selected: None";
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }
    }
}
