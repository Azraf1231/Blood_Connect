namespace BloodConnect.UI.Receiver
{
    partial class ReceiverSearchBloodForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvStock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            lblBloodGroup = new System.Windows.Forms.Label();
            cmbBloodGroup = new System.Windows.Forms.ComboBox();
            lblLocation = new System.Windows.Forms.Label();
            txtLocation = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            lblResults = new System.Windows.Forms.Label();
            dgvStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(550, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Search Blood by Group and Location";
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblBloodGroup.Location = new System.Drawing.Point(25, 60);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new System.Drawing.Size(100, 23);
            lblBloodGroup.TabIndex = 1;
            lblBloodGroup.Text = "Blood group:";
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbBloodGroup.Items.AddRange(new object[] { "All", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodGroup.Location = new System.Drawing.Point(25, 84);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new System.Drawing.Size(120, 25);
            cmbBloodGroup.TabIndex = 2;
            cmbBloodGroup.SelectedIndexChanged += cmbBloodGroup_SelectedIndexChanged;
            // 
            // lblLocation
            // 
            lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblLocation.Location = new System.Drawing.Point(165, 60);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new System.Drawing.Size(150, 23);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "Hospital / location:";
            // 
            // txtLocation
            // 
            txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtLocation.Location = new System.Drawing.Point(165, 84);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new System.Drawing.Size(280, 30);
            txtLocation.TabIndex = 4;
            txtLocation.TextChanged += txtLocation_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(460, 82);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(90, 32);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblResults
            // 
            lblResults.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblResults.Location = new System.Drawing.Point(25, 125);
            lblResults.Name = "lblResults";
            lblResults.Size = new System.Drawing.Size(300, 23);
            lblResults.TabIndex = 6;
            lblResults.Text = "Available blood stock:";
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = System.Drawing.Color.White;
            dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new System.Drawing.Point(25, 150);
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersVisible = false;
            dgvStock.Size = new System.Drawing.Size(820, 450);
            dgvStock.TabIndex = 7;
            dgvStock.CellContentClick += dgvStock_CellContentClick;
            // 
            // ReceiverSearchBloodForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(870, 620);
            Controls.Add(lblTitle);
            Controls.Add(lblBloodGroup);
            Controls.Add(cmbBloodGroup);
            Controls.Add(lblLocation);
            Controls.Add(txtLocation);
            Controls.Add(btnSearch);
            Controls.Add(lblResults);
            Controls.Add(dgvStock);
            Name = "ReceiverSearchBloodForm";
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
