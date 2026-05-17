namespace Clinic_Management_System
{
    partial class UC_Reports
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
            this.pnlPatientsCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPatientsVal = new System.Windows.Forms.Label();
            this.lblPatientsHeader = new System.Windows.Forms.Label();
            this.pnlAppointmentsCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAppointmentsVal = new System.Windows.Forms.Label();
            this.lblAppointmentsHeader = new System.Windows.Forms.Label();
            this.pnlRevenueCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRevenueVal = new System.Windows.Forms.Label();
            this.lblRevenueHeader = new System.Windows.Forms.Label();
            this.pnlAlertsCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAlertsVal = new System.Windows.Forms.Label();
            this.lblAlertsHeader = new System.Windows.Forms.Label();
            this.pnlChart = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlExport = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportPDF = new Guna.UI2.WinForms.Guna2Button();
            this.lblExportTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlPatientsCard.SuspendLayout();
            this.pnlAppointmentsCard.SuspendLayout();
            this.pnlRevenueCard.SuspendLayout();
            this.pnlAlertsCard.SuspendLayout();
            this.pnlExport.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(232, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "التقارير والإحصائيات العامة";
            // 
            // pnlPatientsCard
            // 
            this.pnlPatientsCard.BackColor = System.Drawing.Color.White;
            this.pnlPatientsCard.BorderRadius = 8;
            this.pnlPatientsCard.Controls.Add(this.lblPatientsVal);
            this.pnlPatientsCard.Controls.Add(this.lblPatientsHeader);
            this.pnlPatientsCard.Location = new System.Drawing.Point(20, 110);
            this.pnlPatientsCard.Name = "pnlPatientsCard";
            this.pnlPatientsCard.Size = new System.Drawing.Size(225, 90);
            this.pnlPatientsCard.TabIndex = 1;
            // 
            // lblPatientsVal
            // 
            this.lblPatientsVal.AutoSize = true;
            this.lblPatientsVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblPatientsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblPatientsVal.Location = new System.Drawing.Point(15, 35);
            this.lblPatientsVal.Name = "lblPatientsVal";
            this.lblPatientsVal.Size = new System.Drawing.Size(35, 41);
            this.lblPatientsVal.TabIndex = 1;
            this.lblPatientsVal.Text = "0";
            // 
            // lblPatientsHeader
            // 
            this.lblPatientsHeader.AutoSize = true;
            this.lblPatientsHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPatientsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblPatientsHeader.Location = new System.Drawing.Point(15, 15);
            this.lblPatientsHeader.Name = "lblPatientsHeader";
            this.lblPatientsHeader.Size = new System.Drawing.Size(102, 15);
            this.lblPatientsHeader.TabIndex = 0;
            this.lblPatientsHeader.Text = "إجمالي عدد المرضى المسجلين";
            // 
            // pnlAppointmentsCard
            // 
            this.pnlAppointmentsCard.BackColor = System.Drawing.Color.White;
            this.pnlAppointmentsCard.BorderRadius = 8;
            this.pnlAppointmentsCard.Controls.Add(this.lblAppointmentsVal);
            this.pnlAppointmentsCard.Controls.Add(this.lblAppointmentsHeader);
            this.pnlAppointmentsCard.Location = new System.Drawing.Point(265, 110);
            this.pnlAppointmentsCard.Name = "pnlAppointmentsCard";
            this.pnlAppointmentsCard.Size = new System.Drawing.Size(225, 90);
            this.pnlAppointmentsCard.TabIndex = 2;
            // 
            // lblAppointmentsVal
            // 
            this.lblAppointmentsVal.AutoSize = true;
            this.lblAppointmentsVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblAppointmentsVal.Location = new System.Drawing.Point(15, 35);
            this.lblAppointmentsVal.Name = "lblAppointmentsVal";
            this.lblAppointmentsVal.Size = new System.Drawing.Size(35, 41);
            this.lblAppointmentsVal.TabIndex = 1;
            this.lblAppointmentsVal.Text = "0";
            // 
            // lblAppointmentsHeader
            // 
            this.lblAppointmentsHeader.AutoSize = true;
            this.lblAppointmentsHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblAppointmentsHeader.Location = new System.Drawing.Point(15, 15);
            this.lblAppointmentsHeader.Name = "lblAppointmentsHeader";
            this.lblAppointmentsHeader.Size = new System.Drawing.Size(126, 15);
            this.lblAppointmentsHeader.TabIndex = 0;
            this.lblAppointmentsHeader.Text = "إجمالي عدد الحجوزات";
            // 
            // pnlRevenueCard
            // 
            this.pnlRevenueCard.BackColor = System.Drawing.Color.White;
            this.pnlRevenueCard.BorderRadius = 8;
            this.pnlRevenueCard.Controls.Add(this.lblRevenueVal);
            this.pnlRevenueCard.Controls.Add(this.lblRevenueHeader);
            this.pnlRevenueCard.Location = new System.Drawing.Point(510, 110);
            this.pnlRevenueCard.Name = "pnlRevenueCard";
            this.pnlRevenueCard.Size = new System.Drawing.Size(240, 90);
            this.pnlRevenueCard.TabIndex = 3;
            // 
            // lblRevenueVal
            // 
            this.lblRevenueVal.AutoSize = true;
            this.lblRevenueVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblRevenueVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            this.lblRevenueVal.Location = new System.Drawing.Point(15, 35);
            this.lblRevenueVal.Name = "lblRevenueVal";
            this.lblRevenueVal.Size = new System.Drawing.Size(100, 41);
            this.lblRevenueVal.TabIndex = 1;
            this.lblRevenueVal.Text = "0 EGP";
            // 
            // lblRevenueHeader
            // 
            this.lblRevenueHeader.AutoSize = true;
            this.lblRevenueHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRevenueHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblRevenueHeader.Location = new System.Drawing.Point(15, 15);
            this.lblRevenueHeader.Name = "lblRevenueHeader";
            this.lblRevenueHeader.Size = new System.Drawing.Size(117, 15);
            this.lblRevenueHeader.TabIndex = 0;
            this.lblRevenueHeader.Text = "إجمالي صافي الإيرادات";
            // 
            // pnlAlertsCard
            // 
            this.pnlAlertsCard.BackColor = System.Drawing.Color.White;
            this.pnlAlertsCard.BorderRadius = 8;
            this.pnlAlertsCard.Controls.Add(this.lblAlertsVal);
            this.pnlAlertsCard.Controls.Add(this.lblAlertsHeader);
            this.pnlAlertsCard.Location = new System.Drawing.Point(770, 110);
            this.pnlAlertsCard.Name = "pnlAlertsCard";
            this.pnlAlertsCard.Size = new System.Drawing.Size(234, 90);
            this.pnlAlertsCard.TabIndex = 4;
            // 
            // lblAlertsVal
            // 
            this.lblAlertsVal.AutoSize = true;
            this.lblAlertsVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAlertsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblAlertsVal.Location = new System.Drawing.Point(15, 35);
            this.lblAlertsVal.Name = "lblAlertsVal";
            this.lblAlertsVal.Size = new System.Drawing.Size(35, 41);
            this.lblAlertsVal.TabIndex = 1;
            this.lblAlertsVal.Text = "0";
            // 
            // lblAlertsHeader
            // 
            this.lblAlertsHeader.AutoSize = true;
            this.lblAlertsHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAlertsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblAlertsHeader.Location = new System.Drawing.Point(15, 15);
            this.lblAlertsHeader.Name = "lblAlertsHeader";
            this.lblAlertsHeader.Size = new System.Drawing.Size(120, 15);
            this.lblAlertsHeader.TabIndex = 0;
            this.lblAlertsHeader.Text = "تنبيهات نقص المخزون";
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.BorderRadius = 10;
            this.pnlChart.Location = new System.Drawing.Point(20, 220);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(984, 350);
            this.pnlChart.TabIndex = 5;
            this.pnlChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart_Paint);
            // 
            // pnlExport
            // 
            this.pnlExport.BackColor = System.Drawing.Color.White;
            this.pnlExport.BorderRadius = 10;
            this.pnlExport.Controls.Add(this.btnExportExcel);
            this.pnlExport.Controls.Add(this.btnExportPDF);
            this.pnlExport.Controls.Add(this.lblExportTitle);
            this.pnlExport.Location = new System.Drawing.Point(20, 590);
            this.pnlExport.Name = "pnlExport";
            this.pnlExport.Size = new System.Drawing.Size(984, 100);
            this.pnlExport.TabIndex = 6;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BorderRadius = 8;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.btnExportExcel.Location = new System.Drawing.Point(230, 45);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(180, 40);
            this.btnExportExcel.TabIndex = 2;
            this.btnExportExcel.Text = "تصدير إلى إكسل (.xlsx)";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BorderRadius = 8;
            this.btnExportPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnExportPDF.Location = new System.Drawing.Point(20, 45);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(180, 40);
            this.btnExportPDF.TabIndex = 1;
            this.btnExportPDF.Text = "تصدير إلى PDF (.pdf)";
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // lblExportTitle
            // 
            this.lblExportTitle.AutoSize = true;
            this.lblExportTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblExportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblExportTitle.Location = new System.Drawing.Point(20, 15);
            this.lblExportTitle.Name = "lblExportTitle";
            this.lblExportTitle.Size = new System.Drawing.Size(262, 19);
            this.lblExportTitle.TabIndex = 0;
            this.lblExportTitle.Text = "تصدير وتنزيل مجموعات البيانات والتقارير الطبية:";
            // 
            // UC_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlExport);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.pnlAlertsCard);
            this.Controls.Add(this.pnlRevenueCard);
            this.Controls.Add(this.pnlAppointmentsCard);
            this.Controls.Add(this.pnlPatientsCard);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_Reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1024, 721);
            this.Load += new System.EventHandler(this.UC_Reports_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlPatientsCard.ResumeLayout(false);
            this.pnlPatientsCard.PerformLayout();
            this.pnlAppointmentsCard.ResumeLayout(false);
            this.pnlAppointmentsCard.PerformLayout();
            this.pnlRevenueCard.ResumeLayout(false);
            this.pnlRevenueCard.PerformLayout();
            this.pnlAlertsCard.ResumeLayout(false);
            this.pnlAlertsCard.PerformLayout();
            this.pnlExport.ResumeLayout(false);
            this.pnlExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlPatientsCard;
        private System.Windows.Forms.Label lblPatientsHeader;
        private System.Windows.Forms.Label lblPatientsVal;
        private Guna.UI2.WinForms.Guna2Panel pnlAppointmentsCard;
        private System.Windows.Forms.Label lblAppointmentsHeader;
        private System.Windows.Forms.Label lblAppointmentsVal;
        private Guna.UI2.WinForms.Guna2Panel pnlRevenueCard;
        private System.Windows.Forms.Label lblRevenueHeader;
        private System.Windows.Forms.Label lblRevenueVal;
        private Guna.UI2.WinForms.Guna2Panel pnlAlertsCard;
        private System.Windows.Forms.Label lblAlertsHeader;
        private System.Windows.Forms.Label lblAlertsVal;
        private Guna.UI2.WinForms.Guna2Panel pnlChart;
        private Guna.UI2.WinForms.Guna2Panel pnlExport;
        private System.Windows.Forms.Label lblExportTitle;
        private Guna.UI2.WinForms.Guna2Button btnExportPDF;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
    }
}
