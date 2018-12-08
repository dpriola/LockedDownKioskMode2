using System.Windows.Forms;

namespace LockedDownKioskMode
{
    partial class KioskMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KioskMode));
            this.LDBButton = new System.Windows.Forms.Button();
            this.WebAdvisorButton = new System.Windows.Forms.Button();
            this.D2LButton = new System.Windows.Forms.Button();
            this.WebMailButton = new System.Windows.Forms.Button();
            this.DSUStudentHomeButton = new System.Windows.Forms.Button();
            this.ProctorSignUpButton = new System.Windows.Forms.Button();
            this.CalcButton = new System.Windows.Forms.Button();
            this.DefaultPrinterButton = new System.Windows.Forms.Button();
            this.AdminLogOutButton = new System.Windows.Forms.Button();
            this.ScrollingAnnouncement = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LDBLabel = new System.Windows.Forms.Label();
            this.D2LLabel = new System.Windows.Forms.Label();
            this.WebAdvisorLabel = new System.Windows.Forms.Label();
            this.WebMailLabel = new System.Windows.Forms.Label();
            this.DSUStudentLabel = new System.Windows.Forms.Label();
            this.ProctorLabel = new System.Windows.Forms.Label();
            this.CalcLabel = new System.Windows.Forms.Label();
            this.PrinterLabel = new System.Windows.Forms.Label();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LDBButton
            // 
            this.LDBButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LDBButton.Image = ((System.Drawing.Image)(resources.GetObject("LDBButton.Image")));
            this.LDBButton.Location = new System.Drawing.Point(53, 116);
            this.LDBButton.Name = "LDBButton";
            this.LDBButton.Size = new System.Drawing.Size(150, 150);
            this.LDBButton.TabIndex = 0;
            this.LDBButton.UseVisualStyleBackColor = true;
            this.LDBButton.Click += new System.EventHandler(this.LDBButton_Click);
            // 
            // WebAdvisorButton
            // 
            this.WebAdvisorButton.Image = ((System.Drawing.Image)(resources.GetObject("WebAdvisorButton.Image")));
            this.WebAdvisorButton.Location = new System.Drawing.Point(481, 116);
            this.WebAdvisorButton.Name = "WebAdvisorButton";
            this.WebAdvisorButton.Size = new System.Drawing.Size(150, 150);
            this.WebAdvisorButton.TabIndex = 1;
            this.WebAdvisorButton.UseVisualStyleBackColor = true;
            this.WebAdvisorButton.Click += new System.EventHandler(this.WebAdvisorButton_Click);
            // 
            // D2LButton
            // 
            this.D2LButton.Image = ((System.Drawing.Image)(resources.GetObject("D2LButton.Image")));
            this.D2LButton.Location = new System.Drawing.Point(268, 116);
            this.D2LButton.Name = "D2LButton";
            this.D2LButton.Size = new System.Drawing.Size(150, 150);
            this.D2LButton.TabIndex = 2;
            this.D2LButton.UseVisualStyleBackColor = true;
            this.D2LButton.Click += new System.EventHandler(this.D2LButton_Click);
            // 
            // WebMailButton
            // 
            this.WebMailButton.Image = ((System.Drawing.Image)(resources.GetObject("WebMailButton.Image")));
            this.WebMailButton.Location = new System.Drawing.Point(686, 116);
            this.WebMailButton.Name = "WebMailButton";
            this.WebMailButton.Size = new System.Drawing.Size(150, 150);
            this.WebMailButton.TabIndex = 3;
            this.WebMailButton.UseVisualStyleBackColor = true;
            this.WebMailButton.Click += new System.EventHandler(this.WebMailButton_Click);
            // 
            // DSUStudentHomeButton
            // 
            this.DSUStudentHomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DSUStudentHomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DSUStudentHomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DSUStudentHomeButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSUStudentHomeButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.DSUStudentHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("DSUStudentHomeButton.Image")));
            this.DSUStudentHomeButton.Location = new System.Drawing.Point(52, 324);
            this.DSUStudentHomeButton.Name = "DSUStudentHomeButton";
            this.DSUStudentHomeButton.Size = new System.Drawing.Size(75, 75);
            this.DSUStudentHomeButton.TabIndex = 4;
            this.DSUStudentHomeButton.UseVisualStyleBackColor = false;
            this.DSUStudentHomeButton.Click += new System.EventHandler(this.DSUStudentHomeButton_Click);
            // 
            // ProctorSignUpButton
            // 
            this.ProctorSignUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ProctorSignUpButton.Image")));
            this.ProctorSignUpButton.Location = new System.Drawing.Point(229, 324);
            this.ProctorSignUpButton.Name = "ProctorSignUpButton";
            this.ProctorSignUpButton.Size = new System.Drawing.Size(75, 75);
            this.ProctorSignUpButton.TabIndex = 5;
            this.ProctorSignUpButton.UseVisualStyleBackColor = true;
            this.ProctorSignUpButton.Click += new System.EventHandler(this.ProctorSignUpButton_Click);
            // 
            // CalcButton
            // 
            this.CalcButton.Image = ((System.Drawing.Image)(resources.GetObject("CalcButton.Image")));
            this.CalcButton.Location = new System.Drawing.Point(410, 324);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 75);
            this.CalcButton.TabIndex = 6;
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // DefaultPrinterButton
            // 
            this.DefaultPrinterButton.Image = ((System.Drawing.Image)(resources.GetObject("DefaultPrinterButton.Image")));
            this.DefaultPrinterButton.Location = new System.Drawing.Point(582, 324);
            this.DefaultPrinterButton.Name = "DefaultPrinterButton";
            this.DefaultPrinterButton.Size = new System.Drawing.Size(75, 75);
            this.DefaultPrinterButton.TabIndex = 7;
            this.DefaultPrinterButton.UseVisualStyleBackColor = true;
            this.DefaultPrinterButton.Click += new System.EventHandler(this.DefaultPrinterButton_Click);
            // 
            // AdminLogOutButton
            // 
            this.AdminLogOutButton.Image = ((System.Drawing.Image)(resources.GetObject("AdminLogOutButton.Image")));
            this.AdminLogOutButton.Location = new System.Drawing.Point(761, 324);
            this.AdminLogOutButton.Name = "AdminLogOutButton";
            this.AdminLogOutButton.Size = new System.Drawing.Size(75, 75);
            this.AdminLogOutButton.TabIndex = 8;
            this.AdminLogOutButton.UseVisualStyleBackColor = true;
            this.AdminLogOutButton.Click += new System.EventHandler(this.AdminLogOutButton_Click);
            // 
            // ScrollingAnnouncement
            // 
            this.ScrollingAnnouncement.AutoSize = true;
            this.ScrollingAnnouncement.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrollingAnnouncement.Location = new System.Drawing.Point(47, 72);
            this.ScrollingAnnouncement.Name = "ScrollingAnnouncement";
            this.ScrollingAnnouncement.Size = new System.Drawing.Size(610, 26);
            this.ScrollingAnnouncement.TabIndex = 9;
            this.ScrollingAnnouncement.TabStop = true;
            this.ScrollingAnnouncement.Text = "Click Here for All the Latest Dakota State University Announcements!";
            this.ScrollingAnnouncement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ScrollingAnnouncement_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LDBLabel
            // 
            this.LDBLabel.AutoSize = true;
            this.LDBLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDBLabel.Location = new System.Drawing.Point(49, 269);
            this.LDBLabel.Name = "LDBLabel";
            this.LDBLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LDBLabel.Size = new System.Drawing.Size(140, 19);
            this.LDBLabel.TabIndex = 10;
            this.LDBLabel.Text = "LockDown Browser";
            // 
            // D2LLabel
            // 
            this.D2LLabel.AutoSize = true;
            this.D2LLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D2LLabel.Location = new System.Drawing.Point(299, 269);
            this.D2LLabel.Name = "D2LLabel";
            this.D2LLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.D2LLabel.Size = new System.Drawing.Size(80, 19);
            this.D2LLabel.TabIndex = 11;
            this.D2LLabel.Text = "D2L Portal";
            // 
            // WebAdvisorLabel
            // 
            this.WebAdvisorLabel.AutoSize = true;
            this.WebAdvisorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebAdvisorLabel.Location = new System.Drawing.Point(477, 269);
            this.WebAdvisorLabel.Name = "WebAdvisorLabel";
            this.WebAdvisorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WebAdvisorLabel.Size = new System.Drawing.Size(138, 19);
            this.WebAdvisorLabel.TabIndex = 12;
            this.WebAdvisorLabel.Text = "WebAdvisor Portal";
            // 
            // WebMailLabel
            // 
            this.WebMailLabel.AutoSize = true;
            this.WebMailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebMailLabel.Location = new System.Drawing.Point(694, 269);
            this.WebMailLabel.Name = "WebMailLabel";
            this.WebMailLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WebMailLabel.Size = new System.Drawing.Size(132, 19);
            this.WebMailLabel.TabIndex = 13;
            this.WebMailLabel.Text = "Outlook Web App";
            // 
            // DSUStudentLabel
            // 
            this.DSUStudentLabel.AutoSize = true;
            this.DSUStudentLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSUStudentLabel.Location = new System.Drawing.Point(25, 402);
            this.DSUStudentLabel.Name = "DSUStudentLabel";
            this.DSUStudentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DSUStudentLabel.Size = new System.Drawing.Size(140, 19);
            this.DSUStudentLabel.TabIndex = 14;
            this.DSUStudentLabel.Text = "DSU Student Home";
            this.DSUStudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProctorLabel
            // 
            this.ProctorLabel.AutoSize = true;
            this.ProctorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProctorLabel.Location = new System.Drawing.Point(211, 402);
            this.ProctorLabel.Name = "ProctorLabel";
            this.ProctorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProctorLabel.Size = new System.Drawing.Size(112, 19);
            this.ProctorLabel.TabIndex = 15;
            this.ProctorLabel.Text = "Proctor Signup";
            this.ProctorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcLabel
            // 
            this.CalcLabel.AutoSize = true;
            this.CalcLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcLabel.Location = new System.Drawing.Point(406, 402);
            this.CalcLabel.Name = "CalcLabel";
            this.CalcLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CalcLabel.Size = new System.Drawing.Size(78, 19);
            this.CalcLabel.TabIndex = 16;
            this.CalcLabel.Text = "Calculator";
            this.CalcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrinterLabel
            // 
            this.PrinterLabel.AutoSize = true;
            this.PrinterLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrinterLabel.Location = new System.Drawing.Point(538, 402);
            this.PrinterLabel.Name = "PrinterLabel";
            this.PrinterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrinterLabel.Size = new System.Drawing.Size(165, 19);
            this.PrinterLabel.TabIndex = 17;
            this.PrinterLabel.Text = "Change Default Printer";
            this.PrinterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.Location = new System.Drawing.Point(746, 402);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogoutLabel.Size = new System.Drawing.Size(106, 19);
            this.LogoutLabel.TabIndex = 18;
            this.LogoutLabel.Text = "Admin Logout";
            this.LogoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KioskMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 466);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.PrinterLabel);
            this.Controls.Add(this.CalcLabel);
            this.Controls.Add(this.ProctorLabel);
            this.Controls.Add(this.DSUStudentLabel);
            this.Controls.Add(this.WebMailLabel);
            this.Controls.Add(this.WebAdvisorLabel);
            this.Controls.Add(this.D2LLabel);
            this.Controls.Add(this.LDBLabel);
            this.Controls.Add(this.ScrollingAnnouncement);
            this.Controls.Add(this.AdminLogOutButton);
            this.Controls.Add(this.DefaultPrinterButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.ProctorSignUpButton);
            this.Controls.Add(this.DSUStudentHomeButton);
            this.Controls.Add(this.WebMailButton);
            this.Controls.Add(this.D2LButton);
            this.Controls.Add(this.WebAdvisorButton);
            this.Controls.Add(this.LDBButton);
            this.Name = "KioskMode";
            this.Text = "Kiosk Mode";
            this.Load += new System.EventHandler(this.KioskMode_Load);
            this.Resize += new System.EventHandler(this.KioskMode_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LDBButton;
        private System.Windows.Forms.Button WebAdvisorButton;
        private System.Windows.Forms.Button D2LButton;
        private System.Windows.Forms.Button WebMailButton;
        private System.Windows.Forms.Button DSUStudentHomeButton;
        private System.Windows.Forms.Button ProctorSignUpButton;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button DefaultPrinterButton;
        private System.Windows.Forms.Button AdminLogOutButton;

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private LinkLabel ScrollingAnnouncement;
        private Timer timer1;
        private Label LDBLabel;
        private Label D2LLabel;
        private Label WebAdvisorLabel;
        private Label WebMailLabel;
        private Label DSUStudentLabel;
        private Label ProctorLabel;
        private Label CalcLabel;
        private Label PrinterLabel;
        private Label LogoutLabel;
    }
}

