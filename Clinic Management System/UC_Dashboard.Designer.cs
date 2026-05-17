namespace Clinic_Management_System
{
    partial class UC_Dashboard
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
            this.pnlPatientsCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblPatientTodayTrend = new System.Windows.Forms.Label();
            this.lblPatientTodayVal = new System.Windows.Forms.Label();
            this.lblPatientTodayTitle = new System.Windows.Forms.Label();
            this.pnlAppointmentsCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCancelledApp = new System.Windows.Forms.Label();
            this.lblConfirmedApp = new System.Windows.Forms.Label();
            this.lblPendingApp = new System.Windows.Forms.Label();
            this.lblAppTotalVal = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlDoctorsCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblDoctorsStatus = new System.Windows.Forms.Label();
            this.lblDoctorsVal = new System.Windows.Forms.Label();
            this.lblDoctorsTitle = new System.Windows.Forms.Label();
            this.pnlRevenueCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblRevenueTrend = new System.Windows.Forms.Label();
            this.lblRevenueVal = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.pnlChartOuter = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.pnlTodayAppOuter = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTodayAppTitle = new System.Windows.Forms.Label();
            this.pnlQuickActions = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnActionPrintReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnActionNewConsultation = new Guna.UI2.WinForms.Guna2Button();
            this.btnActionNewAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnActionNewPatient = new Guna.UI2.WinForms.Guna2Button();
            this.lblQuickActionsTitle = new System.Windows.Forms.Label();
            this.pnlPatientsCard.SuspendLayout();
            this.pnlAppointmentsCard.SuspendLayout();
            this.pnlDoctorsCard.SuspendLayout();
            this.pnlRevenueCard.SuspendLayout();
            this.pnlChartOuter.SuspendLayout();
            this.pnlTodayAppOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.pnlQuickActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientsCard
            // 
            this.pnlPatientsCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatientsCard.Controls.Add(this.lblPatientTodayTrend);
            this.pnlPatientsCard.Controls.Add(this.lblPatientTodayVal);
            this.pnlPatientsCard.Controls.Add(this.lblPatientTodayTitle);
            this.pnlPatientsCard.FillColor = System.Drawing.Color.White;
            this.pnlPatientsCard.Location = new System.Drawing.Point(20, 20);
            this.pnlPatientsCard.Name = "pnlPatientsCard";
            this.pnlPatientsCard.Radius = 10;
            this.pnlPatientsCard.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pnlPatientsCard.ShadowDepth = 110;
            this.pnlPatientsCard.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlPatientsCard.Size = new System.Drawing.Size(225, 150);
            this.pnlPatientsCard.TabIndex = 0;
            // 
            // lblPatientTodayTrend
            // 
            this.lblPatientTodayTrend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPatientTodayTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblPatientTodayTrend.Location = new System.Drawing.Point(15, 110);
            this.lblPatientTodayTrend.Name = "lblPatientTodayTrend";
            this.lblPatientTodayTrend.Size = new System.Drawing.Size(195, 20);
            this.lblPatientTodayTrend.TabIndex = 2;
            this.lblPatientTodayTrend.Text = "+5% اليوم";
            this.lblPatientTodayTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPatientTodayVal
            // 
            this.lblPatientTodayVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblPatientTodayVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblPatientTodayVal.Location = new System.Drawing.Point(15, 45);
            this.lblPatientTodayVal.Name = "lblPatientTodayVal";
            this.lblPatientTodayVal.Size = new System.Drawing.Size(195, 51);
            this.lblPatientTodayVal.TabIndex = 1;
            this.lblPatientTodayVal.Text = "45";
            this.lblPatientTodayVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPatientTodayTitle
            // 
            this.lblPatientTodayTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblPatientTodayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblPatientTodayTitle.Location = new System.Drawing.Point(15, 16);
            this.lblPatientTodayTitle.Name = "lblPatientTodayTitle";
            this.lblPatientTodayTitle.Size = new System.Drawing.Size(195, 20);
            this.lblPatientTodayTitle.TabIndex = 0;
            this.lblPatientTodayTitle.Text = "مرضى اليوم";
            this.lblPatientTodayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAppointmentsCard
            // 
            this.pnlAppointmentsCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlAppointmentsCard.Controls.Add(this.lblCancelledApp);
            this.pnlAppointmentsCard.Controls.Add(this.lblConfirmedApp);
            this.pnlAppointmentsCard.Controls.Add(this.lblPendingApp);
            this.pnlAppointmentsCard.Controls.Add(this.lblAppTotalVal);
            this.pnlAppointmentsCard.Controls.Add(this.lblAppTitle);
            this.pnlAppointmentsCard.FillColor = System.Drawing.Color.White;
            this.pnlAppointmentsCard.Location = new System.Drawing.Point(265, 20);
            this.pnlAppointmentsCard.Name = "pnlAppointmentsCard";
            this.pnlAppointmentsCard.Radius = 10;
            this.pnlAppointmentsCard.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pnlAppointmentsCard.ShadowDepth = 110;
            this.pnlAppointmentsCard.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlAppointmentsCard.Size = new System.Drawing.Size(225, 150);
            this.pnlAppointmentsCard.TabIndex = 1;
            // 
            // lblCancelledApp
            // 
            this.lblCancelledApp.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblCancelledApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblCancelledApp.Location = new System.Drawing.Point(15, 110);
            this.lblCancelledApp.Name = "lblCancelledApp";
            this.lblCancelledApp.Size = new System.Drawing.Size(60, 20);
            this.lblCancelledApp.TabIndex = 4;
            this.lblCancelledApp.Text = "2 ملغى";
            this.lblCancelledApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConfirmedApp
            // 
            this.lblConfirmedApp.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblConfirmedApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblConfirmedApp.Location = new System.Drawing.Point(80, 110);
            this.lblConfirmedApp.Name = "lblConfirmedApp";
            this.lblConfirmedApp.Size = new System.Drawing.Size(60, 20);
            this.lblConfirmedApp.TabIndex = 3;
            this.lblConfirmedApp.Text = "5 مؤكد";
            this.lblConfirmedApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPendingApp
            // 
            this.lblPendingApp.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblPendingApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblPendingApp.Location = new System.Drawing.Point(145, 110);
            this.lblPendingApp.Name = "lblPendingApp";
            this.lblPendingApp.Size = new System.Drawing.Size(65, 20);
            this.lblPendingApp.TabIndex = 2;
            this.lblPendingApp.Text = "12 قيد الانتظار";
            this.lblPendingApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAppTotalVal
            // 
            this.lblAppTotalVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblAppTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblAppTotalVal.Location = new System.Drawing.Point(15, 45);
            this.lblAppTotalVal.Name = "lblAppTotalVal";
            this.lblAppTotalVal.Size = new System.Drawing.Size(195, 51);
            this.lblAppTotalVal.TabIndex = 1;
            this.lblAppTotalVal.Text = "62";
            this.lblAppTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblAppTitle.Location = new System.Drawing.Point(15, 16);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(195, 20);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "الحجوزات";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDoctorsCard
            // 
            this.pnlDoctorsCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlDoctorsCard.Controls.Add(this.lblDoctorsStatus);
            this.pnlDoctorsCard.Controls.Add(this.lblDoctorsVal);
            this.pnlDoctorsCard.Controls.Add(this.lblDoctorsTitle);
            this.pnlDoctorsCard.FillColor = System.Drawing.Color.White;
            this.pnlDoctorsCard.Location = new System.Drawing.Point(510, 20);
            this.pnlDoctorsCard.Name = "pnlDoctorsCard";
            this.pnlDoctorsCard.Radius = 10;
            this.pnlDoctorsCard.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pnlDoctorsCard.ShadowDepth = 110;
            this.pnlDoctorsCard.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlDoctorsCard.Size = new System.Drawing.Size(225, 150);
            this.pnlDoctorsCard.TabIndex = 2;
            // 
            // lblDoctorsStatus
            // 
            this.lblDoctorsStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDoctorsStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblDoctorsStatus.Location = new System.Drawing.Point(15, 110);
            this.lblDoctorsStatus.Name = "lblDoctorsStatus";
            this.lblDoctorsStatus.Size = new System.Drawing.Size(195, 20);
            this.lblDoctorsStatus.TabIndex = 2;
            this.lblDoctorsStatus.Text = "نشط";
            this.lblDoctorsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDoctorsVal
            // 
            this.lblDoctorsVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblDoctorsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblDoctorsVal.Location = new System.Drawing.Point(15, 45);
            this.lblDoctorsVal.Name = "lblDoctorsVal";
            this.lblDoctorsVal.Size = new System.Drawing.Size(195, 51);
            this.lblDoctorsVal.TabIndex = 1;
            this.lblDoctorsVal.Text = "8";
            this.lblDoctorsVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDoctorsTitle
            // 
            this.lblDoctorsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblDoctorsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblDoctorsTitle.Location = new System.Drawing.Point(15, 16);
            this.lblDoctorsTitle.Name = "lblDoctorsTitle";
            this.lblDoctorsTitle.Size = new System.Drawing.Size(195, 20);
            this.lblDoctorsTitle.TabIndex = 0;
            this.lblDoctorsTitle.Text = "الأطباء";
            this.lblDoctorsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRevenueCard
            // 
            this.pnlRevenueCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlRevenueCard.Controls.Add(this.lblRevenueTrend);
            this.pnlRevenueCard.Controls.Add(this.lblRevenueVal);
            this.pnlRevenueCard.Controls.Add(this.lblRevenueTitle);
            this.pnlRevenueCard.FillColor = System.Drawing.Color.White;
            this.pnlRevenueCard.Location = new System.Drawing.Point(755, 20);
            this.pnlRevenueCard.Name = "pnlRevenueCard";
            this.pnlRevenueCard.Radius = 10;
            this.pnlRevenueCard.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pnlRevenueCard.ShadowDepth = 110;
            this.pnlRevenueCard.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlRevenueCard.Size = new System.Drawing.Size(245, 150);
            this.pnlRevenueCard.TabIndex = 3;
            // 
            // lblRevenueTrend
            // 
            this.lblRevenueTrend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblRevenueTrend.Location = new System.Drawing.Point(15, 110);
            this.lblRevenueTrend.Name = "lblRevenueTrend";
            this.lblRevenueTrend.Size = new System.Drawing.Size(215, 20);
            this.lblRevenueTrend.TabIndex = 2;
            this.lblRevenueTrend.Text = "+8% اليوم";
            this.lblRevenueTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRevenueVal
            // 
            this.lblRevenueVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblRevenueVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblRevenueVal.Location = new System.Drawing.Point(15, 45);
            this.lblRevenueVal.Name = "lblRevenueVal";
            this.lblRevenueVal.Size = new System.Drawing.Size(215, 51);
            this.lblRevenueVal.TabIndex = 1;
            this.lblRevenueVal.Text = "$4,120";
            this.lblRevenueVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(15, 16);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(215, 20);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "الإيرادات اليومية";
            this.lblRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlChartOuter
            // 
            this.pnlChartOuter.BackColor = System.Drawing.Color.Transparent;
            this.pnlChartOuter.Controls.Add(this.pnlChart);
            this.pnlChartOuter.Controls.Add(this.lblChartTitle);
            this.pnlChartOuter.FillColor = System.Drawing.Color.White;
            this.pnlChartOuter.Location = new System.Drawing.Point(20, 190);
            this.pnlChartOuter.Name = "pnlChartOuter";
            this.pnlChartOuter.Radius = 10;
            this.pnlChartOuter.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pnlChartOuter.ShadowDepth = 110;
            this.pnlChartOuter.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlChartOuter.Size = new System.Drawing.Size(430, 500);
            this.pnlChartOuter.TabIndex = 4;
            // 
            // pnlChart
            // 
            this.pnlChart.Location = new System.Drawing.Point(15, 60);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(400, 420);
            this.pnlChart.TabIndex = 1;
            this.pnlChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart_Paint);
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblChartTitle.Location = new System.Drawing.Point(20, 20);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(253, 21);
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.Text = "حجوزات اليوم (المخطط الزمني)";
            // 
            // pnlTodayAppOuter
            // 
            this.pnlTodayAppOuter.BackColor = System.Drawing.Color.Transparent;
            this.pnlTodayAppOuter.Controls.Add(this.dgvAppointments);
            this.pnlTodayAppOuter.Controls.Add(this.lblTodayAppTitle);
            this.pnlTodayAppOuter.FillColor = System.Drawing.Color.White;
            this.pnlTodayAppOuter.Location = new System.Drawing.Point(470, 190);
            this.pnlTodayAppOuter.Name = "pnlTodayAppOuter";
            this.pnlTodayAppOuter.Radius = 10;
            this.pnlTodayAppOuter.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pnlTodayAppOuter.ShadowDepth = 110;
            this.pnlTodayAppOuter.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlTodayAppOuter.Size = new System.Drawing.Size(290, 500);
            this.pnlTodayAppOuter.TabIndex = 5;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvAppointments.Location = new System.Drawing.Point(15, 60);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 35;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(260, 420);
            this.dgvAppointments.TabIndex = 1;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvAppointments.ThemeStyle.ReadOnly = true;
            this.dgvAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.Height = 35;
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAppointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAppointments_CellFormatting);
            // 
            // lblTodayAppTitle
            // 
            this.lblTodayAppTitle.AutoSize = true;
            this.lblTodayAppTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTodayAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblTodayAppTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTodayAppTitle.Name = "lblTodayAppTitle";
            this.lblTodayAppTitle.Size = new System.Drawing.Size(163, 21);
            this.lblTodayAppTitle.TabIndex = 0;
            this.lblTodayAppTitle.Text = "حجوزات اليوم";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuickActions.Controls.Add(this.btnActionPrintReport);
            this.pnlQuickActions.Controls.Add(this.btnActionNewConsultation);
            this.pnlQuickActions.Controls.Add(this.btnActionNewAppointment);
            this.pnlQuickActions.Controls.Add(this.btnActionNewPatient);
            this.pnlQuickActions.Controls.Add(this.lblQuickActionsTitle);
            this.pnlQuickActions.FillColor = System.Drawing.Color.White;
            this.pnlQuickActions.Location = new System.Drawing.Point(780, 190);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Radius = 10;
            this.pnlQuickActions.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pnlQuickActions.ShadowDepth = 110;
            this.pnlQuickActions.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlQuickActions.Size = new System.Drawing.Size(220, 500);
            this.pnlQuickActions.TabIndex = 6;
            // 
            // btnActionPrintReport
            // 
            this.btnActionPrintReport.BorderRadius = 10;
            this.btnActionPrintReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActionPrintReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActionPrintReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActionPrintReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActionPrintReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActionPrintReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnActionPrintReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnActionPrintReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnActionPrintReport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnActionPrintReport.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnActionPrintReport.Location = new System.Drawing.Point(15, 270);
            this.btnActionPrintReport.Name = "btnActionPrintReport";
            this.btnActionPrintReport.Size = new System.Drawing.Size(190, 45);
            this.btnActionPrintReport.TabIndex = 4;
            this.btnActionPrintReport.Text = "طباعة التقرير اليومي";
            this.btnActionPrintReport.Click += new System.EventHandler(this.btnActionPrintReport_Click);
            // 
            // btnActionNewConsultation
            // 
            this.btnActionNewConsultation.BorderRadius = 10;
            this.btnActionNewConsultation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActionNewConsultation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActionNewConsultation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActionNewConsultation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActionNewConsultation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActionNewConsultation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnActionNewConsultation.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnActionNewConsultation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnActionNewConsultation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnActionNewConsultation.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnActionNewConsultation.Location = new System.Drawing.Point(15, 200);
            this.btnActionNewConsultation.Name = "btnActionNewConsultation";
            this.btnActionNewConsultation.Size = new System.Drawing.Size(190, 45);
            this.btnActionNewConsultation.TabIndex = 3;
            this.btnActionNewConsultation.Text = "+ كشف جديد";
            this.btnActionNewConsultation.Click += new System.EventHandler(this.btnActionNewConsultation_Click);
            // 
            // btnActionNewAppointment
            // 
            this.btnActionNewAppointment.BorderRadius = 10;
            this.btnActionNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActionNewAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActionNewAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActionNewAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActionNewAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActionNewAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnActionNewAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnActionNewAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnActionNewAppointment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnActionNewAppointment.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnActionNewAppointment.Location = new System.Drawing.Point(15, 130);
            this.btnActionNewAppointment.Name = "btnActionNewAppointment";
            this.btnActionNewAppointment.Size = new System.Drawing.Size(190, 45);
            this.btnActionNewAppointment.TabIndex = 2;
            this.btnActionNewAppointment.Text = "+ حجز موعد";
            this.btnActionNewAppointment.Click += new System.EventHandler(this.btnActionNewAppointment_Click);
            // 
            // btnActionNewPatient
            // 
            this.btnActionNewPatient.BorderRadius = 10;
            this.btnActionNewPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActionNewPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActionNewPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActionNewPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActionNewPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActionNewPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnActionNewPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnActionNewPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnActionNewPatient.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnActionNewPatient.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnActionNewPatient.Location = new System.Drawing.Point(15, 60);
            this.btnActionNewPatient.Name = "btnActionNewPatient";
            this.btnActionNewPatient.Size = new System.Drawing.Size(190, 45);
            this.btnActionNewPatient.TabIndex = 1;
            this.btnActionNewPatient.Text = "+ مريض جديد";
            this.btnActionNewPatient.Click += new System.EventHandler(this.btnActionNewPatient_Click);
            // 
            // lblQuickActionsTitle
            // 
            this.lblQuickActionsTitle.AutoSize = true;
            this.lblQuickActionsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuickActionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblQuickActionsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            this.lblQuickActionsTitle.Size = new System.Drawing.Size(115, 21);
            this.lblQuickActionsTitle.TabIndex = 0;
            this.lblQuickActionsTitle.Text = "إجراءات سريعة";
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlQuickActions);
            this.Controls.Add(this.pnlTodayAppOuter);
            this.Controls.Add(this.pnlChartOuter);
            this.Controls.Add(this.pnlRevenueCard);
            this.Controls.Add(this.pnlDoctorsCard);
            this.Controls.Add(this.pnlAppointmentsCard);
            this.Controls.Add(this.pnlPatientsCard);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1024, 721);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.pnlPatientsCard.ResumeLayout(false);
            this.pnlPatientsCard.PerformLayout();
            this.pnlAppointmentsCard.ResumeLayout(false);
            this.pnlAppointmentsCard.PerformLayout();
            this.pnlDoctorsCard.ResumeLayout(false);
            this.pnlDoctorsCard.PerformLayout();
            this.pnlRevenueCard.ResumeLayout(false);
            this.pnlRevenueCard.PerformLayout();
            this.pnlChartOuter.ResumeLayout(false);
            this.pnlChartOuter.PerformLayout();
            this.pnlTodayAppOuter.ResumeLayout(false);
            this.pnlTodayAppOuter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlPatientsCard;
        private System.Windows.Forms.Label lblPatientTodayTitle;
        private System.Windows.Forms.Label lblPatientTodayVal;
        private System.Windows.Forms.Label lblPatientTodayTrend;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlAppointmentsCard;
        private System.Windows.Forms.Label lblAppTotalVal;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblCancelledApp;
        private System.Windows.Forms.Label lblConfirmedApp;
        private System.Windows.Forms.Label lblPendingApp;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDoctorsCard;
        private System.Windows.Forms.Label lblDoctorsStatus;
        private System.Windows.Forms.Label lblDoctorsVal;
        private System.Windows.Forms.Label lblDoctorsTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlRevenueCard;
        private System.Windows.Forms.Label lblRevenueTrend;
        private System.Windows.Forms.Label lblRevenueVal;
        private System.Windows.Forms.Label lblRevenueTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlChartOuter;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel pnlChart;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTodayAppOuter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblTodayAppTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlQuickActions;
        private System.Windows.Forms.Label lblQuickActionsTitle;
        private Guna.UI2.WinForms.Guna2Button btnActionNewPatient;
        private Guna.UI2.WinForms.Guna2Button btnActionPrintReport;
        private Guna.UI2.WinForms.Guna2Button btnActionNewConsultation;
        private Guna.UI2.WinForms.Guna2Button btnActionNewAppointment;
    }
}
