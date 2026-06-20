using System.Drawing;
using System.Windows.Forms;

namespace BloodConnect.UI.Receiver
{
    partial class ReceiverDashboardHomeForm
    {
        private Panel panelMain;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblRequestsTitle;
        private Label lblRequestsCount;
        private Label lblPendingTitle;
        private Label lblPendingCount;
        private Label lblStockTitle;
        private Label lblStockCount;

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblRequestsTitle = new Label();
            lblRequestsCount = new Label();
            lblPendingTitle = new Label();
            lblPendingCount = new Label();
            lblStockTitle = new Label();
            lblStockCount = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblSubtitle);
            panelMain.Controls.Add(lblRequestsTitle);
            panelMain.Controls.Add(lblRequestsCount);
            panelMain.Controls.Add(lblPendingTitle);
            panelMain.Controls.Add(lblPendingCount);
            panelMain.Controls.Add(lblStockTitle);
            panelMain.Controls.Add(lblStockCount);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(870, 620);
            panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome, Receiver";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(30, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(500, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Blood Receiver Dashboard";
            lblSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // lblRequestsTitle
            // 
            lblRequestsTitle.Font = new Font("Segoe UI", 10F);
            lblRequestsTitle.ForeColor = Color.Black;
            lblRequestsTitle.Location = new Point(30, 130);
            lblRequestsTitle.Name = "lblRequestsTitle";
            lblRequestsTitle.Size = new Size(250, 24);
            lblRequestsTitle.TabIndex = 2;
            lblRequestsTitle.Text = "My Requests";
            lblRequestsTitle.Click += lblRequestsTitle_Click;
            // 
            // lblRequestsCount
            // 
            lblRequestsCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRequestsCount.ForeColor = Color.FromArgb(0, 123, 255);
            lblRequestsCount.Location = new Point(30, 158);
            lblRequestsCount.Name = "lblRequestsCount";
            lblRequestsCount.Size = new Size(300, 36);
            lblRequestsCount.TabIndex = 3;
            lblRequestsCount.Text = "0";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.Font = new Font("Segoe UI", 10F);
            lblPendingTitle.ForeColor = Color.Black;
            lblPendingTitle.Location = new Point(30, 230);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(250, 24);
            lblPendingTitle.TabIndex = 4;
            lblPendingTitle.Text = "Pending Requests";
            lblPendingTitle.Click += lblPendingTitle_Click;
            // 
            // lblPendingCount
            // 
            lblPendingCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPendingCount.ForeColor = Color.FromArgb(0, 123, 255);
            lblPendingCount.Location = new Point(30, 258);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(300, 36);
            lblPendingCount.TabIndex = 5;
            lblPendingCount.Text = "0";
            // 
            // lblStockTitle
            // 
            lblStockTitle.Font = new Font("Segoe UI", 10F);
            lblStockTitle.ForeColor = Color.Black;
            lblStockTitle.Location = new Point(30, 330);
            lblStockTitle.Name = "lblStockTitle";
            lblStockTitle.Size = new Size(280, 24);
            lblStockTitle.TabIndex = 6;
            lblStockTitle.Text = "Blood Groups In Stock";
            lblStockTitle.Click += lblStockTitle_Click;
            // 
            // lblStockCount
            // 
            lblStockCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStockCount.ForeColor = Color.FromArgb(0, 123, 255);
            lblStockCount.Location = new Point(30, 358);
            lblStockCount.Name = "lblStockCount";
            lblStockCount.Size = new Size(300, 36);
            lblStockCount.TabIndex = 7;
            lblStockCount.Text = "0";
            // 
            // ReceiverDashboardHomeForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(870, 620);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            Name = "ReceiverDashboardHomeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Receiver Dashboard Home";
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
