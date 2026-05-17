using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_Prescription : UserControl
    {
        private DataTable _drugsTable;

        public UC_Prescription()
        {
            InitializeComponent();
        }

        private void UC_Prescription_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDoctors();
            InitializeDrugsTable();
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
                MessageBox.Show($"خطأ في تحميل المرضى: {ex.Message}");
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
                MessageBox.Show($"خطأ في تحميل الأطباء: {ex.Message}");
            }
        }

        private void InitializeDrugsTable()
        {
            _drugsTable = new DataTable();
            _drugsTable.Columns.Add("DrugName", typeof(string));
            _drugsTable.Columns.Add("Dosage", typeof(string));
            _drugsTable.Columns.Add("Frequency", typeof(string));
            _drugsTable.Columns.Add("Duration", typeof(string));
            dgvDrugs.DataSource = _drugsTable;

            if (dgvDrugs.Columns.Count > 0)
            {
                dgvDrugs.Columns["DrugName"].HeaderText = "اسم الدواء";
                dgvDrugs.Columns["Dosage"].HeaderText = "الجرعة";
                dgvDrugs.Columns["Frequency"].HeaderText = "التكرار";
                dgvDrugs.Columns["Duration"].HeaderText = "المدة";
            }
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDrugName.Text) || string.IsNullOrWhiteSpace(txtDosage.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الدواء والجرعة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row = _drugsTable.NewRow();
            row["DrugName"] = txtDrugName.Text.Trim();
            row["Dosage"] = txtDosage.Text.Trim();
            row["Frequency"] = txtFrequency.Text.Trim();
            row["Duration"] = txtDuration.Text.Trim();
            _drugsTable.Rows.Add(row);

            txtDrugName.Clear();
            txtDosage.Clear();
            txtFrequency.Clear();
            txtDuration.Clear();
            txtDrugName.Focus();
        }

        private void btnRemoveDrug_Click(object sender, EventArgs e)
        {
            if (dgvDrugs.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDrugs.SelectedRows)
                {
                    dgvDrugs.Rows.Remove(row);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null || cmbDoctor.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار المريض والطبيب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_drugsTable.Rows.Count == 0)
            {
                MessageBox.Show("لا يمكن حفظ الروشتة بدون إدخال أدوية.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Format drugs as text for simple database storage
                string drugsListString = "";
                foreach (DataRow row in _drugsTable.Rows)
                {
                    drugsListString += $"{row["DrugName"]} - الجرعة: {row["Dosage"]} ({row["Frequency"]}) لمدة: {row["Duration"]}\n";
                }

                string query = @"
                    INSERT INTO Prescriptions (PatientID, DoctorID, PrescriptionDate, MedicationList, Notes) 
                    VALUES (@PatientID, @DoctorID, @Date, @MedList, @Notes);";

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@PatientID", cmbPatient.SelectedValue),
                    new SQLiteParameter("@DoctorID", cmbDoctor.SelectedValue),
                    new SQLiteParameter("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new SQLiteParameter("@MedList", drugsListString),
                    new SQLiteParameter("@Notes", txtNotes.Text.Trim())
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم حفظ الروشتة الطبية بنجاح في قاعدة البيانات.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء حفظ الروشتة: {ex.Message}");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار المريض أولاً لعرض معاينة الروشتة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string drugsContent = "";
            int num = 1;
            foreach (DataRow row in _drugsTable.Rows)
            {
                drugsContent += $"{num++}. {row["DrugName"]}  ---  {row["Dosage"]}  ({row["Frequency"]})  [المدة: {row["Duration"]}]\n";
            }

            string printLayout = $@"
=========================================
           روشتة علاجية معتمدة
=========================================
التاريخ: {DateTime.Now.ToShortDateString()}
اسم المريض: {cmbPatient.Text}
الطبيب المعالج: {cmbDoctor.Text}
-----------------------------------------
الأدوية الموصوفة (Rx):
{drugsContent}
-----------------------------------------
ملاحظات وإرشادات: 
{txtNotes.Text}
-----------------------------------------
توقيع وختم الطبيب:
د. {cmbDoctor.Text}
=========================================
";
            MessageBox.Show(printLayout, "معاينة طباعة الروشتة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            if (cmbPatient.Items.Count > 0) cmbPatient.SelectedIndex = 0;
            if (cmbDoctor.Items.Count > 0) cmbDoctor.SelectedIndex = 0;
            txtDrugName.Clear();
            txtDosage.Clear();
            txtFrequency.Clear();
            txtDuration.Clear();
            txtNotes.Clear();
            _drugsTable?.Clear();
        }
    }
}
