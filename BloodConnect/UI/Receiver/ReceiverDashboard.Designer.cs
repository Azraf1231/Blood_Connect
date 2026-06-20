namespace BloodConnect.UI.Receiver
{
    partial class ReceiverDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSearchBlood;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            sidebarPanel = new System.Windows.Forms.Panel();
            lblLogo = new System.Windows.Forms.Label();
            btnDashboard = new System.Windows.Forms.Button();
            btnProfile = new System.Windows.Forms.Button();
            btnSearchBlood = new System.Windows.Forms.Button();
            btnRequests = new System.Windows.Forms.Button();
            btnNewRequest = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            mainPanel = new System.Windows.Forms.Panel();
            contentPanel = new System.Windows.Forms.Panel();
            sidebarPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = System.Drawing.Color.FromArgb(25, 55, 95);
            sidebarPanel.Controls.Add(lblLogo);
            sidebarPanel.Controls.Add(btnDashboard);
            sidebarPanel.Controls.Add(btnProfile);
            sidebarPanel.Controls.Add(btnSearchBlood);
            sidebarPanel.Controls.Add(btnRequests);
            sidebarPanel.Controls.Add(btnNewRequest);
            sidebarPanel.Controls.Add(btnLogout);
            sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            sidebarPanel.Location = new System.Drawing.Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new System.Drawing.Size(230, 650);
            sidebarPanel.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(0, 25);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(230, 45);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "RECEIVER PORTAL";
            lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblLogo.Click += lblLogo_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnDashboard.ForeColor = System.Drawing.Color.White;
            btnDashboard.Location = new System.Drawing.Point(15, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new System.Drawing.Size(200, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnProfile.ForeColor = System.Drawing.Color.White;
            btnProfile.Location = new System.Drawing.Point(15, 148);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new System.Drawing.Size(200, 42);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnSearchBlood
            // 
            btnSearchBlood.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btnSearchBlood.FlatAppearance.BorderSize = 0;
            btnSearchBlood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearchBlood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSearchBlood.ForeColor = System.Drawing.Color.White;
            btnSearchBlood.Location = new System.Drawing.Point(15, 205);
            btnSearchBlood.Name = "btnSearchBlood";
            btnSearchBlood.Size = new System.Drawing.Size(200, 42);
            btnSearchBlood.TabIndex = 3;
            btnSearchBlood.Text = "Search Blood";
            btnSearchBlood.UseVisualStyleBackColor = false;
            btnSearchBlood.Click += btnSearchBlood_Click;
            // 
            // btnRequests
            // 
            btnRequests.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btnRequests.FlatAppearance.BorderSize = 0;
            btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRequests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnRequests.ForeColor = System.Drawing.Color.White;
            btnRequests.Location = new System.Drawing.Point(15, 264);
            btnRequests.Name = "btnRequests";
            btnRequests.Size = new System.Drawing.Size(200, 42);
            btnRequests.TabIndex = 4;
            btnRequests.Text = "My Requests";
            btnRequests.UseVisualStyleBackColor = false;
            btnRequests.Click += btnRequests_Click;
            // 
            // btnNewRequest
            // 
            btnNewRequest.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btnNewRequest.FlatAppearance.BorderSize = 0;
            btnNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewRequest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnNewRequest.ForeColor = System.Drawing.Color.White;
            btnNewRequest.Location = new System.Drawing.Point(15, 322);
            btnNewRequest.Name = "btnNewRequest";
            btnNewRequest.Size = new System.Drawing.Size(200, 42);
            btnNewRequest.TabIndex = 5;
            btnNewRequest.Text = "New Request";
            btnNewRequest.UseVisualStyleBackColor = false;
            btnNewRequest.Click += btnNewRequest_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnLogout.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Location = new System.Drawing.Point(15, 590);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(200, 42);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            mainPanel.Controls.Add(contentPanel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(230, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(870, 650);
            mainPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = System.Drawing.Color.White;
            contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            contentPanel.Location = new System.Drawing.Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new System.Drawing.Size(870, 650);
            contentPanel.TabIndex = 0;
            // 
            // ReceiverDashboard
            // 
            ClientSize = new System.Drawing.Size(1100, 650);
            Controls.Add(mainPanel);
            Controls.Add(sidebarPanel);
            Name = "ReceiverDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Blood Connect - Receiver";
            Load += ReceiverDashboard_Load;
            sidebarPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
