using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LockedDownKioskMode
{
    public partial class Form1 : Form
    {
        //Global Variables Here
        ProcessStartInfo URL;
        ProcessStartInfo Program;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void LDBButton_Click(object sender, EventArgs e)
        {
            Program = new ProcessStartInfo("C:\\Program Files (x86)\\Respondus\\LockDown Browser\\LockDownBrowser.exe");
            Process.Start(Program);
        }

        private void WebAdvisorButton_Click(object sender, EventArgs e)
        {
            URL = new ProcessStartInfo("https://wa-dsu.prod.sdbor.edu/WebAdvisor/webadvisor?TYPE=M&PID=CORE-WBMAIN&TOKENIDX=3890244685");
            Process.Start(URL);
        }

        private void D2LButton_Click(object sender, EventArgs e)
        {
            URL = new ProcessStartInfo("https://d2l.sdbor.edu/d2l/home");
            Process.Start(URL);
        }

        private void WebMailButton_Click(object sender, EventArgs e)
        {
            URL = new ProcessStartInfo("https://webmail.dsu.edu/");
            Process.Start(URL);
        }

        private void DSUStudentHomeButton_Click(object sender, EventArgs e)
        {
            URL = new ProcessStartInfo("https://portal.sdbor.edu/dsu-student/Pages/default.aspx");
            Process.Start(URL);
        }

        private void ProctorSignUpButton_Click(object sender, EventArgs e)
        {
            URL = new ProcessStartInfo("https://secure.dsu.edu/apps/proctor/");
            Process.Start(URL);
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            Program = new ProcessStartInfo("C:\\Windows\\WinSxS\\amd64_microsoft-windows-calc_31bf3856ad364e35_10.0.16299.15_none_ccaa2d2d8be06b27\\calc.exe");
            Process.Start(Program);
        }

        private void DefaultPrinterButton_Click(object sender, EventArgs e)
        {
            DefaultPrinter dp = new DefaultPrinter();
            DialogResult dialogResult = dp.ShowDialog();
        }

        private void AdminLogOutButton_Click(object sender, EventArgs e)
        {
            AdminLogout al = new AdminLogout();
            DialogResult dialogResult = al.ShowDialog();
        }
    }
}
