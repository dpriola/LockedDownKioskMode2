using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockedDownKioskMode
{
    public partial class PasswordClass : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        public PasswordClass()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (passBox.Text == "test")
            {
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
