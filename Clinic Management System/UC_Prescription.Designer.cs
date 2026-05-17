namespace Clinic_Management_System
{
    partial class UC_Prescription
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pnlDrugAdd = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRemoveDrug = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDrug = new Guna.UI2.WinForms.Guna2Button();
            this.txtDuration = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtFrequency = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.txtDosage = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDosage = new System.Windows.Forms.Label();
            this.txtDrugName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDrugName = new System.Windows.Forms.Label();
            this.lblDrugsSectionHeader = new System.Windows.Forms.Label();
            this.cmbDoctor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cmbPatient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.dgvDrugs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlDrugAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).EndInit();
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
            this.lblTitle.Size = new System.Drawing.Size(269, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "كتابة وتعديل الوصفات الطبية";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderRadius = 10;
            this.pnlForm.Controls.Add(this.btnClear);
            this.pnlForm.Controls.Add(this.btnPrint);
            this.pnlForm.Controls.Add(this.btnSave);
            this.pnlForm.Controls.Add(this.txtNotes);
            this.pnlForm.Controls.Add(this.lblNotes);
            this.pnlForm.Controls.Add(this.pnlDrugAdd);
            this.pnlForm.Controls.Add(this.cmbDoctor);
            this.pnlForm.Controls.Add(this.lblDoctor);
            this.pnlForm.Controls.Add(this.cmbPatient);
            this.pnlForm.Controls.Add(this.lblPatient);
            this.pnlForm.Location = new System.Drawing.Point(20, 110);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(460, 580);
            this.pnlForm.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 8;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.btnClear.Location = new System.Drawing.Point(15, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 38);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "مسح";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 8;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.btnPrint.Location = new System.Drawing.Point(190, 520);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 38);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "طباعة / معاينة الوصفة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.btnSave.Location = new System.Drawing.Point(325, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "حفظ الوصفة الطبية";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 8;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(15, 415);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "اكتب ملاحظات إضافية، التحذيرات الطبية، أو التوصيات العلاجية...";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(430, 85);
            this.txtNotes.TabIndex = 11;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblNotes.Location = new System.Drawing.Point(15, 395);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(126, 17);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "ملاحظات وتوصيات إضافية:";
            // 
            // pnlDrugAdd
            // 
            this.pnlDrugAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlDrugAdd.BorderRadius = 8;
            this.pnlDrugAdd.BorderThickness = 1;
            this.pnlDrugAdd.Controls.Add(this.btnRemoveDrug);
            this.pnlDrugAdd.Controls.Add(this.btnAddDrug);
            this.pnlDrugAdd.Controls.Add(this.txtDuration);
            this.pnlDrugAdd.Controls.Add(this.lblDuration);
            this.pnlDrugAdd.Controls.Add(this.txtFrequency);
            this.pnlDrugAdd.Controls.Add(this.lblFrequency);
            this.pnlDrugAdd.Controls.Add(this.txtDosage);
            this.pnlDrugAdd.Controls.Add(this.lblDosage);
            this.pnlDrugAdd.Controls.Add(this.txtDrugName);
            this.pnlDrugAdd.Controls.Add(this.lblDrugName);
            this.pnlDrugAdd.Controls.Add(this.lblDrugsSectionHeader);
            this.pnlDrugAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.pnlDrugAdd.Location = new System.Drawing.Point(15, 130);
            this.pnlDrugAdd.Name = "pnlDrugAdd";
            this.pnlDrugAdd.Size = new System.Drawing.Size(430, 255);
            this.pnlDrugAdd.TabIndex = 5;
            // 
            // btnRemoveDrug
            // 
            this.btnRemoveDrug.BorderRadius = 5;
            this.btnRemoveDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDrug.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveDrug.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveDrug.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveDrug.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveDrug.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRemoveDrug.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnRemoveDrug.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDrug.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnRemoveDrug.Location = new System.Drawing.Point(235, 205);
            this.btnRemoveDrug.Name = "btnRemoveDrug";
            this.btnRemoveDrug.Size = new System.Drawing.Size(180, 35);
            this.btnRemoveDrug.TabIndex = 10;
            this.btnRemoveDrug.Text = "حذف الدواء المحدد";
            this.btnRemoveDrug.Click += new System.EventHandler(this.btnRemoveDrug_Click);
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.BorderRadius = 5;
            this.btnAddDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDrug.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDrug.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDrug.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDrug.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDrug.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnAddDrug.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnAddDrug.ForeColor = System.Drawing.Color.White;
            this.btnAddDrug.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.btnAddDrug.Location = new System.Drawing.Point(15, 205);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.Size = new System.Drawing.Size(180, 35);
            this.btnAddDrug.TabIndex = 9;
            this.btnAddDrug.Text = "+ إضافة للقائمة";
            this.btnAddDrug.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.BorderRadius = 5;
            this.txtDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuration.DefaultText = "";
            this.txtDuration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDuration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDuration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDuration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuration.Location = new System.Drawing.Point(220, 160);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.PasswordChar = '\0';
            this.txtDuration.PlaceholderText = "مثال: ٥ أيام";
            this.txtDuration.SelectedText = "";
            this.txtDuration.Size = new System.Drawing.Size(195, 30);
            this.txtDuration.TabIndex = 8;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblDuration.Location = new System.Drawing.Point(220, 140);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(57, 15);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "مدة العلاج:";
            // 
            // txtFrequency
            // 
            this.txtFrequency.BorderRadius = 5;
            this.txtFrequency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrequency.DefaultText = "";
            this.txtFrequency.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrequency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrequency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrequency.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrequency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrequency.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFrequency.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrequency.Location = new System.Drawing.Point(15, 160);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.PasswordChar = '\0';
            this.txtFrequency.PlaceholderText = "مثال: ٣ مرات يومياً";
            this.txtFrequency.SelectedText = "";
            this.txtFrequency.Size = new System.Drawing.Size(195, 30);
            this.txtFrequency.TabIndex = 6;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.BackColor = System.Drawing.Color.Transparent;
            this.lblFrequency.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblFrequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblFrequency.Location = new System.Drawing.Point(15, 140);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(66, 15);
            this.lblFrequency.TabIndex = 5;
            this.lblFrequency.Text = "معدل التكرار:";
            // 
            // txtDosage
            // 
            this.txtDosage.BorderRadius = 5;
            this.txtDosage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDosage.DefaultText = "";
            this.txtDosage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDosage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDosage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDosage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDosage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDosage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDosage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDosage.Location = new System.Drawing.Point(15, 105);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.PasswordChar = '\0';
            this.txtDosage.PlaceholderText = "مثال: قرص واحد، ٥ مل";
            this.txtDosage.SelectedText = "";
            this.txtDosage.Size = new System.Drawing.Size(400, 30);
            this.txtDosage.TabIndex = 4;
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.BackColor = System.Drawing.Color.Transparent;
            this.lblDosage.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblDosage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblDosage.Location = new System.Drawing.Point(15, 85);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(49, 15);
            this.lblDosage.TabIndex = 3;
            this.lblDosage.Text = "الجرعة المطلوبة:";
            // 
            // txtDrugName
            // 
            this.txtDrugName.BorderRadius = 5;
            this.txtDrugName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDrugName.DefaultText = "";
            this.txtDrugName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDrugName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDrugName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDrugName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDrugName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDrugName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDrugName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDrugName.Location = new System.Drawing.Point(10, 52);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.PasswordChar = '\0';
            this.txtDrugName.PlaceholderText = "مثال: بنادول، أموكسيسيلين ٥٠٠ مجم...";
            this.txtDrugName.SelectedText = "";
            this.txtDrugName.Size = new System.Drawing.Size(405, 30);
            this.txtDrugName.TabIndex = 2;
            // 
            // lblDrugName
            // 
            this.lblDrugName.AutoSize = true;
            this.lblDrugName.BackColor = System.Drawing.Color.Transparent;
            this.lblDrugName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblDrugName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblDrugName.Location = new System.Drawing.Point(10, 32);
            this.lblDrugName.Name = "lblDrugName";
            this.lblDrugName.Size = new System.Drawing.Size(71, 15);
            this.lblDrugName.TabIndex = 1;
            this.lblDrugName.Text = "اسم الدواء:";
            // 
            // lblDrugsSectionHeader
            // 
            this.lblDrugsSectionHeader.AutoSize = true;
            this.lblDrugsSectionHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblDrugsSectionHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDrugsSectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblDrugsSectionHeader.Location = new System.Drawing.Point(8, 8);
            this.lblDrugsSectionHeader.Name = "lblDrugsSectionHeader";
            this.lblDrugsSectionHeader.Size = new System.Drawing.Size(127, 17);
            this.lblDrugsSectionHeader.TabIndex = 0;
            this.lblDrugsSectionHeader.Text = "إضافة الأدوية والعقاقير";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.BackColor = System.Drawing.Color.Transparent;
            this.cmbDoctor.BorderRadius = 8;
            this.cmbDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDoctor.ItemHeight = 30;
            this.cmbDoctor.Location = new System.Drawing.Point(15, 80);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(430, 36);
            this.cmbDoctor.TabIndex = 3;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblDoctor.Location = new System.Drawing.Point(15, 60);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(95, 17);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "اختر الطبيب المعالج:";
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
            this.cmbPatient.Location = new System.Drawing.Point(15, 20);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(430, 36);
            this.cmbPatient.TabIndex = 1;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblPatient.Location = new System.Drawing.Point(15, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(97, 17);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "اختر المريض:";
            // 
            // dgvDrugs
            // 
            this.dgvDrugs.AllowUserToAddRows = false;
            this.dgvDrugs.AllowUserToDeleteRows = false;
            this.dgvDrugs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDrugs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrugs.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrugs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDrugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrugs.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrugs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrugs.EnableHeadersVisualStyles = false;
            this.dgvDrugs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvDrugs.Location = new System.Drawing.Point(500, 110);
            this.dgvDrugs.MultiSelect = false;
            this.dgvDrugs.Name = "dgvDrugs";
            this.dgvDrugs.ReadOnly = true;
            this.dgvDrugs.RowHeadersVisible = false;
            this.dgvDrugs.RowTemplate.Height = 35;
            this.dgvDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugs.Size = new System.Drawing.Size(504, 580);
            this.dgvDrugs.TabIndex = 2;
            this.dgvDrugs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDrugs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDrugs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDrugs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDrugs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDrugs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDrugs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvDrugs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.dgvDrugs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvDrugs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDrugs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDrugs.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDrugs.ThemeStyle.ReadOnly = true;
            this.dgvDrugs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDrugs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDrugs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDrugs.ThemeStyle.RowsStyle.Height = 35;
            this.dgvDrugs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDrugs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.dgvDrugs);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_Prescription";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1024, 721);
            this.Load += new System.EventHandler(this.UC_Prescription_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlDrugAdd.ResumeLayout(false);
            this.pnlDrugAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblPatient;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDoctor;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDoctor;
        private Guna.UI2.WinForms.Guna2Panel pnlDrugAdd;
        private System.Windows.Forms.Label lblDrugsSectionHeader;
        private System.Windows.Forms.Label lblDrugName;
        private Guna.UI2.WinForms.Guna2TextBox txtDrugName;
        private System.Windows.Forms.Label lblDosage;
        private Guna.UI2.WinForms.Guna2TextBox txtDosage;
        private System.Windows.Forms.Label lblFrequency;
        private Guna.UI2.WinForms.Guna2TextBox txtFrequency;
        private System.Windows.Forms.Label lblDuration;
        private Guna.UI2.WinForms.Guna2TextBox txtDuration;
        private Guna.UI2.WinForms.Guna2Button btnAddDrug;
        private Guna.UI2.WinForms.Guna2Button btnRemoveDrug;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDrugs;
    }
}
