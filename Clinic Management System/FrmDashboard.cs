using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Clinic_Management_System
{
    public partial class FrmDashboard : Form
    {
        private UserControl _currentView;
        private Guna2Button _activeButton;

        // Custom colors matching the modern medical white + light blue theme
        private readonly Color ActiveBgColor = Color.FromArgb(0, 122, 255); // Premium Vibrant Blue
        private readonly Color ActiveTxtColor = Color.White;
        private readonly Color NormalBgColor = Color.Transparent;
        private readonly Color NormalTxtColor = Color.FromArgb(80, 90, 100); // Slate gray

        public FrmDashboard()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase(); // Ensure database tables are created and seeded on startup
            LoadIcons(); // Load all custom PNG icons dynamically on startup
            LoadAppIcon(); // Load the logo.ico as the Form icon
        }

        private void LoadAppIcon()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string iconPath = System.IO.Path.Combine(baseDir, "logo.ico");
                if (!System.IO.File.Exists(iconPath))
                {
                    iconPath = System.IO.Path.Combine(baseDir, "..", "..", "logo.ico");
                }

                if (System.IO.File.Exists(iconPath))
                {
                    this.Icon = new Icon(iconPath);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error loading application icon: " + ex.Message);
            }
        }


        private void LoadIcons()
        {
            try
            {
                // Find Icons folder relative to the executable path
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string iconsPath = System.IO.Path.Combine(baseDir, "Icons");

                // If not found in the output directory, check the relative source path (for development)
                if (!System.IO.Directory.Exists(iconsPath))
                {
                    iconsPath = System.IO.Path.Combine(baseDir, "..", "..", "Icons");
                }

                if (System.IO.Directory.Exists(iconsPath))
                {
                    // Local helper to load file safely
                    Image GetIcon(string name)
                    {
                        string path = System.IO.Path.Combine(iconsPath, name);
                        if (System.IO.File.Exists(path))
                        {
                            return Image.FromFile(path);
                        }
                        return null;
                    }

                    // Load Logos and Avatars
                    picLogo.Image = GetIcon("logo.png");
                    picDocAvatar.Image = GetIcon("doctor.png");

                    // Load Searchbox magnifying glass
                    txtSearch.IconRight = GetIcon("search.png");
                    txtSearch.IconRightSize = new Size(16, 16);

                    // Load Notification Bell
                    btnNotification.Image = GetIcon("notification.png");
                    btnNotification.ImageSize = new Size(20, 20);

                    // Load all 13 sidebar navigation button icons
                    btnDashboard.Image = GetIcon("house.png");
                    btnPatients.Image = GetIcon("profile.png");
                    btnDoctors.Image = GetIcon("doctor.png");
                    btnAppointments.Image = GetIcon("appointment.png");
                    btnConsultation.Image = GetIcon("conversation.png");
                    btnPrescription.Image = GetIcon("prescription.png");
                    btnBilling.Image = GetIcon("bill.png");
                    btnPayments.Image = GetIcon("cash-register.png");
                    btnMedicalRecords.Image = GetIcon("health-report.png");
                    btnInventory.Image = GetIcon("inventory.png");
                    btnReports.Image = GetIcon("report.png");
                    btnSettings.Image = GetIcon("cogwheel.png");
                    btnExit.Image = GetIcon("logout.png");

                    // Dynamic layout alignment and premium styling for sidebar buttons
                    int currentY = 65;
                    var buttons = new Guna2Button[]
                    {
                        btnDashboard, btnPatients, btnDoctors, btnAppointments,
                        btnConsultation, btnPrescription, btnBilling, btnPayments,
                        btnMedicalRecords, btnInventory, btnReports, btnSettings, btnExit
                    };

                    foreach (var btn in buttons)
                    {
                        if (btn != null)
                        {
                            // Premium enlargement & sizing (Even Larger)
                            btn.Height = 46; 
                            btn.Location = new Point(10, currentY);
                            currentY += 49; // Height (46) + Gap (3)

                            // Sleek clinical typography (Arabic friendly - Larger)
                            btn.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold);

                            if (btn.Image != null)
                            {
                                btn.ImageSize = new Size(28, 28); // Ultra HD enlarged icons
                                btn.ImageAlign = HorizontalAlignment.Right;
                                btn.TextAlign = HorizontalAlignment.Right;
                                btn.ImageOffset = new Point(12, 0);
                                btn.TextOffset = new Point(26, 0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error loading icons dynamically: " + ex.Message);
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxWindow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            // Initialize all navigation buttons to their normal state first
            ResetAllButtons();

            // Initialize with the Dashboard view
            btnDashboard_Click(btnDashboard, EventArgs.Empty);

            // Start the Clock Timer to update Topbar time in real-time
            tmrClock.Start();
            UpdateClock();
        }

        private void ResetAllButtons()
        {
            var buttons = new Guna2Button[]
            {
                btnDashboard, btnPatients, btnDoctors, btnAppointments,
                btnConsultation, btnPrescription, btnBilling, btnPayments,
                btnMedicalRecords, btnInventory, btnReports, btnSettings, btnExit
            };

            foreach (var btn in buttons)
            {
                if (btn != null)
                {
                    btn.FillColor = NormalBgColor;
                    btn.ForeColor = NormalTxtColor;
                    btn.ImageSize = new Size(20, 20);
                    btn.ImageAlign = HorizontalAlignment.Right;
                    btn.TextAlign = HorizontalAlignment.Right;
                    btn.ImageOffset = new Point(8, 0);
                    btn.TextOffset = new Point(18, 0);
                    
                    // Premium UI/UX: Set beautiful hover states
                    btn.HoverState.FillColor = Color.FromArgb(240, 244, 248);
                    btn.HoverState.ForeColor = Color.FromArgb(0, 122, 255);
                }
            }
        }

        // Shared View Switcher logic
        public void SwitchView(UserControl newView, Guna2Button clickedButton)
        {
            if (newView == null) return;

            // Highlight the active button
            if (_activeButton != null)
            {
                _activeButton.FillColor = NormalBgColor;
                _activeButton.ForeColor = NormalTxtColor;
                _activeButton.ImageSize = new Size(20, 20);
                _activeButton.ImageAlign = HorizontalAlignment.Right;
                _activeButton.TextAlign = HorizontalAlignment.Right;
                _activeButton.ImageOffset = new Point(8, 0);
                _activeButton.TextOffset = new Point(18, 0);
            }

            _activeButton = clickedButton;

            if (_activeButton != null)
            {
                _activeButton.FillColor = ActiveBgColor;
                _activeButton.ForeColor = ActiveTxtColor;
                _activeButton.ImageSize = new Size(20, 20); // Keep size consistent for stable, non-jumping look
                _activeButton.ImageAlign = HorizontalAlignment.Right;
                _activeButton.TextAlign = HorizontalAlignment.Right;
                _activeButton.ImageOffset = new Point(8, 0);
                _activeButton.TextOffset = new Point(18, 0);
            }

            // Remove current control and load the new one
            pnlContent.Controls.Clear();
            _currentView = newView;
            _currentView.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(_currentView);
        }

        // Sidebar Navigation Event Handlers
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Dashboard(this), (Guna2Button)sender);
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Patients(), (Guna2Button)sender);
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Doctors(), (Guna2Button)sender);
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Appointments(), (Guna2Button)sender);
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Consultation(), (Guna2Button)sender);
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Prescription(), (Guna2Button)sender);
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Billing(), (Guna2Button)sender);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Payments(), (Guna2Button)sender);
        }

        private void btnMedicalRecords_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_MedicalRecords(), (Guna2Button)sender);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Inventory(), (Guna2Button)sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Reports(), (Guna2Button)sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SwitchView(new UC_Settings(), (Guna2Button)sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت متأكد من رغبتك في الخروج؟", "خروج من النظام", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Clock tick event
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            lblDateTime.Text = DateTime.Now.ToString("dd MMMM, yyyy | hh:mm:ss tt", new System.Globalization.CultureInfo("ar-EG"));
        }

        // Public switcher helper so quick actions from other controls can trigger tab changes
        public void NavigateTo(string tabName)
        {
            switch (tabName.ToLower())
            {
                case "dashboard":
                    btnDashboard_Click(btnDashboard, EventArgs.Empty);
                    break;
                case "patients":
                    btnPatients_Click(btnPatients, EventArgs.Empty);
                    break;
                case "doctors":
                    btnDoctors_Click(btnDoctors, EventArgs.Empty);
                    break;
                case "appointments":
                    btnAppointments_Click(btnAppointments, EventArgs.Empty);
                    break;
                case "consultation":
                    btnConsultation_Click(btnConsultation, EventArgs.Empty);
                    break;
                case "prescription":
                    btnPrescription_Click(btnPrescription, EventArgs.Empty);
                    break;
                case "billing":
                    btnBilling_Click(btnBilling, EventArgs.Empty);
                    break;
                case "payments":
                    btnPayments_Click(btnPayments, EventArgs.Empty);
                    break;
                case "medicalrecords":
                    btnMedicalRecords_Click(btnMedicalRecords, EventArgs.Empty);
                    break;
                case "inventory":
                    btnInventory_Click(btnInventory, EventArgs.Empty);
                    break;
                case "reports":
                    btnReports_Click(btnReports, EventArgs.Empty);
                    break;
                case "settings":
                    btnSettings_Click(btnSettings, EventArgs.Empty);
                    break;
            }
        }
    }
}
