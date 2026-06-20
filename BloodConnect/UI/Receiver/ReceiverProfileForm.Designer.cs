namespace BloodConnect.UI.Receiver
{
    partial class ReceiverProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnUpdate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            lblFullName = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblBloodGroup = new System.Windows.Forms.Label();
            cmbBloodGroup = new System.Windows.Forms.ComboBox();
            lblPhone = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            lblAddress = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(400, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Receiver Profile";
            // 
            // lblInfo
            // 
            lblInfo.ForeColor = System.Drawing.Color.Gray;
            lblInfo.Location = new System.Drawing.Point(25, 55);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(700, 25);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Update your contact and blood group needed";
            // 
            // lblFullName
            // 
            lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblFullName.Location = new System.Drawing.Point(25, 90);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(120, 23);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full name:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtFullName.Location = new System.Drawing.Point(25, 114);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(400, 25);
            txtFullName.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblEmail.Location = new System.Drawing.Point(25, 155);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(120, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtEmail.Location = new System.Drawing.Point(25, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(400, 25);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblBloodGroup.Location = new System.Drawing.Point(25, 220);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new System.Drawing.Size(180, 23);
            lblBloodGroup.TabIndex = 6;
            lblBloodGroup.Text = "Blood group needed:";
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodGroup.Location = new System.Drawing.Point(25, 244);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new System.Drawing.Size(150, 25);
            cmbBloodGroup.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblPhone.Location = new System.Drawing.Point(25, 285);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(120, 23);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPhone.Location = new System.Drawing.Point(25, 309);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(400, 25);
            txtPhone.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblAddress.Location = new System.Drawing.Point(25, 350);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(120, 23);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtAddress.Location = new System.Drawing.Point(25, 374);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(500, 25);
            txtAddress.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(25, 420);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(160, 40);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ReceiverProfileForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(870, 620);
            Controls.Add(lblTitle);
            Controls.Add(lblInfo);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblBloodGroup);
            Controls.Add(cmbBloodGroup);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnUpdate);
            Name = "ReceiverProfileForm";
            Load += ReceiverProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
