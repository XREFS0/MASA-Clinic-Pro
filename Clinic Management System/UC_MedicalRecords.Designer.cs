namespace Clinic_Management_System
{
    partial class UC_MedicalRecords
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cmbPatient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBio = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMedHistorySummary = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.lblAddressVal = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneVal = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGenderVal = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAgeVal = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblProfileCardHeader = new System.Windows.Forms.Label();
            this.tcTabs = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpVisits = new System.Windows.Forms.TabPage();
            this.dgvVisits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tpPrescriptions = new System.Windows.Forms.TabPage();
            this.dgvPrescriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tpBillings = new System.Windows.Forms.TabPage();
            this.dgvBillings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlBio.SuspendLayout();
            this.tcTabs.SuspendLayout();
            this.tpVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.tpPrescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.tpBillings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.cmbPatient);
            this.pnlHeader.Controls.Add(this.lblPatient);
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
            // cmbPatient
            // 
            this.cmbPatient.BackColor = System.Drawing.Color.Transparent;
            this.cmbPatient.BorderRadius = 8;
            this.cmbPatient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPatient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPatient.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPatient.ItemHeight = 30;
            this.cmbPatient.Location = new System.Drawing.Point(630, 20);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(330, 36);
            this.cmbPatient.TabIndex = 2;
            this.cmbPatient.SelectedIndexChanged += new System.EventHandler(this.cmbPatient_SelectedIndexChanged);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblPatient.Location = new System.Drawing.Point(525, 29);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(99, 19);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "اختر المريض:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ملف السجل الطبي الشامل للمريض";
            // 
            // pnlBio
            // 
            this.pnlBio.BackColor = System.Drawing.Color.White;
            this.pnlBio.BorderRadius = 10;
            this.pnlBio.Controls.Add(this.txtMedHistorySummary);
            this.pnlBio.Controls.Add(this.lblHistoryTitle);
            this.pnlBio.Controls.Add(this.lblAddressVal);
            this.pnlBio.Controls.Add(this.lblAddress);
            this.pnlBio.Controls.Add(this.lblPhoneVal);
            this.pnlBio.Controls.Add(this.lblPhone);
            this.pnlBio.Controls.Add(this.lblGenderVal);
            this.pnlBio.Controls.Add(this.lblGender);
            this.pnlBio.Controls.Add(this.lblAgeVal);
            this.pnlBio.Controls.Add(this.lblAge);
            this.pnlBio.Controls.Add(this.lblProfileCardHeader);
            this.pnlBio.Location = new System.Drawing.Point(20, 110);
            this.pnlBio.Name = "pnlBio";
            this.pnlBio.Size = new System.Drawing.Size(320, 580);
            this.pnlBio.TabIndex = 1;
            // 
            // txtMedHistorySummary
            // 
            this.txtMedHistorySummary.BorderRadius = 8;
            this.txtMedHistorySummary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedHistorySummary.DefaultText = "";
            this.txtMedHistorySummary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedHistorySummary.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtMedHistorySummary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.txtMedHistorySummary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedHistorySummary.Enabled = false;
            this.txtMedHistorySummary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedHistorySummary.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMedHistorySummary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedHistorySummary.Location = new System.Drawing.Point(20, 310);
            this.txtMedHistorySummary.Multiline = true;
            this.txtMedHistorySummary.Name = "txtMedHistorySummary";
            this.txtMedHistorySummary.PasswordChar = '\0';
            this.txtMedHistorySummary.PlaceholderText = "لا توجد أمراض مزمنة مسجلة لهذا المريض.";
            this.txtMedHistorySummary.ReadOnly = true;
            this.txtMedHistorySummary.SelectedText = "";
            this.txtMedHistorySummary.Size = new System.Drawing.Size(280, 250);
            this.txtMedHistorySummary.TabIndex = 10;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblHistoryTitle.Location = new System.Drawing.Point(20, 285);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(139, 17);
            this.lblHistoryTitle.TabIndex = 9;
            this.lblHistoryTitle.Text = "التاريخ الطبي والحيوي:";
            // 
            // lblAddressVal
            // 
            this.lblAddressVal.AutoSize = true;
            this.lblAddressVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAddressVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblAddressVal.Location = new System.Drawing.Point(20, 245);
            this.lblAddressVal.Name = "lblAddressVal";
            this.lblAddressVal.Size = new System.Drawing.Size(43, 17);
            this.lblAddressVal.TabIndex = 8;
            this.lblAddressVal.Text = "Cairo";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblAddress.Location = new System.Drawing.Point(20, 225);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 15);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "العنوان:";
            // 
            // lblPhoneVal
            // 
            this.lblPhoneVal.AutoSize = true;
            this.lblPhoneVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPhoneVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblPhoneVal.Location = new System.Drawing.Point(20, 190);
            this.lblPhoneVal.Name = "lblPhoneVal";
            this.lblPhoneVal.Size = new System.Drawing.Size(80, 17);
            this.lblPhoneVal.TabIndex = 6;
            this.lblPhoneVal.Text = "0100000000";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblPhone.Location = new System.Drawing.Point(20, 170);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(45, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "الهاتف:";
            // 
            // lblGenderVal
            // 
            this.lblGenderVal.AutoSize = true;
            this.lblGenderVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGenderVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblGenderVal.Location = new System.Drawing.Point(160, 135);
            this.lblGenderVal.Name = "lblGenderVal";
            this.lblGenderVal.Size = new System.Drawing.Size(37, 17);
            this.lblGenderVal.TabIndex = 4;
            this.lblGenderVal.Text = "Male";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblGender.Location = new System.Drawing.Point(160, 115);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 15);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "النوع / الجنس:";
            // 
            // lblAgeVal
            // 
            this.lblAgeVal.AutoSize = true;
            this.lblAgeVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAgeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblAgeVal.Location = new System.Drawing.Point(20, 135);
            this.lblAgeVal.Name = "lblAgeVal";
            this.lblAgeVal.Size = new System.Drawing.Size(58, 17);
            this.lblAgeVal.TabIndex = 2;
            this.lblAgeVal.Text = "34 years";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblAge.Location = new System.Drawing.Point(20, 115);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 15);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "العمر:";
            // 
            // lblProfileCardHeader
            // 
            this.lblProfileCardHeader.AutoSize = true;
            this.lblProfileCardHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProfileCardHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblProfileCardHeader.Location = new System.Drawing.Point(20, 20);
            this.lblProfileCardHeader.Name = "lblProfileCardHeader";
            this.lblProfileCardHeader.Size = new System.Drawing.Size(155, 20);
            this.lblProfileCardHeader.TabIndex = 0;
            this.lblProfileCardHeader.Text = "الملف التعريفي للمريض";
            // 
            // tcTabs
            // 
            this.tcTabs.Alignment = System.Windows.Forms.TabAlignment.Top;
            this.tcTabs.Controls.Add(this.tpVisits);
            this.tcTabs.Controls.Add(this.tpPrescriptions);
            this.tcTabs.Controls.Add(this.tpBillings);
            this.tcTabs.ItemSize = new System.Drawing.Size(180, 40);
            this.tcTabs.Location = new System.Drawing.Point(360, 110);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(644, 580);
            this.tcTabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcTabs.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tcTabs.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.tcTabs.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.tcTabs.TabButtonHoverState.InnerColor = System.Drawing.Color.Transparent;
            this.tcTabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcTabs.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.tcTabs.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.tcTabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.tcTabs.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent;
            this.tcTabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcTabs.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.tcTabs.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tcTabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcTabs.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.tcTabs.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcTabs.TabIndex = 2;
            // 
            // tpVisits
            // 
            this.tpVisits.BackColor = System.Drawing.Color.White;
            this.tpVisits.Controls.Add(this.dgvVisits);
            this.tpVisits.Location = new System.Drawing.Point(4, 44);
            this.tpVisits.Name = "tpVisits";
            this.tpVisits.Padding = new System.Windows.Forms.Padding(10);
            this.tpVisits.Size = new System.Drawing.Size(636, 532);
            this.tpVisits.TabIndex = 0;
            this.tpVisits.Text = "سجل الزيارات والكشف";
            // 
            // dgvVisits
            // 
            this.dgvVisits.AllowUserToAddRows = false;
            this.dgvVisits.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVisits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisits.BackgroundColor = System.Drawing.Color.White;
            this.dgvVisits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVisits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVisits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisits.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisits.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisits.EnableHeadersVisualStyles = false;
            this.dgvVisits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvVisits.Location = new System.Drawing.Point(10, 10);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.ReadOnly = true;
            this.dgvVisits.RowHeadersVisible = false;
            this.dgvVisits.RowTemplate.Height = 35;
            this.dgvVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisits.Size = new System.Drawing.Size(616, 512);
            this.dgvVisits.TabIndex = 0;
            this.dgvVisits.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVisits.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVisits.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVisits.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVisits.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVisits.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVisits.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvVisits.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.dgvVisits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvVisits.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVisits.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVisits.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvVisits.ThemeStyle.ReadOnly = true;
            this.dgvVisits.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVisits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvVisits.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVisits.ThemeStyle.RowsStyle.Height = 35;
            this.dgvVisits.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVisits.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tpPrescriptions
            // 
            this.tpPrescriptions.BackColor = System.Drawing.Color.White;
            this.tpPrescriptions.Controls.Add(this.dgvPrescriptions);
            this.tpPrescriptions.Location = new System.Drawing.Point(4, 44);
            this.tpPrescriptions.Name = "tpPrescriptions";
            this.tpPrescriptions.Padding = new System.Windows.Forms.Padding(10);
            this.tpPrescriptions.Size = new System.Drawing.Size(636, 532);
            this.tpPrescriptions.TabIndex = 1;
            this.tpPrescriptions.Text = "سجل الروشتات العلاجية";
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.AllowUserToAddRows = false;
            this.dgvPrescriptions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrescriptions.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrescriptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrescriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrescriptions.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrescriptions.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrescriptions.EnableHeadersVisualStyles = false;
            this.dgvPrescriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvPrescriptions.Location = new System.Drawing.Point(10, 10);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.ReadOnly = true;
            this.dgvPrescriptions.RowHeadersVisible = false;
            this.dgvPrescriptions.RowTemplate.Height = 35;
            this.dgvPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescriptions.Size = new System.Drawing.Size(616, 512);
            this.dgvPrescriptions.TabIndex = 0;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPrescriptions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrescriptions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPrescriptions.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvPrescriptions.ThemeStyle.ReadOnly = true;
            this.dgvPrescriptions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrescriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPrescriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPrescriptions.ThemeStyle.RowsStyle.Height = 35;
            this.dgvPrescriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrescriptions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tpBillings
            // 
            this.tpBillings.BackColor = System.Drawing.Color.White;
            this.tpBillings.Controls.Add(this.dgvBillings);
            this.tpBillings.Location = new System.Drawing.Point(4, 44);
            this.tpBillings.Name = "tpBillings";
            this.tpBillings.Padding = new System.Windows.Forms.Padding(10);
            this.tpBillings.Size = new System.Drawing.Size(636, 532);
            this.tpBillings.TabIndex = 2;
            this.tpBillings.Text = "الفواتير والمدفوعات";
            // 
            // dgvBillings
            // 
            this.dgvBillings.AllowUserToAddRows = false;
            this.dgvBillings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvBillings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBillings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBillings.ColumnHeadersHeight = 35;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillings.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBillings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillings.EnableHeadersVisualStyles = false;
            this.dgvBillings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvBillings.Location = new System.Drawing.Point(10, 10);
            this.dgvBillings.Name = "dgvBillings";
            this.dgvBillings.ReadOnly = true;
            this.dgvBillings.RowHeadersVisible = false;
            this.dgvBillings.RowTemplate.Height = 35;
            this.dgvBillings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillings.Size = new System.Drawing.Size(616, 512);
            this.dgvBillings.TabIndex = 0;
            this.dgvBillings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillings.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBillings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBillings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBillings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBillings.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvBillings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.dgvBillings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvBillings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBillings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBillings.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvBillings.ThemeStyle.ReadOnly = true;
            this.dgvBillings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvBillings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBillings.ThemeStyle.RowsStyle.Height = 35;
            this.dgvBillings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_MedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.tcTabs);
            this.Controls.Add(this.pnlBio);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_MedicalRecords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1024, 721);
            this.Load += new System.EventHandler(this.UC_MedicalRecords_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBio.ResumeLayout(false);
            this.pnlBio.PerformLayout();
            this.tcTabs.ResumeLayout(false);
            this.tpVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.tpPrescriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.tpBillings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatient;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPatient;
        private Guna.UI2.WinForms.Guna2Panel pnlBio;
        private System.Windows.Forms.Label lblProfileCardHeader;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeVal;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblGenderVal;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPhoneVal;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAddressVal;
        private System.Windows.Forms.Label lblHistoryTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtMedHistorySummary;
        private Guna.UI2.WinForms.Guna2TabControl tcTabs;
        private System.Windows.Forms.TabPage tpVisits;
        private System.Windows.Forms.TabPage tpPrescriptions;
        private System.Windows.Forms.TabPage tpBillings;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVisits;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPrescriptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillings;
    }
}
