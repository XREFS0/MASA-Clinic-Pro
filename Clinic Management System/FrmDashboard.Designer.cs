namespace Clinic_Management_System
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicalRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayments = new Guna.UI2.WinForms.Guna2Button();
            this.btnBilling = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrescription = new Guna.UI2.WinForms.Guna2Button();
            this.btnConsultation = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppointments = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDocProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDocSpecialty = new System.Windows.Forms.Label();
            this.lblDocName = new System.Windows.Forms.Label();
            this.picDocAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.picLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlTopbar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnNotification = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragTopbar = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dragSidebar = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.animateForm = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnCloseWindow = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinWindow = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMaxWindow = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlSidebar.SuspendLayout();
            this.pnlDocProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDocAvatar)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTopbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnInventory);
            this.pnlSidebar.Controls.Add(this.btnMedicalRecords);
            this.pnlSidebar.Controls.Add(this.btnPayments);
            this.pnlSidebar.Controls.Add(this.btnBilling);
            this.pnlSidebar.Controls.Add(this.btnPrescription);
            this.pnlSidebar.Controls.Add(this.btnConsultation);
            this.pnlSidebar.Controls.Add(this.btnAppointments);
            this.pnlSidebar.Controls.Add(this.btnDoctors);
            this.pnlSidebar.Controls.Add(this.btnPatients);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            // this.pnlSidebar.Controls.Add(this.pnlDocProfile);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.FillColor = System.Drawing.Color.White;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pnlSidebar.ShadowDecoration.Enabled = true;
            this.pnlSidebar.ShadowDecoration.Depth = 15;
            this.pnlSidebar.Size = new System.Drawing.Size(260, 781);
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.AutoScroll = true;
            // 
            this.btnExit.Location = new System.Drawing.Point(10, 521);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 36);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "تسجيل الخروج";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            this.btnSettings.Location = new System.Drawing.Point(10, 483);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(240, 36);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "إعدادات النظام";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            this.btnReports.Location = new System.Drawing.Point(10, 445);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(240, 36);
            this.btnReports.TabIndex = 11;
            this.btnReports.Text = "التقارير والإحصائيات";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            this.btnInventory.Location = new System.Drawing.Point(10, 407);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(240, 36);
            this.btnInventory.TabIndex = 10;
            this.btnInventory.Text = "المخزن والمستندات";
            this.btnInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            this.btnMedicalRecords.Location = new System.Drawing.Point(10, 369);
            this.btnMedicalRecords.Name = "btnMedicalRecords";
            this.btnMedicalRecords.Size = new System.Drawing.Size(240, 36);
            this.btnMedicalRecords.TabIndex = 9;
            this.btnMedicalRecords.Text = "السجلات الطبية";
            this.btnMedicalRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMedicalRecords.Click += new System.EventHandler(this.btnMedicalRecords_Click);
            // 
            this.btnPayments.Location = new System.Drawing.Point(10, 331);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(240, 36);
            this.btnPayments.TabIndex = 8;
            this.btnPayments.Text = "سجل المدفوعات";
            this.btnPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            this.btnBilling.Location = new System.Drawing.Point(10, 293);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(240, 36);
            this.btnBilling.TabIndex = 7;
            this.btnBilling.Text = "الفواتير والمالية";
            this.btnBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            this.btnPrescription.Location = new System.Drawing.Point(10, 255);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(240, 36);
            this.btnPrescription.TabIndex = 6;
            this.btnPrescription.Text = "الوصفات الطبية";
            this.btnPrescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            this.btnConsultation.Location = new System.Drawing.Point(10, 217);
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Size = new System.Drawing.Size(240, 36);
            this.btnConsultation.TabIndex = 5;
            this.btnConsultation.Text = "الاستشارات والكشف";
            this.btnConsultation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnConsultation.Click += new System.EventHandler(this.btnConsultation_Click);
            // 
            this.btnAppointments.Location = new System.Drawing.Point(10, 179);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(240, 36);
            this.btnAppointments.TabIndex = 4;
            this.btnAppointments.Text = "مواعيد وحجوزات";
            this.btnAppointments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            this.btnDoctors.Location = new System.Drawing.Point(10, 141);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(240, 36);
            this.btnDoctors.TabIndex = 3;
            this.btnDoctors.Text = "الأطباء";
            this.btnDoctors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            this.btnPatients.Location = new System.Drawing.Point(10, 103);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(240, 36);
            this.btnPatients.TabIndex = 2;
            this.btnPatients.Text = "المرضى";
            this.btnPatients.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            this.btnDashboard.Location = new System.Drawing.Point(10, 65);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(240, 36);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "لوحة التحكم";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlDocProfile
            // 
            this.pnlDocProfile.Controls.Add(this.lblDocSpecialty);
            this.pnlDocProfile.Controls.Add(this.lblDocName);
            this.pnlDocProfile.Controls.Add(this.picDocAvatar);
            this.pnlDocProfile.Location = new System.Drawing.Point(0, 60);
            this.pnlDocProfile.Name = "pnlDocProfile";
            this.pnlDocProfile.Size = new System.Drawing.Size(260, 60);
            this.pnlDocProfile.TabIndex = 0;
            // 
            // lblDocSpecialty
            // 
            this.lblDocSpecialty.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.lblDocSpecialty.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDocSpecialty.Location = new System.Drawing.Point(20, 30);
            this.lblDocSpecialty.Name = "lblDocSpecialty";
            this.lblDocSpecialty.Size = new System.Drawing.Size(180, 15);
            this.lblDocSpecialty.TabIndex = 2;
            this.lblDocSpecialty.Text = "كبير أطباء القلب";
            this.lblDocSpecialty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDocName
            // 
            this.lblDocName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDocName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblDocName.Location = new System.Drawing.Point(20, 10);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(180, 20);
            this.lblDocName.TabIndex = 1;
            this.lblDocName.Text = "د. يوسف علي";
            this.lblDocName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picDocAvatar
            // 
            this.picDocAvatar.ImageRotate = 0F;
            this.picDocAvatar.Location = new System.Drawing.Point(208, 10);
            this.picDocAvatar.Name = "picDocAvatar";
            this.picDocAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picDocAvatar.Size = new System.Drawing.Size(40, 40);
            this.picDocAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDocAvatar.TabIndex = 0;
            this.picDocAvatar.TabStop = false;
            this.picDocAvatar.FillColor = System.Drawing.Color.LightGray;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblBrand);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(260, 60);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblBrand.Location = new System.Drawing.Point(20, 12);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(180, 35);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "ماصا كلينك برو";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picLogo
            // 
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(209, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picLogo.Size = new System.Drawing.Size(35, 35);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.White;
            this.pnlTopbar.Controls.Add(this.btnCloseWindow);
            this.pnlTopbar.Controls.Add(this.btnMinWindow);
            this.pnlTopbar.Controls.Add(this.btnMaxWindow);
            this.pnlTopbar.Controls.Add(this.lblDateTime);
            this.pnlTopbar.Controls.Add(this.btnNotification);
            this.pnlTopbar.Controls.Add(this.txtSearch);
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.FillColor = System.Drawing.Color.White;
            this.pnlTopbar.Location = new System.Drawing.Point(260, 0);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.pnlTopbar.ShadowDecoration.Enabled = true;
            this.pnlTopbar.ShadowDecoration.Depth = 5;
            this.pnlTopbar.Size = new System.Drawing.Size(1024, 60);
            this.pnlTopbar.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblDateTime.Location = new System.Drawing.Point(692, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(260, 23);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "التاريخ والوقت الحالي";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNotification
            // 
            this.btnNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotification.BorderRadius = 15;
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotification.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnNotification.Location = new System.Drawing.Point(968, 12);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(35, 35);
            this.btnNotification.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 18;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(85, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "ابحث عن المرضى، السجلات، الأدوية...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(320, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(86)))));
            this.btnCloseWindow.Location = new System.Drawing.Point(15, 23);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(14, 14);
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.TabIndex = 97;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnMinWindow
            // 
            this.btnMinWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(46)))));
            this.btnMinWindow.Location = new System.Drawing.Point(55, 23);
            this.btnMinWindow.Name = "btnMinWindow";
            this.btnMinWindow.Size = new System.Drawing.Size(14, 14);
            this.btnMinWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinWindow.TabIndex = 98;
            this.btnMinWindow.Click += new System.EventHandler(this.btnMinWindow_Click);
            // 
            // btnMaxWindow
            // 
            this.btnMaxWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(201)))), ((int)(((byte)(63)))));
            this.btnMaxWindow.Location = new System.Drawing.Point(35, 23);
            this.btnMaxWindow.Name = "btnMaxWindow";
            this.btnMaxWindow.Size = new System.Drawing.Size(14, 14);
            this.btnMaxWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxWindow.TabIndex = 99;
            this.btnMaxWindow.Click += new System.EventHandler(this.btnMaxWindow_Click);
            // 
            // elipseForm
            // 
            this.elipseForm.BorderRadius = 16;
            this.elipseForm.TargetControl = this;
            // 
            // dragTopbar
            // 
            this.dragTopbar.TargetControl = this.pnlTopbar;
            this.dragTopbar.UseTransparentDrag = true;
            // 
            // dragSidebar
            // 
            this.dragSidebar.TargetControl = this.pnlSidebar;
            this.dragSidebar.UseTransparentDrag = true;
            // 
            // animateForm
            // 
            this.animateForm.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.animateForm.Interval = 250;
            this.animateForm.TargetForm = this;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1024, 721);
            this.pnlContent.TabIndex = 2;
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopbar);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "FrmDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASA Clinic Pro - ماصا كلينك برو";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlDocProfile.ResumeLayout(false);
            this.pnlDocProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDocAvatar)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTopbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2DragControl dragTopbar;
        private Guna.UI2.WinForms.Guna2DragControl dragSidebar;
        private Guna.UI2.WinForms.Guna2AnimateWindow animateForm;
        private Guna.UI2.WinForms.Guna2CircleButton btnCloseWindow;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinWindow;
        private Guna.UI2.WinForms.Guna2CircleButton btnMaxWindow;
        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Button btnMedicalRecords;
        private Guna.UI2.WinForms.Guna2Button btnPayments;
        private Guna.UI2.WinForms.Guna2Button btnBilling;
        private Guna.UI2.WinForms.Guna2Button btnPrescription;
        private Guna.UI2.WinForms.Guna2Button btnConsultation;
        private Guna.UI2.WinForms.Guna2Button btnAppointments;
        private Guna.UI2.WinForms.Guna2Button btnDoctors;
        private Guna.UI2.WinForms.Guna2Button btnPatients;
        private Guna.UI2.WinForms.Guna2Panel pnlDocProfile;
        private System.Windows.Forms.Label lblDocSpecialty;
        private System.Windows.Forms.Label lblDocName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picDocAvatar;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private System.Windows.Forms.Label lblBrand;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlTopbar;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblDateTime;
        private Guna.UI2.WinForms.Guna2Button btnNotification;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private System.Windows.Forms.Timer tmrClock;
    }
}
