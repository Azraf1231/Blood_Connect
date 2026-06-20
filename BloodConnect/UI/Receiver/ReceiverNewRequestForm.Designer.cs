namespace BloodConnect.UI.Receiver
{
    partial class ReceiverNewRequestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.lblHospital = new System.Windows.Forms.Label();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Submit New Blood Request";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBloodGroup.Location = new System.Drawing.Point(25, 75);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(180, 23);
            this.lblBloodGroup.TabIndex = 1;
            this.lblBloodGroup.Text = "Blood group needed:";
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(25, 100);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(200, 31);
            this.cmbBloodGroup.TabIndex = 2;
            this.cmbBloodGroup.SelectedIndex = 0;
            // 
            // lblUnits
            // 
            this.lblUnits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnits.Location = new System.Drawing.Point(25, 145);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(120, 23);
            this.lblUnits.TabIndex = 3;
            this.lblUnits.Text = "Units required:";
            // 
            // txtUnits
            // 
            this.txtUnits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUnits.Location = new System.Drawing.Point(25, 170);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(200, 30);
            this.txtUnits.TabIndex = 4;
            // 
            // lblHospital
            // 
            this.lblHospital.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHospital.Location = new System.Drawing.Point(25, 215);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(120, 23);
            this.lblHospital.TabIndex = 5;
            this.lblHospital.Text = "Hospital name:";
            // 
            // txtHospital
            // 
            this.txtHospital.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHospital.Location = new System.Drawing.Point(25, 240);
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(400, 30);
            this.txtHospital.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(25, 285);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(120, 23);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Contact phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(25, 310);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 30);
            this.txtPhone.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(25, 360);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 40);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ReceiverNewRequestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.cmbBloodGroup);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.txtHospital);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSubmit);
            this.Name = "ReceiverNewRequestForm";
            this.ResumeLayout(false);
        }
    }
}
