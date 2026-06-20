using System;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Receiver
{
    public partial class ReceiverDashboardHomeForm : Form
    {
        public ReceiverDashboardHomeForm()
        {
            InitializeComponent();
        }

        public ReceiverDashboardHomeForm(int userId, string fullName)
            : this()
        {
            lblTitle.Text = "Welcome, " + fullName;
            if (!IsDesignTime())
                LoadStats(userId);
        }

        private static bool IsDesignTime()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        private void LoadStats(int userId)
        {
            try
            {
                DataAccess da = new DataAccess();
                int requests = Convert.ToInt32(da.ExecuteScalar(
                    "SELECT COUNT(*) FROM BloodRequests WHERE UserID = @userId",
                    new[] { new SqlParameter("@userId", userId) }));
                int pending = Convert.ToInt32(da.ExecuteScalar(
                    "SELECT COUNT(*) FROM BloodRequests WHERE UserID = @userId AND Status = 'Pending'",
                    new[] { new SqlParameter("@userId", userId) }));
                int stock = Convert.ToInt32(da.ExecuteScalar(
                    "SELECT COUNT(*) FROM BloodStock WHERE UnitsAvailable > 0"));
                lblRequestsCount.Text = requests.ToString();
                lblPendingCount.Text = pending.ToString();
                lblStockCount.Text = stock.ToString();
            }
            catch (Exception ex)
            {
                if (!IsDesignTime())
                    MessageBox.Show("Dashboard error: " + ex.Message);
            }
        }

        private void lblRequestsTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblStockTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPendingTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
