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

        public Form1()
        {
            InitializeComponent();
            
        }

        private void LDBButton_Click(object sender, EventArgs e)
        {

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

        }

        private void DefaultPrinterButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogOutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
