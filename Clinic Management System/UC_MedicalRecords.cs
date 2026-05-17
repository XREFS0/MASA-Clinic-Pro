using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_MedicalRecords : UserControl
    {
        public UC_MedicalRecords()
        {
            InitializeComponent();
        }

        private void UC_MedicalRecords_Load(object sender, EventArgs e)
        {
            LoadPatients();
            dgvBillings.CellFormatting += dgvBillings_CellFormatting;
        }

        private void dgvBillings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBillings.Columns[e.ColumnIndex].Name == "Method" && e.Value != null)
            {
                string methodVal = e.Value.ToString();
                if (methodVal == "Cash") e.Value = "نقداً";
                else if (methodVal == "Card") e.Value = "بطاقة ائتمان";
                else if (methodVal == "Insurance") e.Value = "تأمين طبي";
            }
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
                MessageBox.Show($"خطأ في تحميل المرضى: {ex.Message}");
            }
        }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue != null && int.TryParse(cmbPatient.SelectedValue.ToString(), out int patientId))
            {
                LoadPatientDossier(patientId);
            }
        }

        private void LoadPatientDossier(int patientId)
        {
            try
            {
                // 1. Patient Bio details
                DataTable dtBio = DatabaseHelper.ExecuteQuery(
                    "SELECT Age, Gender, Phone, Address, MedicalHistory FROM Patients WHERE PatientID = @PatientID;",
                    new SQLiteParameter[] { new SQLiteParameter("@PatientID", patientId) }
                );

                if (dtBio.Rows.Count > 0)
                {
                    DataRow row = dtBio.Rows[0];
                    lblAgeVal.Text = $"{row["Age"]} عام";
                    string gender = row["Gender"].ToString();
                    lblGenderVal.Text = gender == "Male" ? "ذكر" : (gender == "Female" ? "أنثى" : gender);
                    lblPhoneVal.Text = row["Phone"].ToString();
                    lblAddressVal.Text = row["Address"].ToString();
                    txtMedHistorySummary.Text = row["MedicalHistory"].ToString();
                }

                // 2. Visits Timeline
                DataTable dtVisits = DatabaseHelper.ExecuteQuery(@"
                    SELECT c.ConsultationDate AS Date, d.Name AS Doctor, c.Vitals_BP AS BP, 
                           c.Vitals_Temp AS Temp, c.ChiefComplaint AS Complaint, c.Diagnosis, c.TreatmentPlan
                    FROM Consultations c
                    JOIN Doctors d ON c.DoctorID = d.DoctorID
                    WHERE c.PatientID = @PatientID
                    ORDER BY c.ConsultationDate DESC;",
                    new SQLiteParameter[] { new SQLiteParameter("@PatientID", patientId) }
                );
                dgvVisits.DataSource = dtVisits;
                if (dgvVisits.Columns.Count > 0)
                {
                    dgvVisits.Columns["Date"].HeaderText = "التاريخ";
                    dgvVisits.Columns["Doctor"].HeaderText = "الطبيب المعالج";
                    dgvVisits.Columns["BP"].HeaderText = "ضغط الدم";
                    dgvVisits.Columns["Temp"].HeaderText = "الحرارة (م°)";
                    dgvVisits.Columns["Complaint"].HeaderText = "الشكوى";
                    dgvVisits.Columns["Diagnosis"].HeaderText = "التشخيص";
                    dgvVisits.Columns["TreatmentPlan"].HeaderText = "الخطة العلاجية";
                }

                // 3. Prescriptions list
                DataTable dtPrescriptions = DatabaseHelper.ExecuteQuery(@"
                    SELECT p.PrescriptionDate AS Date, d.Name AS Doctor, p.MedicationList AS Meds, p.Notes
                    FROM Prescriptions p
                    JOIN Doctors d ON p.DoctorID = d.DoctorID
                    WHERE p.PatientID = @PatientID
                    ORDER BY p.PrescriptionDate DESC;",
                    new SQLiteParameter[] { new SQLiteParameter("@PatientID", patientId) }
                );
                dgvPrescriptions.DataSource = dtPrescriptions;
                if (dgvPrescriptions.Columns.Count > 0)
                {
                    dgvPrescriptions.Columns["Date"].HeaderText = "التاريخ";
                    dgvPrescriptions.Columns["Doctor"].HeaderText = "الطبيب المعالج";
                    dgvPrescriptions.Columns["Meds"].HeaderText = "الأدوية الموصوفة";
                    dgvPrescriptions.Columns["Notes"].HeaderText = "ملاحظات";
                }

                // 4. Billings list
                DataTable dtBillings = DatabaseHelper.ExecuteQuery(@"
                    SELECT i.InvoiceDate AS Date, i.Amount AS Gross, i.Discount, (i.Amount - i.Discount) AS Net, i.PaymentMethod AS Method
                    FROM Invoices i
                    WHERE i.PatientID = @PatientID
                    ORDER BY i.InvoiceDate DESC;",
                    new SQLiteParameter[] { new SQLiteParameter("@PatientID", patientId) }
                );
                dgvBillings.DataSource = dtBillings;
                if (dgvBillings.Columns.Count > 0)
                {
                    dgvBillings.Columns["Date"].HeaderText = "التاريخ";
                    dgvBillings.Columns["Gross"].HeaderText = "الإجمالي";
                    dgvBillings.Columns["Discount"].HeaderText = "الخصم";
                    dgvBillings.Columns["Net"].HeaderText = "الصافي";
                    dgvBillings.Columns["Method"].HeaderText = "طريقة الدفع";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل الملف الطبي: {ex.Message}");
            }
        }
    }
}
