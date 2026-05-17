namespace Clinic_Management_System
{
    partial class UC_Settings
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtLogoPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtClinicAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClinicAddress = new System.Windows.Forms.Label();
            this.txtClinicPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClinicPhone = new System.Windows.Forms.Label();
            this.txtClinicName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClinicName = new System.Windows.Forms.Label();
            this.pnlBackupCard = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.lblBackupDesc = new System.Windows.Forms.Label();
            this.lblBackupHeader = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlBackupCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.FillColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Radius = 10;
            this.pnlHeader.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pnlHeader.ShadowDepth = 110;
            this.pnlHeader.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlHeader.Size = new System.Drawing.Size(984, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إعدادات النظام العامة";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderRadius = 10;
            this.pnlForm.Controls.Add(this.btnSave);
            this.pnlForm.Controls.Add(this.txtLogoPath);
            this.pnlForm.Controls.Add(this.lblLogo);
            this.pnlForm.Controls.Add(this.txtClinicAddress);
            this.pnlForm.Controls.Add(this.lblClinicAddress);
            this.pnlForm.Controls.Add(this.txtClinicPhone);
            this.pnlForm.Controls.Add(this.lblClinicPhone);
            this.pnlForm.Controls.Add(this.txtClinicName);
            this.pnlForm.Controls.Add(this.lblClinicName);
            this.pnlForm.Location = new System.Drawing.Point(20, 110);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(460, 580);
            this.pnlForm.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.btnSave.Location = new System.Drawing.Point(20, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(420, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ الإعدادات العامة";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLogoPath
            // 
            this.txtLogoPath.BorderRadius = 8;
            this.txtLogoPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogoPath.DefaultText = "";
            this.txtLogoPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogoPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogoPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogoPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogoPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogoPath.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtLogoPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogoPath.Location = new System.Drawing.Point(20, 320);
            this.txtLogoPath.Name = "txtLogoPath";
            this.txtLogoPath.PasswordChar = '\0';
            this.txtLogoPath.PlaceholderText = "مثال: C:\\Images\\logo.png";
            this.txtLogoPath.SelectedText = "";
            this.txtLogoPath.Size = new System.Drawing.Size(420, 36);
            this.txtLogoPath.TabIndex = 7;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblLogo.Location = new System.Drawing.Point(20, 295);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(110, 17);
            this.lblLogo.TabIndex = 6;
            this.lblLogo.Text = "مسار شعار العيادة:";
            // 
            // txtClinicAddress
            // 
            this.txtClinicAddress.BorderRadius = 8;
            this.txtClinicAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClinicAddress.DefaultText = "";
            this.txtClinicAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClinicAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClinicAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClinicAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClinicAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClinicAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtClinicAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClinicAddress.Location = new System.Drawing.Point(20, 230);
            this.txtClinicAddress.Name = "txtClinicAddress";
            this.txtClinicAddress.PasswordChar = '\0';
            this.txtClinicAddress.PlaceholderText = "مثال: مدينة نصر، القاهرة";
            this.txtClinicAddress.SelectedText = "";
            this.txtClinicAddress.Size = new System.Drawing.Size(420, 36);
            this.txtClinicAddress.TabIndex = 5;
            // 
            // lblClinicAddress
            // 
            this.lblClinicAddress.AutoSize = true;
            this.lblClinicAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblClinicAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblClinicAddress.Location = new System.Drawing.Point(20, 205);
            this.lblClinicAddress.Name = "lblClinicAddress";
            this.lblClinicAddress.Size = new System.Drawing.Size(99, 17);
            this.lblClinicAddress.TabIndex = 4;
            this.lblClinicAddress.Text = "عنوان العيادة:";
            // 
            // txtClinicPhone
            // 
            this.txtClinicPhone.BorderRadius = 8;
            this.txtClinicPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClinicPhone.DefaultText = "";
            this.txtClinicPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClinicPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClinicPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClinicPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClinicPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClinicPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtClinicPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClinicPhone.Location = new System.Drawing.Point(20, 140);
            this.txtClinicPhone.Name = "txtClinicPhone";
            this.txtClinicPhone.PasswordChar = '\0';
            this.txtClinicPhone.PlaceholderText = "مثال: +20 123 456 789";
            this.txtClinicPhone.SelectedText = "";
            this.txtClinicPhone.Size = new System.Drawing.Size(420, 36);
            this.txtClinicPhone.TabIndex = 3;
            // 
            // lblClinicPhone
            // 
            this.lblClinicPhone.AutoSize = true;
            this.lblClinicPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblClinicPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblClinicPhone.Location = new System.Drawing.Point(20, 115);
            this.lblClinicPhone.Name = "lblClinicPhone";
            this.lblClinicPhone.Size = new System.Drawing.Size(89, 17);
            this.lblClinicPhone.TabIndex = 2;
            this.lblClinicPhone.Text = "هاتف العيادة:";
            // 
            // txtClinicName
            // 
            this.txtClinicName.BorderRadius = 8;
            this.txtClinicName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClinicName.DefaultText = "";
            this.txtClinicName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClinicName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClinicName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClinicName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClinicName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClinicName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtClinicName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClinicName.Location = new System.Drawing.Point(20, 50);
            this.txtClinicName.Name = "txtClinicName";
            this.txtClinicName.PasswordChar = '\0';
            this.txtClinicName.PlaceholderText = "مثال: مركز العيادة التخصصي";
            this.txtClinicName.SelectedText = "";
            this.txtClinicName.Size = new System.Drawing.Size(420, 36);
            this.txtClinicName.TabIndex = 3;
            // 
            // lblClinicName
            // 
            this.lblClinicName.AutoSize = true;
            this.lblClinicName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblClinicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblClinicName.Location = new System.Drawing.Point(20, 25);
            this.lblClinicName.Name = "lblClinicName";
            this.lblClinicName.Size = new System.Drawing.Size(86, 17);
            this.lblClinicName.TabIndex = 2;
            this.lblClinicName.Text = "اسم العيادة:";
            // 
            // pnlBackupCard
            // 
            this.pnlBackupCard.BackColor = System.Drawing.Color.White;
            this.pnlBackupCard.BorderRadius = 10;
            this.pnlBackupCard.Controls.Add(this.btnRestore);
            this.pnlBackupCard.Controls.Add(this.btnBackup);
            this.pnlBackupCard.Controls.Add(this.lblBackupDesc);
            this.pnlBackupCard.Controls.Add(this.lblBackupHeader);
            this.pnlBackupCard.Location = new System.Drawing.Point(500, 110);
            this.pnlBackupCard.Name = "pnlBackupCard";
            this.pnlBackupCard.Size = new System.Drawing.Size(504, 580);
            this.pnlBackupCard.TabIndex = 2;
            // 
            // btnRestore
            // 
            this.btnRestore.BorderRadius = 8;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnRestore.Location = new System.Drawing.Point(250, 150);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(200, 40);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "استعادة قاعدة البيانات";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BorderRadius = 8;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.btnBackup.Location = new System.Drawing.Point(30, 150);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 40);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "نسخ احتياطي للبيانات";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblBackupDesc
            // 
            this.lblBackupDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.lblBackupDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblBackupDesc.Location = new System.Drawing.Point(30, 50);
            this.lblBackupDesc.Name = "lblBackupDesc";
            this.lblBackupDesc.Size = new System.Drawing.Size(440, 80);
            this.lblBackupDesc.TabIndex = 2;
            this.lblBackupDesc.Text = "قم بإنشاء نسخ احتياطية دورية لقاعدة بيانات SQLite لحماية السجلات الطبية والروشتات وتفاصيل الفواتير وحسابات المرضى من الفقدان والتعرض للتلف.";
            // 
            // lblBackupHeader
            // 
            this.lblBackupHeader.AutoSize = true;
            this.lblBackupHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBackupHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblBackupHeader.Location = new System.Drawing.Point(30, 20);
            this.lblBackupHeader.Name = "lblBackupHeader";
            this.lblBackupHeader.Size = new System.Drawing.Size(217, 20);
            this.lblBackupHeader.TabIndex = 0;
            this.lblBackupHeader.Text = "إدارة وحماية قاعدة البيانات";
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlBackupCard);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1024, 721);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlBackupCard.ResumeLayout(false);
            this.pnlBackupCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblClinicName;
        private Guna.UI2.WinForms.Guna2TextBox txtClinicName;
        private System.Windows.Forms.Label lblClinicPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtClinicPhone;
        private System.Windows.Forms.Label lblClinicAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtClinicAddress;
        private System.Windows.Forms.Label lblLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtLogoPath;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Panel pnlBackupCard;
        private System.Windows.Forms.Label lblBackupHeader;
        private System.Windows.Forms.Label lblBackupDesc;
        private Guna.UI2.WinForms.Guna2Button btnBackup;
        private Guna.UI2.WinForms.Guna2Button btnRestore;
    }
}
