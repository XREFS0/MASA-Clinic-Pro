using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_Billing : UserControl
    {
        private int _selectedInvoiceId = -1;

        public UC_Billing()
        {
            InitializeComponent();
        }

        private void UC_Billing_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDropdowns();
            LoadInvoices();
            dgvInvoices.CellFormatting += dgvInvoices_CellFormatting;
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

        private void LoadDropdowns()
        {
            try
            {
                cmbMethod.DataSource = new System.Collections.Generic.KeyValuePair<string, string>[] {
                    new System.Collections.Generic.KeyValuePair<string, string>("Cash", "نقداً"),
                    new System.Collections.Generic.KeyValuePair<string, string>("Card", "بطاقة ائتمان"),
                    new System.Collections.Generic.KeyValuePair<string, string>("Insurance", "تأمين طبي")
                };
                cmbMethod.DisplayMember = "Value";
                cmbMethod.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل طرق الدفع: {ex.Message}");
            }
        }

        private void LoadInvoices()
        {
            try
            {
                string query = @"
                    SELECT i.InvoiceID, p.Name AS Patient, i.Amount AS TotalAmount, 
                           i.Discount, (i.Amount - i.Discount) AS NetAmount, 
                           i.PaymentMethod AS Method, i.InvoiceDate AS Date, i.PatientID
                    FROM Invoices i
                    JOIN Patients p ON i.PatientID = p.PatientID
                    ORDER BY i.InvoiceDate DESC;";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvInvoices.DataSource = dt;

                if (dgvInvoices.Columns.Count > 0)
                {
                    dgvInvoices.Columns["InvoiceID"].HeaderText = "رقم الفاتورة";
                    dgvInvoices.Columns["Patient"].HeaderText = "المريض";
                    dgvInvoices.Columns["TotalAmount"].HeaderText = "المبلغ الإجمالي";
                    dgvInvoices.Columns["Discount"].HeaderText = "الخصم";
                    dgvInvoices.Columns["NetAmount"].HeaderText = "الصافي";
                    dgvInvoices.Columns["Method"].HeaderText = "طريقة الدفع";
                    dgvInvoices.Columns["Date"].HeaderText = "التاريخ";
                    dgvInvoices.Columns["PatientID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل الفواتير: {ex.Message}");
            }
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInvoices.Rows[e.RowIndex];
                _selectedInvoiceId = Convert.ToInt32(row.Cells["InvoiceID"].Value);

                cmbPatient.SelectedValue = Convert.ToInt32(row.Cells["PatientID"].Value);
                txtAmount.Text = row.Cells["TotalAmount"].Value.ToString();
                txtDiscount.Text = row.Cells["Discount"].Value.ToString();
                cmbMethod.SelectedValue = row.Cells["Method"].Value.ToString();

                CalculateNetTotal();
                lblSelectedID.Text = $"الفاتورة المحددة: {_selectedInvoiceId}";
                btnDelete.Enabled = true;
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateNetTotal();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateNetTotal();
        }

        private void CalculateNetTotal()
        {
            double gross = 0;
            double discount = 0;

            double.TryParse(txtAmount.Text, out gross);
            double.TryParse(txtDiscount.Text, out discount);

            double net = gross - discount;
            lblNetTotalVal.Text = $"{net:N2} ج.م";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("يرجى اختيار المريض وتحديد قيمة الفاتورة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double gross = 0;
                double discount = 0;

                double.TryParse(txtAmount.Text, out gross);
                double.TryParse(txtDiscount.Text, out discount);

                string query = @"
                    INSERT INTO Invoices (PatientID, Amount, TotalAmount, Discount, PaymentMethod, InvoiceDate, CreatedAt, IsPaid) 
                    VALUES (@PatientID, @Amount, @TotalAmount, @Discount, @Method, @Date, @CreatedAt, 1);";

                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@PatientID", cmbPatient.SelectedValue),
                    new SQLiteParameter("@Amount", gross),
                    new SQLiteParameter("@TotalAmount", gross),
                    new SQLiteParameter("@Discount", discount),
                    new SQLiteParameter("@Method", cmbMethod.SelectedValue?.ToString() ?? cmbMethod.Text),
                    new SQLiteParameter("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new SQLiteParameter("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd"))
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم إصدار وحفظ الفاتورة بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInvoices();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء إصدار الفاتورة: {ex.Message}");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("يرجى ملء بيانات الفاتورة لعرض معاينة الطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double gross = 0;
            double discount = 0;

            double.TryParse(txtAmount.Text, out gross);
            double.TryParse(txtDiscount.Text, out discount);
            double net = gross - discount;

            string receipt = $@"
=========================================
            فاتورة العيادة الطبية
=========================================
تاريخ الفاتورة: {DateTime.Now.ToShortDateString()}
اسم المريض: {cmbPatient.Text}
-----------------------------------------
المبلغ الإجمالي:    {gross:N2} ج.م
الخصم المطبق:    {discount:N2} ج.م
-----------------------------------------
الصافي المدفوع:  {net:N2} ج.م
طريقة الدفع:    {cmbMethod.Text}
-----------------------------------------
حالة الفاتورة: تم الدفع بنجاح
نشكركم على زيارتكم!
=========================================
";
            MessageBox.Show(receipt, "معاينة الفاتورة للطباعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedInvoiceId == -1) return;

            var result = MessageBox.Show("هل أنت متأكد من حذف هذه الفاتورة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Invoices WHERE InvoiceID = @InvoiceID;";
                    var parameters = new SQLiteParameter[] { new SQLiteParameter("@InvoiceID", _selectedInvoiceId) };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("تم حذف الفاتورة بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInvoices();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء حذف الفاتورة: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedInvoiceId = -1;
            if (cmbPatient.Items.Count > 0) cmbPatient.SelectedIndex = 0;
            txtAmount.Clear();
            txtDiscount.Text = "0";
            if (cmbMethod.Items.Count > 0) cmbMethod.SelectedIndex = 0;
            lblNetTotalVal.Text = "0.00 ج.م";
            lblSelectedID.Text = "الفاتورة المحددة: لا يوجد";
            btnDelete.Enabled = false;
        }

        private void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInvoices.Columns[e.ColumnIndex].Name == "Method" && e.Value != null)
            {
                string method = e.Value.ToString();
                if (method == "Cash") e.Value = "نقداً";
                else if (method == "Card") e.Value = "بطاقة ائتمان";
                else if (method == "Insurance") e.Value = "تأمين طبي";
            }
        }
    }
}
