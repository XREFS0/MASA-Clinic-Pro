using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_Appointments : UserControl
    {
        private int _selectedAppId = -1;

        public UC_Appointments()
        {
            InitializeComponent();
        }

        private void UC_Appointments_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
            LoadAppointments();
            ClearForm();
        }

        private void LoadDropdowns()
        {
            try
            {
                // Load Patients Dropdown
                DataTable dtPatients = DatabaseHelper.ExecuteQuery("SELECT PatientID, Name FROM Patients ORDER BY Name ASC;");
                cmbPatient.DataSource = dtPatients;
                cmbPatient.DisplayMember = "Name";
                cmbPatient.ValueMember = "PatientID";

                // Load Doctors Dropdown
                DataTable dtDoctors = DatabaseHelper.ExecuteQuery("SELECT DoctorID, Name FROM Doctors ORDER BY Name ASC;");
                cmbDoctor.DataSource = dtDoctors;
                cmbDoctor.DisplayMember = "Name";
                cmbDoctor.ValueMember = "DoctorID";

                // Load Visit Type Dropdown in Arabic
                cmbVisitType.DataSource = new System.Collections.Generic.KeyValuePair<string, string>[] {
                    new System.Collections.Generic.KeyValuePair<string, string>("Consultation", "كشف جديد"),
                    new System.Collections.Generic.KeyValuePair<string, string>("Follow-up", "استشارة/متابعة")
                };
                cmbVisitType.DisplayMember = "Value";
                cmbVisitType.ValueMember = "Key";

                // Load Status Dropdown in Arabic
                cmbStatus.DataSource = new System.Collections.Generic.KeyValuePair<string, string>[] {
                    new System.Collections.Generic.KeyValuePair<string, string>("Pending", "قيد الانتظار"),
                    new System.Collections.Generic.KeyValuePair<string, string>("Confirmed", "مؤكد"),
                    new System.Collections.Generic.KeyValuePair<string, string>("Cancelled", "ملغى"),
                    new System.Collections.Generic.KeyValuePair<string, string>("Completed", "مكتمل")
                };
                cmbStatus.DisplayMember = "Value";
                cmbStatus.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل القوائم المنسدلة الحجوزات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAppointments(string search = "")
        {
            try
            {
                string query = @"
                    SELECT a.AppointmentID, p.Name AS PatientName, d.Name AS DoctorName, 
                           a.AppointmentDate AS Date, a.AppointmentTime AS Time, 
                           a.VisitType AS Type, a.Status, a.PatientID, a.DoctorID
                     FROM Appointments a
                     JOIN Patients p ON a.PatientID = p.PatientID
                     JOIN Doctors d ON a.DoctorID = d.DoctorID";
                
                SQLiteParameter[] parameters = null;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    query += " WHERE p.Name LIKE @search OR d.Name LIKE @search";
                    parameters = new SQLiteParameter[] { new SQLiteParameter("@search", "%" + search + "%") };
                }

                query += " ORDER BY a.AppointmentDate DESC, a.AppointmentTime ASC;";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvAppointments.DataSource = dt;

                if (dgvAppointments.Columns.Count > 0)
                {
                    dgvAppointments.Columns["AppointmentID"].HeaderText = "رقم الحجز";
                    dgvAppointments.Columns["PatientName"].HeaderText = "المريض";
                    dgvAppointments.Columns["DoctorName"].HeaderText = "الطبيب";
                    dgvAppointments.Columns["Date"].HeaderText = "التاريخ";
                    dgvAppointments.Columns["Time"].HeaderText = "الوقت";
                    dgvAppointments.Columns["Type"].HeaderText = "نوع الزيارة";
                    dgvAppointments.Columns["Status"].HeaderText = "الحالة";

                    // Hide references
                    dgvAppointments.Columns["PatientID"].Visible = false;
                    dgvAppointments.Columns["DoctorID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل قائمة الحجوزات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAppointments.Rows[e.RowIndex];
                _selectedAppId = Convert.ToInt32(row.Cells["AppointmentID"].Value);

                cmbPatient.SelectedValue = Convert.ToInt32(row.Cells["PatientID"].Value);
                cmbDoctor.SelectedValue = Convert.ToInt32(row.Cells["DoctorID"].Value);

                DateTime dateVal;
                if (DateTime.TryParse(row.Cells["Date"].Value.ToString(), out dateVal))
                {
                    dtpDate.Value = dateVal;
                }

                txtTime.Text = row.Cells["Time"].Value.ToString();
                cmbVisitType.SelectedValue = row.Cells["Type"].Value.ToString();
                cmbStatus.SelectedValue = row.Cells["Status"].Value.ToString();

                lblSelectedID.Text = $"رقم الحجز المحدد: {_selectedAppId}";
                btnCancel.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null || cmbDoctor.SelectedValue == null || string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("يرجى اختيار المريض والطبيب وتحديد وقت الحجز.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, AppointmentTime, VisitType, Status) 
                    VALUES (@PatientID, @DoctorID, @Date, @Time, @VisitType, @Status);";

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@PatientID", cmbPatient.SelectedValue),
                    new SQLiteParameter("@DoctorID", cmbDoctor.SelectedValue),
                    new SQLiteParameter("@Date", dtpDate.Value.ToString("yyyy-MM-dd")),
                    new SQLiteParameter("@Time", txtTime.Text.Trim()),
                    new SQLiteParameter("@VisitType", cmbVisitType.SelectedValue?.ToString() ?? cmbVisitType.Text),
                    new SQLiteParameter("@Status", cmbStatus.SelectedValue?.ToString() ?? cmbStatus.Text)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم حجز الموعد بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء الحجز: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedAppId == -1) return;

            if (cmbPatient.SelectedValue == null || cmbDoctor.SelectedValue == null || string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول لتعديل الحجز.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    UPDATE Appointments 
                    SET PatientID = @PatientID, DoctorID = @DoctorID, AppointmentDate = @Date, 
                        AppointmentTime = @Time, VisitType = @VisitType, Status = @Status 
                    WHERE AppointmentID = @AppointmentID;";

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@PatientID", cmbPatient.SelectedValue),
                    new SQLiteParameter("@DoctorID", cmbDoctor.SelectedValue),
                    new SQLiteParameter("@Date", dtpDate.Value.ToString("yyyy-MM-dd")),
                    new SQLiteParameter("@Time", txtTime.Text.Trim()),
                    new SQLiteParameter("@VisitType", cmbVisitType.SelectedValue?.ToString() ?? cmbVisitType.Text),
                    new SQLiteParameter("@Status", cmbStatus.SelectedValue?.ToString() ?? cmbStatus.Text),
                    new SQLiteParameter("@AppointmentID", _selectedAppId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم تعديل الحجز بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء التعديل: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_selectedAppId == -1) return;

            var result = MessageBox.Show("هل أنت متأكد من إلغاء هذا الحجز؟", "تأكيد الإلغاء", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE Appointments SET Status = 'Cancelled' WHERE AppointmentID = @AppointmentID;";
                    var parameters = new SQLiteParameter[] { new SQLiteParameter("@AppointmentID", _selectedAppId) };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("تم إلغاء الحجز بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAppointments();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء إلغاء الحجز: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAppointments(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedAppId = -1;
            if (cmbPatient.Items.Count > 0) cmbPatient.SelectedIndex = 0;
            if (cmbDoctor.Items.Count > 0) cmbDoctor.SelectedIndex = 0;
            dtpDate.Value = DateTime.Today;
            txtTime.Text = DateTime.Now.ToString("hh:mm tt");
            if (cmbVisitType.Items.Count > 0) cmbVisitType.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            lblSelectedID.Text = "رقم الحجز المحدد: لا يوجد";
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void dgvAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAppointments.Columns[e.ColumnIndex].Name == "Type" && e.Value != null)
            {
                string visitType = e.Value.ToString();
                if (visitType == "Consultation") e.Value = "كشف جديد";
                else if (visitType == "Follow-up") e.Value = "استشارة/متابعة";
            }

            if (dgvAppointments.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Confirmed")
                {
                    e.Value = "مؤكد";
                    e.CellStyle.ForeColor = Color.FromArgb(21, 87, 36);
                    e.CellStyle.BackColor = Color.FromArgb(212, 237, 218);
                }
                else if (status == "Pending")
                {
                    e.Value = "قيد الانتظار";
                    e.CellStyle.ForeColor = Color.FromArgb(133, 100, 4);
                    e.CellStyle.BackColor = Color.FromArgb(255, 243, 205);
                }
                else if (status == "Cancelled")
                {
                    e.Value = "ملغى";
                    e.CellStyle.ForeColor = Color.FromArgb(114, 28, 36);
                    e.CellStyle.BackColor = Color.FromArgb(248, 215, 218);
                }
                else if (status == "Completed")
                {
                    e.Value = "مكتمل";
                    e.CellStyle.ForeColor = Color.FromArgb(0, 64, 133);
                    e.CellStyle.BackColor = Color.FromArgb(204, 229, 255);
                }
            }
        }
    }
}
