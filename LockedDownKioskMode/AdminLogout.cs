using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LockedDownKioskMode
{
    public partial class AdminLogout : Form
    {
        public AdminLogout()
        {
            InitializeComponent();
        }

        //Will Shutdown the Computer
        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        //Will Restart the Computer
        private void RestartButton_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        //Shows the Admin Logout Window
        private void AdminLogoutButton_Click(object sender, EventArgs e)
        {
            PasswordClass pc = new PasswordClass();
            DialogResult dialogResult = pc.ShowDialog();
        }
    }
}
