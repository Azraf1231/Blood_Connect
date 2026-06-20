namespace BloodConnect.UI.Receiver
{
    partial class ReceiverRequestsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Label lblEditSection;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblDonorInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            btnRefresh = new System.Windows.Forms.Button();
            lblGrid = new System.Windows.Forms.Label();
            dgvRequests = new System.Windows.Forms.DataGridView();
            lblEditSection = new System.Windows.Forms.Label();
            lblBloodGroup = new System.Windows.Forms.Label();
            cmbBloodGroup = new System.Windows.Forms.ComboBox();
            lblUnits = new System.Windows.Forms.Label();
            txtUnits = new System.Windows.Forms.TextBox();
            lblHospital = new System.Windows.Forms.Label();
            txtHospital = new System.Windows.Forms.TextBox();
            lblPhone = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            lblStatus = new System.Windows.Forms.Label();
            lblStatusValue = new System.Windows.Forms.Label();
            lblDonorInfo = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(25, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(500, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Blood Requests";
            // 
            // lblSearch
            // 
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSearch.Location = new System.Drawing.Point(25, 48);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(60, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearch.Location = new System.Drawing.Point(25, 72);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(260, 25);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(295, 70);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(80, 32);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblGrid
            // 
            lblGrid.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblGrid.Location = new System.Drawing.Point(25, 108);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new System.Drawing.Size(700, 22);
            lblGrid.TabIndex = 4;
            lblGrid.Text = "Your requests (status updated by admin; donor shown when assigned):";
            // 
            // dgvRequests
            // 
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AllowUserToDeleteRows = false;
            dgvRequests.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.BackgroundColor = System.Drawing.Color.White;
            dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new System.Drawing.Point(25, 132);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowHeadersVisible = false;
            dgvRequests.Size = new System.Drawing.Size(820, 240);
            dgvRequests.TabIndex = 5;
            dgvRequests.CellClick += dgvRequests_CellClick;
            dgvRequests.CellContentClick += dgvRequests_CellContentClick;
            // 
            // lblEditSection
            // 
            lblEditSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblEditSection.Location = new System.Drawing.Point(25, 382);
            lblEditSection.Name = "lblEditSection";
            lblEditSection.Size = new System.Drawing.Size(250, 23);
            lblEditSection.TabIndex = 6;
            lblEditSection.Text = "Edit pending request only:";
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblBloodGroup.Location = new System.Drawing.Point(25, 408);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new System.Drawing.Size(80, 20);
            lblBloodGroup.TabIndex = 7;
            lblBloodGroup.Text = "Blood group:";
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbBloodGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodGroup.Location = new System.Drawing.Point(25, 428);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new System.Drawing.Size(70, 23);
            cmbBloodGroup.TabIndex = 8;
            cmbBloodGroup.SelectedIndexChanged += cmbBloodGroup_SelectedIndexChanged;
            // 
            // lblUnits
            // 
            lblUnits.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblUnits.Location = new System.Drawing.Point(105, 408);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new System.Drawing.Size(50, 20);
            lblUnits.TabIndex = 9;
            lblUnits.Text = "Units:";
            // 
            // txtUnits
            // 
            txtUnits.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtUnits.Location = new System.Drawing.Point(105, 428);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new System.Drawing.Size(50, 23);
            txtUnits.TabIndex = 10;
            // 
            // lblHospital
            // 
            lblHospital.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblHospital.Location = new System.Drawing.Point(165, 408);
            lblHospital.Name = "lblHospital";
            lblHospital.Size = new System.Drawing.Size(60, 20);
            lblHospital.TabIndex = 11;
            lblHospital.Text = "Hospital:";
            // 
            // txtHospital
            // 
            txtHospital.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtHospital.Location = new System.Drawing.Point(165, 428);
            txtHospital.Name = "txtHospital";
            txtHospital.Size = new System.Drawing.Size(180, 23);
            txtHospital.TabIndex = 12;
            // 
            // lblPhone
            // 
            lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPhone.Location = new System.Drawing.Point(355, 408);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(80, 20);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Your phone:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtPhone.Location = new System.Drawing.Point(355, 428);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(110, 23);
            txtPhone.TabIndex = 14;
            // 
            // lblStatus
            // 
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblStatus.Location = new System.Drawing.Point(475, 408);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(50, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Status:";
            // 
            // lblStatusValue
            // 
            lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblStatusValue.Location = new System.Drawing.Point(475, 428);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new System.Drawing.Size(100, 27);
            lblStatusValue.TabIndex = 16;
            lblStatusValue.Text = "-";
            // 
            // lblDonorInfo
            // 
            lblDonorInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDonorInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            lblDonorInfo.Location = new System.Drawing.Point(25, 465);
            lblDonorInfo.Name = "lblDonorInfo";
            lblDonorInfo.Size = new System.Drawing.Size(820, 40);
            lblDonorInfo.TabIndex = 17;
            lblDonorInfo.Text = "Assigned donor contact appears here after admin links a donor to your request.";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(590, 424);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 34);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(675, 424);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 34);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // ReceiverRequestsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(870, 620);
            Controls.Add(lblTitle);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(lblGrid);
            Controls.Add(dgvRequests);
            Controls.Add(lblEditSection);
            Controls.Add(lblBloodGroup);
            Controls.Add(cmbBloodGroup);
            Controls.Add(lblUnits);
            Controls.Add(txtUnits);
            Controls.Add(lblHospital);
            Controls.Add(txtHospital);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblStatus);
            Controls.Add(lblStatusValue);
            Controls.Add(lblDonorInfo);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "ReceiverRequestsForm";
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
