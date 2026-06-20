namespace BloodConnect.UI.Donor
{
    partial class DonorAppointmentsForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblEditSection;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdateDate;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            lblGrid = new System.Windows.Forms.Label();
            dgvAppointments = new System.Windows.Forms.DataGridView();
            lblEditSection = new System.Windows.Forms.Label();
            lblAppointmentDate = new System.Windows.Forms.Label();
            dtpAppointment = new System.Windows.Forms.DateTimePicker();
            lblStatus = new System.Windows.Forms.Label();
            lblStatusValue = new System.Windows.Forms.Label();
            lblContactInfo = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdateDate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(500, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Donation Appointments";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSearch.Location = new System.Drawing.Point(25, 58);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(52, 19);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(25, 82);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(280, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblGrid
            // 
            lblGrid.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblGrid.Location = new System.Drawing.Point(25, 118);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new System.Drawing.Size(700, 22);
            lblGrid.TabIndex = 3;
            lblGrid.Text = "Your appointment requests (status is updated by admin only):";
            // 
            // dgvAppointments
            // 
            dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.Location = new System.Drawing.Point(25, 142);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.Size = new System.Drawing.Size(820, 220);
            dgvAppointments.TabIndex = 4;
            dgvAppointments.CellClick += dgvAppointments_CellClick;
            // 
            // lblEditSection
            // 
            lblEditSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblEditSection.Location = new System.Drawing.Point(25, 372);
            lblEditSection.Name = "lblEditSection";
            lblEditSection.Size = new System.Drawing.Size(600, 22);
            lblEditSection.TabIndex = 5;
            lblEditSection.Text = "Request new appointment or change a pending request:";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblAppointmentDate.Location = new System.Drawing.Point(25, 400);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new System.Drawing.Size(182, 19);
            lblAppointmentDate.TabIndex = 6;
            lblAppointmentDate.Text = "Preferred appointment date:";
            // 
            // dtpAppointment
            // 
            dtpAppointment.Location = new System.Drawing.Point(25, 424);
            dtpAppointment.Name = "dtpAppointment";
            dtpAppointment.Size = new System.Drawing.Size(280, 23);
            dtpAppointment.TabIndex = 7;
            dtpAppointment.ValueChanged += dtpAppointment_ValueChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblStatus.Location = new System.Drawing.Point(320, 400);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(121, 19);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status (read-only):";
            lblStatus.Click += lblStatus_Click;
            // 
            // lblStatusValue
            // 
            lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblStatusValue.Location = new System.Drawing.Point(320, 424);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new System.Drawing.Size(200, 28);
            lblStatusValue.TabIndex = 9;
            lblStatusValue.Text = "-";
            // 
            // lblContactInfo
            // 
            lblContactInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblContactInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            lblContactInfo.Location = new System.Drawing.Point(25, 458);
            lblContactInfo.Name = "lblContactInfo";
            lblContactInfo.Size = new System.Drawing.Size(820, 45);
            lblContactInfo.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(25, 510);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(150, 34);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Request Appointment";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdateDate
            // 
            btnUpdateDate.Location = new System.Drawing.Point(185, 510);
            btnUpdateDate.Name = "btnUpdateDate";
            btnUpdateDate.Size = new System.Drawing.Size(170, 34);
            btnUpdateDate.TabIndex = 12;
            btnUpdateDate.Text = "Update Date (Pending only)";
            btnUpdateDate.Click += btnUpdateDate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(365, 510);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(120, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel Request";
            btnCancel.Click += btnCancel_Click;
            // 
            // DonorAppointmentsForm
            // 
            ClientSize = new System.Drawing.Size(870, 620);
            Controls.Add(lblTitle);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblGrid);
            Controls.Add(dgvAppointments);
            Controls.Add(lblEditSection);
            Controls.Add(lblAppointmentDate);
            Controls.Add(dtpAppointment);
            Controls.Add(lblStatus);
            Controls.Add(lblStatusValue);
            Controls.Add(lblContactInfo);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdateDate);
            Controls.Add(btnCancel);
            Name = "DonorAppointmentsForm";
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
