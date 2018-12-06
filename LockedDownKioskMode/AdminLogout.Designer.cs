namespace LockedDownKioskMode
{
    partial class AdminLogout
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
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.AdminLogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.Location = new System.Drawing.Point(81, 12);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(195, 23);
            this.ShutdownButton.TabIndex = 0;
            this.ShutdownButton.Text = "Shutdown";
            this.ShutdownButton.UseVisualStyleBackColor = true;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(81, 41);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(195, 23);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // AdminLogoutButton
            // 
            this.AdminLogoutButton.Location = new System.Drawing.Point(81, 70);
            this.AdminLogoutButton.Name = "AdminLogoutButton";
            this.AdminLogoutButton.Size = new System.Drawing.Size(195, 23);
            this.AdminLogoutButton.TabIndex = 2;
            this.AdminLogoutButton.Text = "Admin Logout";
            this.AdminLogoutButton.UseVisualStyleBackColor = true;
            this.AdminLogoutButton.Click += new System.EventHandler(this.AdminLogoutButton_Click);
            // 
            // AdminLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 108);
            this.Controls.Add(this.AdminLogoutButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ShutdownButton);
            this.Name = "AdminLogout";
            this.Text = "AdminLogout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShutdownButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button AdminLogoutButton;
    }
}