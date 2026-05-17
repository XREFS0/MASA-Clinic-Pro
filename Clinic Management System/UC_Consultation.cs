using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_Consultation : UserControl
    {
        private int _selectedConsultationId = -1;

        public UC_Consultation()
        {
            InitializeComponent();
        }

        private void UC_Consultation_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDoctors();
            LoadConsultations();
            ClearForm();
        }

        private void LoadPatients()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT PatientID, Name FROM Patients ORDER BY Name ASC;");
                cmbPatient.DataSource = dt;
                cmbPatient.DisplayMember = "Name";
                cmbPatient.ValueMember = "PatientID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل المرضى: {ex.Message}");
            }
        }

        private void LoadDoctors()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT DoctorID, Name FROM Doctors ORDER BY Name ASC;");
                cmbDoctor.DataSource = dt;
                cmbDoctor.DisplayMember = "Name";
                cmbDoctor.ValueMember = "DoctorID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل الأطباء: {ex.Message}");
            }
        }

        private void LoadConsultations(int patientId = -1)
        {
            try
            {
                string query = @"
                    SELECT c.ConsultationID, p.Name AS Patient, d.Name AS Doctor, 
                           c.ConsultationDate AS Date, c.Vitals_BP AS BP, c.Vitals_Temp AS Temp, 
                           c.Vitals_Weight AS Weight, c.ChiefComplaint, c.Diagnosis, c.TreatmentPlan, c.PatientID, c.DoctorID
                    FROM Consultations c
                    JOIN Patients p ON c.PatientID = p.PatientID
                    JOIN Doctors d ON c.DoctorID = d.DoctorID";
                
                SQLiteParameter[] parameters = null;
                if (patientId != -1)
                {
                    query += " WHERE c.PatientID = @PatientID";
                    parameters = new SQLiteParameter[] { new SQLiteParameter("@PatientID", patientId) };
                }

                query += " ORDER BY c.ConsultationDate DESC;";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvConsultations.DataSource = dt;

                if (dgvConsultations.Columns.Count > 0)
                {
                    dgvConsultations.Columns["ConsultationID"].HeaderText = "رقم الكشف";
                    dgvConsultations.Columns["Patient"].HeaderText = "المريض";
                    dgvConsultations.Columns["Doctor"].HeaderText = "الطبيب";
                    dgvConsultations.Columns["Date"].HeaderText = "التاريخ";
                    dgvConsultations.Columns["BP"].HeaderText = "ضغط الدم";
                    dgvConsultations.Columns["Temp"].HeaderText = "الحرارة (م°)";
                    dgvConsultations.Columns["Weight"].HeaderText = "الوزن (كجم)";
                    dgvConsultations.Columns["ChiefComplaint"].Visible = false;
                    dgvConsultations.Columns["Diagnosis"].Visible = false;
                    dgvConsultations.Columns["TreatmentPlan"].Visible = false;
                    dgvConsultations.Columns["PatientID"].Visible = false;
                    dgvConsultations.Columns["DoctorID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل سجل الكشوفات: {ex.Message}");
            }
        }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue != null && int.TryParse(cmbPatient.SelectedValue.ToString(), out int patientId))
            {
                LoadConsultations(patientId);
            }
        }

        private void dgvConsultations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvConsultations.Rows[e.RowIndex];
                _selectedConsultationId = Convert.ToInt32(row.Cells["ConsultationID"].Value);

                cmbPatient.SelectedValue = Convert.ToInt32(row.Cells["PatientID"].Value);
                cmbDoctor.SelectedValue = Convert.ToInt32(row.Cells["DoctorID"].Value);

                txtBP.Text = row.Cells["BP"].Value.ToString();
                txtTemp.Text = row.Cells["Temp"].Value.ToString();
                txtWeight.Text = row.Cells["Weight"].Value.ToString();
                
                txtComplaint.Text = row.Cells["ChiefComplaint"].Value.ToString();
                txtDiagnosis.Text = row.Cells["Diagnosis"].Value.ToString();
                txtTreatment.Text = row.Cells["TreatmentPlan"].Value.ToString();

                lblSelectedID.Text = $"الكشف المحدد: {_selectedConsultationId}";
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null || cmbDoctor.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار المريض والطبيب قبل حفظ الكشف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    INSERT INTO Consultations (PatientID, DoctorID, ConsultationDate, Vitals_BP, BP, Vitals_Temp, Temp, Vitals_Weight, Weight, ChiefComplaint, Complaint, Diagnosis, TreatmentPlan, Treatment) 
                    VALUES (@PatientID, @DoctorID, @Date, @BP, @BP, @Temp, @Temp, @Weight, @Weight, @Complaint, @Complaint, @Diagnosis, @Treatment, @Treatment);";

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@PatientID", cmbPatient.SelectedValue),
                    new SQLiteParameter("@DoctorID", cmbDoctor.SelectedValue),
                    new SQLiteParameter("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new SQLiteParameter("@BP", txtBP.Text.Trim()),
                    new SQLiteParameter("@Temp", txtTemp.Text.Trim()),
                    new SQLiteParameter("@Weight", txtWeight.Text.Trim()),
                    new SQLiteParameter("@Complaint", txtComplaint.Text.Trim()),
                    new SQLiteParameter("@Diagnosis", txtDiagnosis.Text.Trim()),
                    new SQLiteParameter("@Treatment", txtTreatment.Text.Trim())
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم حفظ بيانات الكشف الطبي بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadConsultations((int)cmbPatient.SelectedValue);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء حفظ الكشف: {ex.Message}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedConsultationId == -1) return;

            try
            {
                string query = @"
                    UPDATE Consultations 
                    SET PatientID = @PatientID, DoctorID = @DoctorID, Vitals_BP = @BP, BP = @BP, Vitals_Temp = @Temp, Temp = @Temp, 
                        Vitals_Weight = @Weight, Weight = @Weight, ChiefComplaint = @Complaint, Complaint = @Complaint, 
                        Diagnosis = @Diagnosis, TreatmentPlan = @Treatment, Treatment = @Treatment 
                    WHERE ConsultationID = @ConsultationID;";

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@PatientID", cmbPatient.SelectedValue),
                    new SQLiteParameter("@DoctorID", cmbDoctor.SelectedValue),
                    new SQLiteParameter("@BP", txtBP.Text.Trim()),
                    new SQLiteParameter("@Temp", txtTemp.Text.Trim()),
                    new SQLiteParameter("@Weight", txtWeight.Text.Trim()),
                    new SQLiteParameter("@Complaint", txtComplaint.Text.Trim()),
                    new SQLiteParameter("@Diagnosis", txtDiagnosis.Text.Trim()),
                    new SQLiteParameter("@Treatment", txtTreatment.Text.Trim()),
                    new SQLiteParameter("@ConsultationID", _selectedConsultationId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم تعديل الكشف بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadConsultations((int)cmbPatient.SelectedValue);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء التعديل: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedConsultationId == -1) return;

            var result = MessageBox.Show("هل أنت متأكد من حذف هذا الكشف الطبي نهائياً؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Consultations WHERE ConsultationID = @ConsultationID;";
                    var parameters = new SQLiteParameter[] { new SQLiteParameter("@ConsultationID", _selectedConsultationId) };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("تم حذف الكشف بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadConsultations();
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
            _selectedConsultationId = -1;
            txtBP.Clear();
            txtTemp.Clear();
            txtWeight.Clear();
            txtComplaint.Clear();
            txtDiagnosis.Clear();
            txtTreatment.Clear();
            lblSelectedID.Text = "الكشف المحدد: لا يوجد";
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }
    }
}
