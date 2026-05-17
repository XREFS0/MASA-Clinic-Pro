using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_Payments : UserControl
    {
        public UC_Payments()
        {
            InitializeComponent();
        }

        private void UC_Payments_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;
            dgvPayments.CellFormatting += dgvPayments_CellFormatting;
            LoadPayments();
        }

        private void dgvPayments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPayments.Columns[e.ColumnIndex].Name == "Method" && e.Value != null)
            {
                string methodVal = e.Value.ToString();
                if (methodVal == "Cash") e.Value = "نقداً";
                else if (methodVal == "Card") e.Value = "بطاقة ائتمان";
                else if (methodVal == "Insurance") e.Value = "تأمين طبي";
            }
        }

        private void LoadPayments(string search = "")
        {
            try
            {
                string query = @"
                    SELECT i.InvoiceID AS ReceiptNo, p.Name AS Patient, 
                           i.Amount AS TotalBill, i.Discount, (i.Amount - i.Discount) AS PaidAmount, 
                           i.PaymentMethod AS Method, i.InvoiceDate AS PaymentDate
                    FROM Invoices i
                    JOIN Patients p ON i.PatientID = p.PatientID
                    WHERE date(i.InvoiceDate) BETWEEN date(@FromDate) AND date(@ToDate)";

                SQLiteParameter[] parameters;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    query += " AND (p.Name LIKE @search OR i.PaymentMethod LIKE @search)";
                    parameters = new SQLiteParameter[]
                    {
                        new SQLiteParameter("@FromDate", dtpFrom.Value.ToString("yyyy-MM-dd")),
                        new SQLiteParameter("@ToDate", dtpTo.Value.ToString("yyyy-MM-dd")),
                        new SQLiteParameter("@search", "%" + search + "%")
                    };
                }
                else
                {
                    parameters = new SQLiteParameter[]
                    {
                        new SQLiteParameter("@FromDate", dtpFrom.Value.ToString("yyyy-MM-dd")),
                        new SQLiteParameter("@ToDate", dtpTo.Value.ToString("yyyy-MM-dd"))
                    };
                }

                query += " ORDER BY i.InvoiceDate DESC;";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvPayments.DataSource = dt;

                // Format columns
                if (dgvPayments.Columns.Count > 0)
                {
                    dgvPayments.Columns["ReceiptNo"].HeaderText = "رقم الفاتورة / الإيصال";
                    dgvPayments.Columns["Patient"].HeaderText = "المريض";
                    dgvPayments.Columns["TotalBill"].HeaderText = "المبلغ الإجمالي";
                    dgvPayments.Columns["Discount"].HeaderText = "الخصم الممنوح";
                    dgvPayments.Columns["PaidAmount"].HeaderText = "المبلغ الصافي المدفوع";
                    dgvPayments.Columns["Method"].HeaderText = "طريقة الدفع";
                    dgvPayments.Columns["PaymentDate"].HeaderText = "تاريخ الدفع";
                }

                // Compute total paid summary label
                double sum = 0;
                foreach (DataRow row in dt.Rows)
                {
                    sum += Convert.ToDouble(row["PaidAmount"]);
                }
                lblTotalSummary.Text = $"إجمالي الإيرادات في هذه الفترة: {sum:N2} جنيه مصري";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل المدفوعات: {ex.Message}");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadPayments(txtSearch.Text.Trim());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPayments(txtSearch.Text.Trim());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;
            LoadPayments();
        }
    }
}
