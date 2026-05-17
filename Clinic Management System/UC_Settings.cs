using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT * FROM Settings LIMIT 1;");
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtClinicName.Text = row["ClinicName"].ToString();
                    txtClinicPhone.Text = row["ClinicPhone"].ToString();
                    txtClinicAddress.Text = row["ClinicAddress"].ToString();
                    txtLogoPath.Text = row["LogoPath"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل الإعدادات: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClinicName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم العيادة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if any settings exist
                object countObj = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Settings;");
                int count = Convert.ToInt32(countObj);

                string query = "";
                SQLiteParameter[] parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Name", txtClinicName.Text.Trim()),
                    new SQLiteParameter("@Phone", txtClinicPhone.Text.Trim()),
                    new SQLiteParameter("@Address", txtClinicAddress.Text.Trim()),
                    new SQLiteParameter("@Logo", txtLogoPath.Text.Trim())
                };

                if (count > 0)
                {
                    query = @"
                        UPDATE Settings 
                        SET ClinicName = @Name, ClinicPhone = @Phone, ContactInfo = @Phone, ClinicAddress = @Address, LogoPath = @Logo;";
                }
                else
                {
                    query = @"
                        INSERT INTO Settings (ClinicName, ClinicPhone, ContactInfo, ClinicAddress, LogoPath) 
                        VALUES (@Name, @Phone, @Phone, @Address, @Logo);";
                }

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("تم حفظ الإعدادات العامة بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء حفظ الإعدادات: {ex.Message}");
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "SQLite Database (*.db)|*.db";
                sfd.FileName = $"clinic_backup_{DateTime.Now:yyyyMMdd_HHmmss}.db";
                sfd.Title = "إنشاء نسخة احتياطية لقاعدة البيانات";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clinic.db");
                        if (File.Exists(sourcePath))
                        {
                            File.Copy(sourcePath, sfd.FileName, true);
                            MessageBox.Show("تم إنشاء نسخة احتياطية من قاعدة البيانات بنجاح.", "تم النسخ الاحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على ملف قاعدة البيانات الأصلي.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"خطأ أثناء إنشاء النسخة الاحتياطية: {ex.Message}");
                    }
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("تحذير: استعادة قاعدة البيانات ستؤدي إلى استبدال البيانات الحالية بالكامل. هل تريد الاستمرار؟", "تأكيد الاستعادة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "SQLite Database (*.db)|*.db";
                    ofd.Title = "استعادة قاعدة البيانات من ملف";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clinic.db");
                            
                            // Close sqlite connections before replacing database file
                            GC.Collect();
                            GC.WaitForPendingFinalizers();

                            File.Copy(ofd.FileName, destPath, true);
                            MessageBox.Show("تمت استعادة قاعدة البيانات بنجاح. يرجى إعادة تشغيل البرنامج لتطبيق التغييرات.", "تمت الاستعادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSettings();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"خطأ أثناء استعادة قاعدة البيانات: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
