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

        private Rectangle LDBButtonRect;
        private Rectangle WebAdvisorButtonRect;
        private Rectangle D2LButtonRect;
        private Rectangle WebMailButtonRect;
        private Rectangle DSUStudentHomeButtonRect;
        private Rectangle ProctorSignUpButtonRect;
        private Rectangle CalcButtonRect;
        private Rectangle DefaultPrinterButtonRect;
        private Rectangle AdminLogOutButtonRect;

        private Rectangle BannerRect;

        private Size formOriginalSize;



        public KioskMode()
        {
            InitializeComponent();
            
        }

        private void KioskMode_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;

            LDBButtonRect = new Rectangle(LDBButton.Location.X, LDBButton.Location.Y, LDBButton.Width, LDBButton.Height);
            WebAdvisorButtonRect = new Rectangle(WebAdvisorButton.Location.X, WebAdvisorButton.Location.Y, WebAdvisorButton.Width, WebAdvisorButton.Height);
            D2LButtonRect = new Rectangle(D2LButton.Location.X, D2LButton.Location.Y, D2LButton.Width, D2LButton.Height);
            WebMailButtonRect = new Rectangle(WebMailButton.Location.X, WebMailButton.Location.Y, WebMailButton.Width, WebMailButton.Height);
            DSUStudentHomeButtonRect = new Rectangle(DSUStudentHomeButton.Location.X, DSUStudentHomeButton.Location.Y, DSUStudentHomeButton.Width, DSUStudentHomeButton.Height);
            ProctorSignUpButtonRect = new Rectangle(ProctorSignUpButton.Location.X, ProctorSignUpButton.Location.Y, ProctorSignUpButton.Width, ProctorSignUpButton.Height);
            CalcButtonRect = new Rectangle(CalcButton.Location.X, CalcButton.Location.Y, CalcButton.Width, CalcButton.Height);
            DefaultPrinterButtonRect = new Rectangle(DefaultPrinterButton.Location.X, DefaultPrinterButton.Location.Y, DefaultPrinterButton.Width, DefaultPrinterButton.Height);
            AdminLogOutButtonRect = new Rectangle(AdminLogOutButton.Location.X, AdminLogOutButton.Location.Y, AdminLogOutButton.Width, AdminLogOutButton.Height);

            BannerRect = new Rectangle(ScrollingAnnouncement.Location.X, ScrollingAnnouncement.Location.Y, ScrollingAnnouncement.Width, ScrollingAnnouncement.Height);

            timer1.Enabled = true;
            LockDownClass LDC = new LockDownClass();
            LDC.main();
        }

        private void ResizeChildrenControls()
        {
            ResizeControl(LDBButtonRect, LDBButton);
            ResizeControl(WebAdvisorButtonRect, WebAdvisorButton);
            ResizeControl(D2LButtonRect, D2LButton);
            ResizeControl(WebMailButtonRect, WebMailButton);
            ResizeControl(DSUStudentHomeButtonRect, DSUStudentHomeButton);
            ResizeControl(ProctorSignUpButtonRect, ProctorSignUpButton);
            ResizeControl(CalcButtonRect, CalcButton);
            ResizeControl(DefaultPrinterButtonRect, DefaultPrinterButton);
            ResizeControl(AdminLogOutButtonRect, AdminLogOutButton);

            ResizeControl(BannerRect, ScrollingAnnouncement);
        }

        private void ResizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);

            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void KioskMode_Resize(object sender, EventArgs e)
        {
            ResizeChildrenControls();
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
