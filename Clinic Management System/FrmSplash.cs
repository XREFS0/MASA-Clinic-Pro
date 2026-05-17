using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Clinic_Management_System
{
    public partial class FrmSplash : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Timer loadingTimer;
        private Guna2ProgressBar progressBar;
        private Label lblStatus;
        private Label lblPercentage;
        private Guna2Elipse formElipse;
        private Guna2DragControl dragControl;

        public FrmSplash()
        {
            InitializeComponent();
            SetupFormLayout();
            LoadAppIcon();
        }

        private void LoadAppIcon()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string iconPath = Path.Combine(baseDir, "logo.ico");
                if (!File.Exists(iconPath))
                {
                    iconPath = Path.Combine(baseDir, "..", "..", "logo.ico");
                }

                if (File.Exists(iconPath))
                {
                    this.Icon = new Icon(iconPath);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error loading application icon: " + ex.Message);
            }
        }


        private void SetupFormLayout()
        {
            // Set borderless styling and startup position
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1000;
            this.Height = 600;
            this.DoubleBuffered = true;

            // Load high-resolution background asset
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string iconsPath = Path.Combine(baseDir, "Icons");
            if (!Directory.Exists(iconsPath))
            {
                iconsPath = Path.Combine(baseDir, "..", "..", "Icons");
            }

            string backPath = Path.Combine(iconsPath, "back.png");
            if (File.Exists(backPath))
            {
                try
                {
                    this.BackgroundImage = Image.FromFile(backPath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch
                {
                    this.BackColor = Color.FromArgb(240, 245, 250);
                }
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 245, 250);
            }

            // Round Form corners with premium Guna Elipse
            formElipse = new Guna2Elipse();
            formElipse.BorderRadius = 16;
            formElipse.TargetControl = this;

            // Enable smooth window dragging
            dragControl = new Guna2DragControl();
            dragControl.TargetControl = this;

            // Initialize Guna2 Premium Gradient Progress Bar
            progressBar = new Guna2ProgressBar();
            progressBar.Width = 480;
            progressBar.Height = 12;
            progressBar.BorderRadius = 6;
            progressBar.FillColor = Color.FromArgb(40, 255, 255, 255); // Glossy semi-transparent white track
            progressBar.ProgressColor = Color.FromArgb(0, 102, 204);     // Deep medical blue
            progressBar.ProgressColor2 = Color.FromArgb(0, 204, 255);    // Vibrant cyan glow
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            progressBar.Left = (this.Width - progressBar.Width) / 2;
            progressBar.Top = 472; // Positioned perfectly on top of back.png bar slot
            this.Controls.Add(progressBar);

            // Initialize Loading Status Text Label
            lblStatus = new Label();
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.ForeColor = Color.FromArgb(120, 140, 160); // Elegant clinical slate-blue
            lblStatus.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblStatus.Text = "LOADING MODULES...";
            lblStatus.Top = progressBar.Top - 32;
            this.Controls.Add(lblStatus);
            lblStatus.Left = (this.Width - lblStatus.Width) / 2;

            // Initialize Percentage Label
            lblPercentage = new Label();
            lblPercentage.AutoSize = true;
            lblPercentage.BackColor = Color.Transparent;
            lblPercentage.ForeColor = Color.FromArgb(0, 102, 204); // Vibrant Blue accent
            lblPercentage.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblPercentage.Text = "0%";
            lblPercentage.Top = progressBar.Top + 20;
            this.Controls.Add(lblPercentage);
            lblPercentage.Left = (this.Width - lblPercentage.Width) / 2;

            // Initialize loading Timer
            loadingTimer = new Timer();
            loadingTimer.Interval = 35; // 35ms per tick for smooth loading feel
            loadingTimer.Tick += loadingTimer_Tick;
            
            this.Load += FrmSplash_Load;
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            loadingTimer.Start();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 2;
                lblPercentage.Text = $"{progressBar.Value}%";

                // Premium dynamic status simulator
                if (progressBar.Value < 30)
                {
                    lblStatus.Text = "LOADING CLINICAL MODULES...";
                }
                else if (progressBar.Value < 60)
                {
                    lblStatus.Text = "ESTABLISHING CONNECTIVITY...";
                }
                else if (progressBar.Value < 85)
                {
                    lblStatus.Text = "VALIDATING HEALTHCARE SCHEMA...";
                }
                else
                {
                    lblStatus.Text = "STARTING MASA CLINIC PRO...";
                }

                // Centering adjustment as text width shifts
                lblStatus.Left = (this.Width - lblStatus.Width) / 2;
                lblPercentage.Left = (this.Width - lblPercentage.Width) / 2;
            }
            else
            {
                loadingTimer.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmSplash
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmSplash";
            this.Text = "MASA Clinic Pro";
            this.ResumeLayout(false);

        }
    }
}
