using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LockedDownKioskMode
{
    public partial class PasswordClass : Form
    {
        //Global Variables Here
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        //Constructors Here
        public PasswordClass()
        {
            InitializeComponent();
        }

        //Button Click Methods
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (passBox.Text == "AdminLogout")
            {
                //This will Log the Kiosk User Off
                ExitWindowsEx(0 | 0x00000004, 0);
            }
            else if (String.IsNullOrEmpty(passBox.Text))
            {
                //Purposefully left Empty for Null/Empty Text field
            }
            else
            {
                MessageBox.Show("Password is Incorrect.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
