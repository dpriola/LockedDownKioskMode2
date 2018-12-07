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
    public partial class KioskMode : Form
    {
        //Global Variables Here
        ProcessStartInfo URL;
        ProcessStartInfo Program;

        public KioskMode()
        {
            InitializeComponent();
            
        }

        private void KioskMode_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LockDownClass LDC = new LockDownClass();
            LDC.main();
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

        private void ScrollingAnnouncement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://dsu.edu/");

            ScrollingAnnouncement.LinkVisited = true;

            ScrollingAnnouncement.ActiveLinkColor = Color.Orange;
            ScrollingAnnouncement.VisitedLinkColor = Color.Purple;
            ScrollingAnnouncement.LinkColor = Color.Blue;
            ScrollingAnnouncement.DisabledLinkColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScrollingAnnouncement.Left = ScrollingAnnouncement.Left + 5;
            if (ScrollingAnnouncement.Left + ScrollingAnnouncement.Width <= 0)
            {
                ScrollingAnnouncement.Left = this.Width;
            }
        }
    }
}
